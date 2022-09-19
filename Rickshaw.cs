namespace FactoryDesign
{
    public class Rickshaw : IVehicle
    {
        int wheels = 3;
        public int NumberOfWheels()
        {
            return this.wheels;
        }

        public string VehicleType()
        {
            return "Richshaw class";
        }
    }
}