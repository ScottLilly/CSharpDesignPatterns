using System;

namespace Engine.CompositionOverInheritance.Inheritance_AFTER
{
    public class MonsterFactory
    {
        public enum MonsterType
        {
            Horse, // BitingKickingMonster
            Orc, // BitingKickingPunchingMonster
            Crocodile, // BitingMonster
            MikeTyson, // BitingPunchingMonster
            Camel, // KickingMonster
            Kangaroo, // KickingPunchingMonster
            MantisShrimp //PunchingMonster
        }

        public static Monster CreateMonster(MonsterType monsterType)
        {
            switch(monsterType)
            {
                case MonsterType.Horse:
                    return new BitingKickingMonster(10, 5, 5);
                case MonsterType.Orc:
                    return new BitingKickingPunchingMonster(10, 5, 5, 5);
                case MonsterType.Crocodile:
                    return new BitingMonster(10, 5);
                case MonsterType.MikeTyson:
                    return new BitingPunchingMonster(10, 5, 5);
                case MonsterType.Camel:
                    return new KickingMonster(10, 5);
                case MonsterType.Kangaroo:
                    return new KickingPunchingMonster(10, 5, 5);
                case MonsterType.MantisShrimp:
                    return new PunchingMonster(10, 5);
                default:
                    throw new ArgumentException();
            }
        }
    }
}