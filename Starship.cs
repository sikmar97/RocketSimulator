namespace RocketSimulator
{
    internal class Starship : Rocket
    {
        public Starship() : base("StarShip", "SpaceX", 1100000)
        {
        }

        public override void EngineBurn(int sec)
        {
            VelocityInKilometersPerSecond = (decimal)(0.0008 * sec);
            FuelAmountInKilograms -= 250;
        }
    }
}