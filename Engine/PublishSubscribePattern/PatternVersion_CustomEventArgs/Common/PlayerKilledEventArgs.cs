using System;

namespace Engine.PublishSubscribePattern.PatternVersion_CustomEventArgs.Common
{
    public class PlayerKilledEventArgs : EventArgs
    {
        public int NumberOfDeaths { get; private set; }

        public PlayerKilledEventArgs(int numberOfDeaths)
        {
            NumberOfDeaths = numberOfDeaths;
        }
    }
}