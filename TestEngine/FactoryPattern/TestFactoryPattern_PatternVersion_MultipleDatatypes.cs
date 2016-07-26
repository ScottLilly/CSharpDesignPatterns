using Engine.FactoryPattern.PatternVersion_MultipleDatatypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.FactoryPattern
{
    [TestClass]
    public class TestFactoryPattern_PatternVersion_MultipleDatatypes
    {
        [TestMethod]
        public void Test_InstantiateMonster()
        {
            Monster monster = MonsterFactory.GetRandomMonster();

            Assert.IsTrue(monster is FlyingMonster || monster is LandMonster || monster is SeaMonster);
        }
    }
}