namespace FactoryDesign
{
     class VehicleFactory
    {
        
      public static IVehicle GetVehicle(string type)
      {

        IVehicle ObjectType = null;

        if (type.ToLower().Equals("car"))
        {
            ObjectType = new Car();
        }
        else if (type.ToLower().Equals("bike"))
        {
            ObjectType = new Bike();
        }
        else if(type.ToLower().Equals("rickshaw"))
        {

            ObjectType = new Rickshaw();
        }

        return ObjectType;

      }

        

    }
}