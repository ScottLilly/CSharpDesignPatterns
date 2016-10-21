namespace Engine.CompositionOverInheritance.Inheritance_AFTER
{
    public class BitingKickingPunchingMonster : BitingMonster
    {
        public int KickDamage { get; set; }
        public int PunchDamage { get; set; }

        public BitingKickingPunchingMonster(int hitPoints, int biteDamage, int kickDamage, int punchDamage)
            : base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
            PunchDamage = punchDamage;
        }
    }
}