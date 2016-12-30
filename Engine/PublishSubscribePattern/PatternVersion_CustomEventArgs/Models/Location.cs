namespace Engine.PublishSubscribePattern.PatternVersion_CustomEventArgs.Models
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