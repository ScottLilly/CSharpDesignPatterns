using System.Collections.Generic;
using Engine.PublishSubscribePattern.NonPatternVersion.Models;

namespace Engine.PublishSubscribePattern.NonPatternVersion.ViewModels
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
        }

        public void MonsterAttackPlayer(int amountOfDamage)
        {
            CurrentPlayer.HitPoints -= amountOfDamage;

            CheckIfPlayerWasKilled();
        }

        public void MoveToLocation(Location location)
        {
            CurrentLocation = location;

            if(CurrentLocation.Atmosphere == Location.AtmosphereType.Poisonous)
            {
                CurrentPlayer.HitPoints -= 1;

                CheckIfPlayerWasKilled();
            }
        }

        private void CheckIfPlayerWasKilled()
        {
            if(CurrentPlayer.HitPoints <= 0)
            {
                Messages.Add("You were killed");
            }
        }
    }
}