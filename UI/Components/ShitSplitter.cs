using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LiveSplit.RealTimeMinusBonuses.UI.Components
{
    public partial class ShitSplitter : Form
    {
        protected ITimerModel Model { get; set; }
        protected RealTimeMinusBonusesSettings Settings { get; set; }
        protected Dictionary<int, double> lookup;

        public ShitSplitter(LiveSplitState state, RealTimeMinusBonusesSettings settings)
        {
            InitializeComponent();
            lookup = new Dictionary<int, double>();
            lookup.Add(60000, 500 / 60.0);   // 50000
            lookup.Add(90000, 100 / 60.0);   // 10000
            lookup.Add(120000, 50 / 60.0);   // 5000
            lookup.Add(150000, 40 / 60.0);   // 4000
            lookup.Add(180000, 30 / 60.0);   // 3000
            lookup.Add(210000, 10 / 60.0);   // 1000
            lookup.Add(599000, 1 / 60.0);   // 100
            lookup.Add(600000, 1000 / 60.0);   // oops

            Model = new TimerModel()
            {
                CurrentState = state
            };
            Settings = settings;
        }

        private void txtGameTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    if (txtGameTime.Text == "")
                    {
                        Model.Split();
                    }
                    else
                    {
                        var timeSpans = txtGameTime.Text.Replace(" ", "").Split('+');
                        var enteredTime = TimeSpan.Zero;
                        foreach (var time in timeSpans)
                        {
                            enteredTime += TimeSpanParser.Parse(time);
                        }
                        var curTime = Model.CurrentState.CurrentTime;
                        var newGameTime = curTime.GameTime + enteredTime;

                        Model.CurrentState.SetGameTime(newGameTime);
                        Model.Split();

                        var ms = enteredTime.TotalMilliseconds;

                        // look up the time in our lookup table
                        var keys = new List<int>(lookup.Keys);
                        int delayfor = 0;
                        for (var i = 0; i < keys.Count; i++)
                        {
                            int compms = keys[i];
                            if (ms < compms)
                            {
                                delayfor = (int)Math.Round(lookup[compms] * 1000);
                                break;
                            }
                        }
                        if (delayfor > 0)
                        {
                            Model.Pause();
                            TimeBonusesTimer.Interval = delayfor;
                            TimeBonusesTimer.Enabled = true;
                        }
                        txtGameTime.Text = "";
                    }
                }
                catch { }
            }
        }

        private void TimeBonusesTimer_Tick(object sender, EventArgs e)
        {
            TimeBonusesTimer.Enabled = false;
            Model.Pause();
        }
    }
}
