using Engine.FactoryPattern.PatternVersion_InternalFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.FactoryPattern
{
    [TestClass]
    public class TestFactoryPattern_PatternVersion_InternalFactory
    {
        [TestMethod]
        public void Test_InstantiatePlayer()
        {
            Player player = Player.CreateNewPlayer(10, 0, 25);

            Assert.AreEqual(10, player.HitPoints);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(25, player.Gold);
        }
    }
}
