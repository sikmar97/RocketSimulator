namespace RocketSimulator
{
    internal class Falcon_9 : Rocket
    {
        public Falcon_9() : base("Falcon 9", "SpaceX", 287400)
        {
        }

        public override void EngineBurn(int sec)
        {

            VelocityInKilometersPerSecond = (decimal)(0.0005 * sec);
            FuelAmountInKilograms -= 250;



        }
    }
}