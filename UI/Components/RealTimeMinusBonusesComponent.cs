using LiveSplit.RealTimeMinusBonuses.UI.Components;
using LiveSplit.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public class RealTimeMinusBonusesComponent : LogicComponent
    {
        public RealTimeMinusBonusesSettings Settings { get; set; }

        public GraphicsCache Cache { get; set; }
        protected LiveSplitState CurrentState { get; set; }
        public Form GameTimeForm { get; set; }
        protected Point PreviousLocation { get; set; }

        public override string ComponentName => "Real Time Minus Bonuses (proof-of-concept)";

        public RealTimeMinusBonusesComponent(LiveSplitState state)
        {
            Settings = new RealTimeMinusBonusesSettings();
            GameTimeForm = new ShitSplitter(state, Settings);
            state.OnStart += state_OnStart;
            state.OnReset += state_OnReset;
            state.OnUndoSplit += State_OnUndoSplit;
            CurrentState = state;
        }

        private void State_OnUndoSplit(object sender, EventArgs e)
        {
            var curIndex = CurrentState.CurrentSplitIndex;
            var gt = (ShitSplitter)GameTimeForm;

            var lastRealTime = gt.LastSplit.RealTime;
            var lastGameTime = gt.LastSplit.GameTime;
            var curRealTime = CurrentState.CurrentTime.RealTime;
            var curGameTime = CurrentState.CurrentTime.GameTime;
            var realDiff = curRealTime - lastRealTime;
            var gameDiff = curGameTime - lastGameTime;

            gt.PauseInProgress = false;
            CurrentState.IsGameTimePaused = false;
            CurrentState.SetGameTime(CurrentState.CurrentTime.GameTime + (realDiff - gameDiff));
            gt.LastSplit = (CurrentState.CurrentSplitIndex > 0 ? CurrentState.Run[CurrentState.CurrentSplitIndex - 1].SplitTime : Time.Zero);
        }

        void state_OnReset(object sender, TimerPhase e)
        {
            GameTimeForm.Close();
            PreviousLocation = GameTimeForm.Location;
        }

        void state_OnStart(object sender, EventArgs e)
        {
            GameTimeForm = new ShitSplitter(CurrentState, Settings);
            CurrentState.Form.Invoke(new Action(() => GameTimeForm.Show(CurrentState.Form)));
            if (!PreviousLocation.IsEmpty)
                GameTimeForm.Location = PreviousLocation;

            CurrentState.LoadingTimes = TimeSpan.Zero;
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            var gt = (ShitSplitter)GameTimeForm;
            if (gt.PauseInProgress && (state.CurrentTime.RealTime >= gt.PauseEnd))
            {
                gt.PauseInProgress = false;
                var curTime = state.CurrentTime;
                state.SetGameTime(curTime.GameTime + (curTime.RealTime - gt.PauseEnd));
                state.IsGameTimePaused = false;
            }
        }

        public override void Dispose()
        {
            if (GameTimeForm != null && !GameTimeForm.IsDisposed)
                GameTimeForm.Close();
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnReset -= state_OnReset;
            CurrentState.OnUndoSplit -= State_OnUndoSplit;
        }

        public int GetSettingsHashCode()
        {
            return Settings.GetSettingsHashCode();
        }
    }
}
