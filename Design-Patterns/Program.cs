using Design_Patterns.FactoryMethodPattern;
using Design_Patterns.SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log.");

        
        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log.");

        
        logger1.PrintLogs();


        Console.WriteLine("Which vehicle do you want to create? (car/motorcycle/truck)");
        string vehicleType = Console.ReadLine().ToLower();

        VehicleFactory factory = null;

        switch (vehicleType)
        {
            case "car":
                factory = new CarFactory();
                break;
            case "motorcycle":
                factory = new MotorcycleFactory();
                break;
            case "truck":
                factory = new TruckFactory();
                break;
            default:
                Console.WriteLine("Invalid vehicle type!");
                return;
        }

        if (factory != null)
        {
            factory.DeliverVehicle();
        }
    }



}
