using System;

namespace Engine.PublishSubscribePattern.PatternVersion.Models
{
    public class Player
    {
        private int _hitPoints;

        public EventHandler PlayerKilled;

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;

                if(_hitPoints <= 0)
                {
                    // When the player's HitPoint property is zero, or lower,
                    // the player object will raise a PlayerKilled notification to all subscribed objects.
                    OnPlayerKilled();
                }
            }
        }

        private void OnPlayerKilled()
        {
            // If there are no subscribed objects,
            // the PlayerKilled EventHandler will be null, 
            // and nothing will be notified of this event.
            PlayerKilled?.Invoke(this, EventArgs.Empty);
        }
    }
}