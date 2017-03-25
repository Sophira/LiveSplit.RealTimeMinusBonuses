using LiveSplit.Delta;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(RealTimeMinusBonusesFactory))]

namespace LiveSplit.Delta
{
    public class RealTimeMinusBonusesFactory : IComponentFactory
    {
        public string ComponentName => "Real Time Minus Bonuses [RTA-TB] (Sonic 3 only)";

        public string Description => "Subtract IGT time bonuses from an RTA Sonic 3 run.";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new RealTimeMinusBonusesComponent(state);

        public string UpdateName => ComponentName;

        public string UpdateURL => "https://raw.githubusercontent.com/Sophira/LiveSplit.RealTimeMinusBonuses/master/";

        public string XMLURL => UpdateURL + "Components/update.LiveSplit.RealTimeMinusBonuses.xml";

        public Version Version => Version.Parse("0.5");
    }
}
