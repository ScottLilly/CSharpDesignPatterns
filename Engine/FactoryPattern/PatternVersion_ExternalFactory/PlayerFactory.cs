namespace Engine.FactoryPattern.PatternVersion_ExternalFactory
{
    public static class PlayerFactory
    {
        public static Player LoadPlayer()
        {
            return new Player(10, 0, 25);
        }
    }
}