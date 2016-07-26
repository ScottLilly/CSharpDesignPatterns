using Engine.FactoryPattern.NonPatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.FactoryPattern
{
    [TestClass]
    public class TestFactoryPattern_NonPatternVersion
    {
        [TestMethod]
        public void Test_InstantiatePlayer()
        {
            Player player = new Player(10, 0, 25);

            Assert.AreEqual(10, player.HitPoints);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(25, player.Gold);
        }
    }
}