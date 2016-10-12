using Engine.PrototypePattern.PatternVersion_Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.PrototypePattern.PatternVersion_Simple
{
    [TestClass]
    public class TestMonster
    {
        [TestMethod]
        public void Test_PrototypePattern()
        {
            Monster standardGiantSpider = new Monster("Giant Spider", 10);

            // Calling the Clone method is how the Prototype Pattern is implemented.
            Monster spider2 = standardGiantSpider.Clone();

            Assert.AreEqual(10, standardGiantSpider.HitPoints);
            Assert.AreEqual(10, spider2.HitPoints);

            spider2.ApplyDamage(2);

            // There is no reference problem,
            // because the Clone method constructs a new Monster object.
            Assert.AreEqual(10, standardGiantSpider.HitPoints);
            Assert.AreEqual(8, spider2.HitPoints);
        }
    }
}
