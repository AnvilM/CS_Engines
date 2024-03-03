namespace Engines.Domain.Entities.Base
{
    public class Engine
    {
        public Guid Id {get; set;}

        public int Fuel { get; set;}

        public string FuelType { get; set; } = "Petrol";

        public string Name {get; set;} = string.Empty;
    }
}