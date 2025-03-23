using Design_Patterns.FactoryMethodPattern.NotificationSystem;
using Design_Patterns.FactoryMethodPattern.Vehicle;
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

        Console.WriteLine("Which notification type do you want to send? (email/sms/push)");
        string notificationType = Console.ReadLine().ToLower();




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
        NotificationFactory notificationFactory=null;
        switch (notificationType)
        {
            case "email":
                notificationFactory = new EmailNotificationFactory();
                break;
            case "sms":
                notificationFactory = new SmsNotificationFactory();
                break;
            case "push":
                notificationFactory = new PushNotificationFactory();
                break;
            default:
                Console.WriteLine("Invalid notification type!");
                return;
        }
        if (notificationFactory != null)
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();
            notificationFactory.SendNotification(message);
        }
    }

   
}
