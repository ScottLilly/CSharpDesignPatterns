using System;
using System.Collections.Generic;
using Engine.PublishSubscribePattern.PatternVersion_WithEvent.Models;

namespace Engine.PublishSubscribePattern.PatternVersion_WithEvent.ViewModels
{
    public class GameSession
    {
        public List<string> Messages { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            Messages = new List<string>();

            CurrentPlayer = new Player {HitPoints = 10};
            CurrentLocation = new Location {Atmosphere = Location.AtmosphereType.Normal};

            // "Subscribe" to the PlayerKilled event.
            //
            // When the GameSession object receives this notification,
            // it will run the HandlePlayerKilled function.
            CurrentPlayer.PlayerKilled += HandlePlayerKilled;
        }

        public void MonsterAttackPlayer(int amountOfDamage)
        {
            CurrentPlayer.HitPoints -= amountOfDamage;
        }

        public void MoveToLocation(Location location)
        {
            CurrentLocation = location;

            if(CurrentLocation.Atmosphere == Location.AtmosphereType.Poisonous)
            {
                CurrentPlayer.HitPoints -= 1;
            }
        }

        private void HandlePlayerKilled(object sender, EventArgs eventArgs)
        {
            Messages.Add("You were killed");
        }
    }
}