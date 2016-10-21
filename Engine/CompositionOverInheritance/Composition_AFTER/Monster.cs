using System;
using System.Collections.Generic;

namespace Engine.CompositionOverInheritance.Composition_AFTER
{
    public class Monster
    {
        public enum AttackType
        {
            Biting,
            Kicking,
            Punching,
            Spitting
        }

        public int HitPoints { get; set; }
        public Dictionary<AttackType, int> AttackTypes { get; set; }

        // These replace the functionality of checking an object's "type",
        // to see if it "is" a certain datatype (KickingMonster, BitingMonster, etc.)
        public bool CanBite => AttackTypes.ContainsKey(AttackType.Biting);
        public bool CanKick => AttackTypes.ContainsKey(AttackType.Kicking);
        public bool CanPunch => AttackTypes.ContainsKey(AttackType.Punching);
        public bool CanSpit => AttackTypes.ContainsKey(AttackType.Spitting);

        public int BiteDamage
        {
            get
            {
                if(CanBite)
                {
                    return AttackTypes[AttackType.Biting];
                }

                throw new NotSupportedException("This monster cannot bite.");
            }
        }

        public int KickDamage
        {
            get
            {
                if(CanKick)
                {
                    return AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick.");
            }
        }

        public int PunchDamage
        {
            get
            {
                if(CanPunch)
                {
                    return AttackTypes[AttackType.Punching];
                }

                throw new NotSupportedException("This monster cannot punch.");
            }
        }

        public int SpitDamage
        {
            get
            {
                if(CanSpit)
                {
                    return AttackTypes[AttackType.Spitting];
                }

                throw new NotSupportedException("This monster cannot spit.");
            }
        }

        public Monster(int hitPoints)
        {
            HitPoints = hitPoints;
            AttackTypes = new Dictionary<AttackType, int>();
        }

        public void AddAttackType(AttackType attackType, int amountOfDamage)
        {
            AttackTypes[attackType] = amountOfDamage;
        }
    }
}