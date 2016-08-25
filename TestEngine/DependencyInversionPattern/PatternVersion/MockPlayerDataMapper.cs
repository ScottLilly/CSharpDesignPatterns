using Engine.DependencyInversionPattern.PatternVersion;

namespace TestEngine.DependencyInversionPattern.PatternVersion
{
    public class MockPlayerDataMapper : IPlayerDataMapper
    {
        // This property holds the value for PlayerNameExistsInDatabase to return.
        // This lets us "mock" the results that we would receive from a real database.
        public bool ResultToReturn { get; set; }

        // These functions implement the IPlayerDataMapper interface.
        public bool PlayerNameExistsInDatabase(string name)
        {
            // This is whatever answer we need, for the current unit test.
            return ResultToReturn;
        }

        public void InsertNewPlayerIntoDatabase(string name)
        {
        }
    }
}