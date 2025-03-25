using Design_Patterns.AbstractFactoryPattern;
using Design_Patterns.AbstractFactoryPattern.Interface;
using Design_Patterns.BuilderPttern;
using Design_Patterns.FactoryMethodPattern.NotificationSystem;
using Design_Patterns.FactoryMethodPattern.Vehicle;
using Design_Patterns.PrototypePattern;
using Design_Patterns.SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        //SingletonPattern
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log.");


        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log.");


        logger1.PrintLogs();

        //FactoryMethodPattern
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
        NotificationFactory notificationFactory = null;
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

        // PrototypePattern
        var prototypeCharacter = new Character("Warrior", 1, 100);
        Console.WriteLine("Prototype Character:");
        prototypeCharacter.Display();


        var clonedCharacter = prototypeCharacter.Clone();
        clonedCharacter.Name = "Archer";
        clonedCharacter.Level = 2;
        clonedCharacter.Power = 80;
        Console.WriteLine("\nCloned Character:");
        clonedCharacter.Display();


        Console.WriteLine("\nPrototype Character (unchanged):");
        prototypeCharacter.Display();

        //AbstractFactoryPattern
        Console.WriteLine("Which OS are you using? (windows/macos)");
        string os = Console.ReadLine().ToLower();

        IGUIFactory gUIFactory = null;
        switch (os)
        {
            case "windows":
                factory = new WindowsFactory();
                break;
            case "macos":
                factory = new MacOSFactory();
                break;
            default:
                Console.WriteLine("Invalid OS!");
                return;
        }
        if (gUIFactory != null)
        {
            var app = new Application(gUIFactory);
            app.UIRender();

        }

        //Builder Desighn Pttern
        var gamingBuilder = new GamingComputerBuilder();
        var technician = new ComputerTechnician(gamingBuilder);

        technician.BuildComputer();
        var gamingPC = technician.GetComputer();

        Console.WriteLine("Gaming PC Specs:");
        gamingPC.DisplaySpecs();
    }
}