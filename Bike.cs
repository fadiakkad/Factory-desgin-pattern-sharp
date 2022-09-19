namespace FactoryDesign
{
    public class Bike : IVehicle
    {
        int wheels = 2;
        public int NumberOfWheels()
        {
            return this.wheels;
        }

        public string VehicleType()
        {
            return "Bike Class";
        }
    }
}