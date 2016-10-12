using Engine.PrototypePattern.NonPatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.PrototypePattern.NonPatternVersion
{
    [TestClass]
    public class TestMonster
    {
        [TestMethod]
        public void Test_ReferenceProblem()
        {
            Monster spider1 = new Monster("Giant Spider", 10);
            Monster spider2 = spider1;

            Assert.AreEqual(10, spider1.HitPoints);
            Assert.AreEqual(10, spider2.HitPoints);

            spider2.ApplyDamage(2);

            // Even though we only called ApplyDamage on spider2, 
            // the HitPoints for both spider objects is 8.
            //
            // This is because the spider variables are pointing to (referencing)
            // a single spider object - the original spider1.
            Assert.AreEqual(8, spider1.HitPoints);
            Assert.AreEqual(8, spider2.HitPoints);
        }

        [TestMethod]
        public void Test_ReferenceProblemSolution()
        {
            Monster spider1 = new Monster("Giant Spider", 10);
            Monster spider2 = new Monster("Giant Spider", 10);

            Assert.AreEqual(10, spider1.HitPoints);
            Assert.AreEqual(10, spider2.HitPoints);

            spider2.ApplyDamage(2);

            // There is no reference problem, 
            // because we created spider2 by calling the Monster constructor.
            Assert.AreEqual(10, spider1.HitPoints);
            Assert.AreEqual(8, spider2.HitPoints);
        }
    }
}
