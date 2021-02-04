namespace BlabberApp.Domain
{
    public class BlabEntity
    {
        // Attributes
        public string Msg { get => Msg; set => Msg = value; }

        public BlabEntity() {}
        public BlabEntity(string message)
        {
            Msg = message;
        }
    }
}