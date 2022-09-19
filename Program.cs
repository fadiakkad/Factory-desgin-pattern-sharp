namespace FactoryDesign
{
    class program
    {

            static void Main(string[] args)
            {

                string inputFromConsole ;
                Console.WriteLine("input car type");

                inputFromConsole = Console.ReadLine();

                IVehicle Type = VehicleFactory.GetVehicle(inputFromConsole);
                Console.WriteLine("The type is:" + Type.VehicleType());
                Console.WriteLine("Wheels number are:" + Type.NumberOfWheels());


            }


    }



}
