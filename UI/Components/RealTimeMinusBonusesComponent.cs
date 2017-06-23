using LiveSplit.RealTimeMinusBonuses.UI.Components;
using LiveSplit.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LiveSplit.UI.Components
{
    public class RealTimeMinusBonusesLocalSettings
    {
        // we save a copy of the various settings when the run starts;
        // a settings change requires restarting the run to take effect.
        public RealTimeMinusBonusesComponent.InputMethodEnum InputMethod { get; set; }
        public int PointsPerFrame { get; set; }
        public double FramesPerSecond { get; set; }
        public SortedDictionary<int, int> IGTLookup { get; set; }

        public RealTimeMinusBonusesLocalSettings(RealTimeMinusBonusesSettings settings)
        {
            InputMethod = settings.InputMethod;
            PointsPerFrame = settings.PointsPerFrame;
            FramesPerSecond = settings.FramesPerSecond;
            IGTLookup = new SortedDictionary<int, int>(settings.IGTLookup);
        }
    }

    public class RealTimeMinusBonusesComponent : LogicComponent
    {
        public RealTimeMinusBonusesSettings Settings { get; set; }
        public RealTimeMinusBonusesLocalSettings LocalSettings { get; set; }

        public GraphicsCache Cache { get; set; }
        protected LiveSplitState CurrentState { get; set; }
        public Form GameTimeForm { get; set; }
        protected Point PreviousLocation { get; set; }

        public enum InputMethodEnum
        {
            IngameTime,
            Points
        }

        public override string ComponentName => "Real Time Minus Bonuses [RTA-TB]";

        public RealTimeMinusBonusesComponent(LiveSplitState state)
        {
            Settings = new RealTimeMinusBonusesSettings();
            LocalSettings = new RealTimeMinusBonusesLocalSettings(Settings);
            GameTimeForm = new ShitSplitter(state, LocalSettings);
            state.OnStart += state_OnStart;
            state.OnReset += state_OnReset;
            state.OnUndoSplit += State_OnUndoSplit;
            state.OnSplit += State_OnSplit;
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

        private void State_OnSplit(object sender, EventArgs e)
        {
            var curIndex = CurrentState.CurrentSplitIndex;
            var gt = (ShitSplitter)GameTimeForm;
            gt.LastSplit = (curIndex > 0 ? CurrentState.Run[curIndex - 1].SplitTime : Time.Zero);
        }

        void state_OnReset(object sender, TimerPhase e)
        {
            GameTimeForm.Close();
            PreviousLocation = GameTimeForm.Location;
        }

        void state_OnStart(object sender, EventArgs e)
        {
            // take a copy of the settings
            LocalSettings = new RealTimeMinusBonusesLocalSettings(Settings);

            GameTimeForm = new ShitSplitter(CurrentState, LocalSettings);
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
