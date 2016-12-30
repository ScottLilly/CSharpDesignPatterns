using System;
using Engine.PublishSubscribePattern.PatternVersion_CustomEventArgs.Common;

namespace Engine.PublishSubscribePattern.PatternVersion_CustomEventArgs.Models
{
    public class Player
    {
        private int _hitPoints;
        private int _numberOfDeaths;

        public EventHandler<PlayerKilledEventArgs> PlayerKilled;

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;

                if(_hitPoints <= 0)
                {
                    // Increase the "number of deaths" counter.
                    _numberOfDeaths++;

                    // When the player's HitPoint property is zero, or lower,
                    // the player object will raise a PlayerKilled notification to all subscribed objects.
                    OnPlayerKilled();
                }
            }
        }

        protected virtual void OnPlayerKilled()
        {
            PlayerKilled?.Invoke(this, new PlayerKilledEventArgs(_numberOfDeaths));
        }
    }
}