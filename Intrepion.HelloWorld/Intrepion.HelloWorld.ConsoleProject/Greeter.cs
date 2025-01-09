using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.ConsoleProject;

public static class Greeter
{
    public static void GetName()
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var greeting = GreetingService.Greet(name);
        Console.WriteLine(greeting);
    }
}
