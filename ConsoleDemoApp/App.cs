using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp;

public class App
{
    private readonly IAnimals _domestic;

    public App(IAnimals domestic)
    {
        _domestic = domestic;
    }

    public void Run(string[] args)
    {
        Console.WriteLine("Start console app");
        _domestic.PrintCharacteristics();
        Console.WriteLine("End console app");
    }
}