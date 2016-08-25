namespace Engine.DependencyInversionPattern.PatternVersion
{
    public interface IPlayerDataMapper
    {
        bool PlayerNameExistsInDatabase(string name);
        void InsertNewPlayerIntoDatabase(string name);
    }
}