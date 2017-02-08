namespace Engine.PublishSubscribePattern.PatternVersion_WithEvent.Models
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