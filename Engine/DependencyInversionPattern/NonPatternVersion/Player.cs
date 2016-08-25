using System;

namespace Engine.DependencyInversionPattern.NonPatternVersion
{
    public class Player
    {
        public string Name { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        public Player(string name, int experiencePoints, int gold)
        {
            Name = name;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        public static Player CreateNewPlayer(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player name cannot be empty.");
            }

            // Create a Data Mapper object, to use to connect with the database
            PlayerDataMapper _playerDataMapper = new PlayerDataMapper();

            // Throw an exception if there is already a player with this name in the database.
            if(_playerDataMapper.PlayerNameExistsInDatabase(name))
            {
                throw new ArgumentException("Player name already exists.");
            }

            // Add the player to the database.
            _playerDataMapper.InsertNewPlayerIntoDatabase(name);

            return new Player(name, 0, 10);
        }
    }
}