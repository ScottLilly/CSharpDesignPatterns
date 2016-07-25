namespace Engine.FactoryPattern.PatternVersion_MultipleDatatypes
{
    public static class MonsterFactory
    {
        public static Monster GetRandomMonster()
        {
            var randomNumber = 2; // Pretend we got a random number here.

            switch(randomNumber)
            {
                case 1:
                    return new FlyingMonster();
                case 2:
                    return new LandMonster();
                default:
                    return new SeaMonster();
            }
        }
    }
}