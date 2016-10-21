using Engine.CompositionOverInheritance.Composition_BEFORE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.CompositionOverInheritance.Composition
{
    [TestClass]
    public class TestMonsterFactory
    {
        [TestMethod]
        public void Test_BitingMonster()
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Assert.IsTrue(crocodile.CanBite);
            Assert.IsFalse(crocodile.CanKick);
            Assert.IsFalse(crocodile.CanPunch);
        }

        [TestMethod]
        public void Test_BitingKickingMonster()
        {
            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse.CanBite);
            Assert.IsTrue(horse.CanKick);
            Assert.IsFalse(horse.CanPunch);
        }
    }
}
