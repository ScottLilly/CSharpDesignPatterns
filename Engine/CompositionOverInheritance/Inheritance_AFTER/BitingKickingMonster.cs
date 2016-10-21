namespace Engine.CompositionOverInheritance.Inheritance_AFTER
{
    public class BitingKickingMonster : BitingMonster
    {
        public int KickDamage { get; set; }

        public BitingKickingMonster(int hitPoints, int biteDamage, int kickDamage)
            : base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
        }
    }
}