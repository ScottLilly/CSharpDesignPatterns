using System;
using Engine.DependencyInversionPattern.NonPatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.DependencyInversionPattern.NonPatternVersion
{
    [TestClass]
    public class TestPlayer
    {
        // Test that we receive an exception, if the name parameter is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }

        // Other tests would require a running database, which might have problems.
    }
}