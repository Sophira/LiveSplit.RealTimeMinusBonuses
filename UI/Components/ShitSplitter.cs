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

        public bool PauseInProgress { get; set; }
        public TimeSpan PauseStart { get; set; }
        public TimeSpan PauseEnd { get; set; }

        // state_OnUndoSplit (defined in RealTimeMinusBonusesComponent) is only called *after*
        // it already erased the last split, so we need to save it for undo purposes.
        public Time LastSplit { get; set; }

        public ShitSplitter(LiveSplitState state, RealTimeMinusBonusesSettings settings)
        {
            InitializeComponent();
            lookup = new Dictionary<int, double>();
            lookup.Add(60000, 500 / 60.0);     // 50000
            lookup.Add(90000, 100 / 60.0);     // 10000
            lookup.Add(120000, 50 / 60.0);     // 5000
            lookup.Add(150000, 40 / 60.0);     // 4000
            lookup.Add(180000, 30 / 60.0);     // 3000
            lookup.Add(210000, 10 / 60.0);     // 1000
            lookup.Add(599000, 1 / 60.0);      // 100
            lookup.Add(600000, 1000 / 60.0);   // oops

            Model = new TimerModel()
            {
                CurrentState = state
            };
            Settings = settings;
            PauseInProgress = false;
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
                        LastSplit = Model.CurrentState.Run[Model.CurrentState.CurrentSplitIndex - 1].SplitTime;
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
                        Model.Split();
                        LastSplit = Model.CurrentState.Run[Model.CurrentState.CurrentSplitIndex - 1].SplitTime;

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
                            Model.CurrentState.IsGameTimePaused = true;
                            PauseStart = (TimeSpan)Model.CurrentState.CurrentTime.RealTime;
                            PauseEnd = PauseStart.Add(new TimeSpan(0, 0, 0, 0, delayfor));
                            PauseInProgress = true;
                        }
                        txtGameTime.Text = "";
                    }
                }
                catch { }
            }
        }
    }
}
