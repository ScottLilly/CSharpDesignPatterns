using System;
using Engine.DependencyInversionPattern.PatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.DependencyInversionPattern.PatternVersion
{
    [TestClass]
    public class TestPlayer
    {
        // Should receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }

        // Should still receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            Player player = Player.CreateNewPlayer("", mockPlayerDataMapper);
        }

        // Should receive an exception, because we set the mock PlayerDataMapper 
        // to say the player name already exists in the database.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = true;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);
        }

        // Should succeed, because we set the mock PlayerDataMapper 
        // to say the player name does not already exist in the database.
        // Also, when it calls the mock InsertNewPlayerIntoDatabase,
        // the mock mapper will not need a database running.
        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = false;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}