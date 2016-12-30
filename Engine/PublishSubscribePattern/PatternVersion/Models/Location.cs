namespace Engine.PublishSubscribePattern.PatternVersion.Models
{
    public class Location
    {
        public enum AtmosphereType
        {
            Normal,
            Poisonous
        }

        public AtmosphereType Atmosphere { get; set; }
    }
}