namespace Engine.FactoryPattern.PatternVersion_InternalFactory
{
    public class Player
    {
        public int HitPoints { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        private Player(int hitPoints, int experiencePoints, int gold)
        {
            HitPoints = hitPoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        public static Player CreateNewPlayer(int hitPoints, int experiencePoints, int gold)
        {
            return new Player(hitPoints, experiencePoints, gold);
        }
    }
}