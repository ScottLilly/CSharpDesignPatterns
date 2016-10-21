namespace Engine.CompositionOverInheritance.Inheritance_AFTER
{
    public class PunchingMonster : Monster
    {
        public int PunchDamage { get; set; }

        public PunchingMonster(int hitPoints, int punchDamage)
            : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
    }
}