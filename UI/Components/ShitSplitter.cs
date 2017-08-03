using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace LiveSplit.RealTimeMinusBonuses.UI.Components
{
    public partial class ShitSplitter : Form
    {
        protected ITimerModel Model { get; set; }
        protected RealTimeMinusBonusesLocalSettings LocalSettings { get; set; }
        protected SortedDictionary<int, int> lookup;

        public bool PauseInProgress { get; set; }
        public TimeSpan PauseStart { get; set; }
        public TimeSpan PauseEnd { get; set; }

        // state_OnUndoSplit (defined in RealTimeMinusBonusesComponent) is only called *after*
        // it already erased the last split, so we need to save it for undo purposes.
        public Time LastSplit { get; set; }

        public ShitSplitter(LiveSplitState state, RealTimeMinusBonusesLocalSettings settings)
        {
            InitializeComponent();
            LocalSettings = settings;

            Model = new TimerModel()
            {
                CurrentState = state
            };
            PauseInProgress = false;
        }

        private void txtGameTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var entryerror = 0;
                try
                {
                    if (txtGameTime.Text == "")
                    {
                        Model.Split();
                    }
                    else
                    {
                        int points = -1;
                        if (LocalSettings.InputMethod == RealTimeMinusBonusesComponent.InputMethodEnum.IngameTime)
                        {

                            var timeSpans = txtGameTime.Text.Replace(" ", "").Split('+');
                            var enteredTime = TimeSpan.Zero;
                            foreach (var time in timeSpans)
                            {
                                enteredTime += TimeSpanParser.Parse(time);
                            }
                            var curTime = Model.CurrentState.CurrentTime;

                            var ms = enteredTime.TotalMilliseconds;

                            // look up the time in our lookup table
                            foreach (int compms in LocalSettings.IGTLookup.Keys)
                            {
                                if (ms < compms)
                                {
                                    points = LocalSettings.IGTLookup[compms];
                                    break;
                                }
                            }
                        }
                        else if (LocalSettings.InputMethod == RealTimeMinusBonusesComponent.InputMethodEnum.Points)
                        {
                            points = Int32.Parse(txtGameTime.Text);
                            points *= LocalSettings.PointsMultiplicationFactor;
                        }

                        if (points != -1)
                        {
                            Model.Split();
                            int frames = points / LocalSettings.PointsPerFrame;   // yes, assigning to an int without a round; it's deliberate! We want it to round down.
                            double delaysecs = frames / LocalSettings.FramesPerSecond;

                            int delayfor = (int)Math.Round(delaysecs * 1000);
                            if (delayfor > 0)
                            {
                                Model.CurrentState.IsGameTimePaused = true;
                                PauseStart = (TimeSpan)Model.CurrentState.CurrentTime.RealTime;
                                PauseEnd = PauseStart.Add(new TimeSpan(0, 0, 0, 0, delayfor));
                                PauseInProgress = true;
                            }
                        }
                        else
                        {
                            entryerror = 1;
                        }
                    }
                }
                catch {
                    entryerror = 1;
                }
                if (entryerror == 1)
                {
                    // signal a probable error in the input
                    txtGameTime.BackColor = Color.MistyRose;
                    txtGameTime.ForeColor = Color.Black;
                }
                else
                {
                    txtGameTime.BackColor = SystemColors.Window;
                    txtGameTime.ForeColor = SystemColors.WindowText;
                    txtGameTime.Text = "";
                }
            }
        }

        private void ShitSplitter_Load(object sender, EventArgs e)
        {
            if (LocalSettings.InputMethod == RealTimeMinusBonusesComponent.InputMethodEnum.IngameTime)
            {
                labelInputExpected.Text = "IGT:";
                this.Text = "Enter In-game Time";
            }
            else if (LocalSettings.InputMethod == RealTimeMinusBonusesComponent.InputMethodEnum.Points)
            {
                labelInputExpected.Text = "Points:";
                this.Text = "Enter Points Bonus";
            }
            txtGameTime.BackColor = SystemColors.Window;
            txtGameTime.ForeColor = SystemColors.WindowText;
        }

        private void txtGameTime_TextChanged(object sender, EventArgs e)
        {
            txtGameTime.BackColor = SystemColors.Window;
            txtGameTime.ForeColor = SystemColors.WindowText;
        }
    }
}
