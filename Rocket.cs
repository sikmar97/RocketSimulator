namespace RocketSimulator
{
    abstract class Rocket
    {
        private string model;
        private string brand;
     

        public Rocket(string brand, string model, uint fuelAmountInKilograms)
        {
            this.brand = brand;
            this.model = model;
            FuelAmountInKilograms = fuelAmountInKilograms;
        }

        public decimal VelocityInKilometersPerSecond { get; protected set; }
        public uint FuelAmountInKilograms { get; protected set; }

        public string Model
        {
            get
            {
                return model;
            }
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public abstract void EngineBurn(int sec);
    }
}