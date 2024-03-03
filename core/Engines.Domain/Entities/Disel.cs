using Engines.Domain.Entities.Base; 


namespace Engines.Domain.Entities
{
    public class Disel : Engine
    {
        public int Volume {get; set;}

        public int Power { get; set;}

        public int RPM { get; set;}
    }
}