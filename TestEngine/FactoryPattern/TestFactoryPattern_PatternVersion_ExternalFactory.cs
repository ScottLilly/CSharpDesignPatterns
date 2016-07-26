using Engine.FactoryPattern.PatternVersion_ExternalFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.FactoryPattern
{
    [TestClass]
    public class TestFactoryPattern_PatternVersion_ExternalFactory
    {
        [TestMethod]
        public void Test_InstantiatePlayer()
        {
            Player player = PlayerFactory.LoadPlayer();

            Assert.AreEqual(10, player.HitPoints);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(25, player.Gold);
        }
    }
}
