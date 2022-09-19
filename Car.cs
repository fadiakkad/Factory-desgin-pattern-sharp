namespace FactoryDesign
{
    public class Car : IVehicle
    {
        int wheels = 4;
        public int NumberOfWheels()
        {
            return this.wheels;
        }
        public string VehicleType()
        {
            return "Car Class";
        }
    }
}