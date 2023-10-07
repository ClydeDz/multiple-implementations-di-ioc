using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp;

public class App
{
    private readonly IAnimals _domestic;
    private readonly IAnimals _wild;

    public App(IAnimals domestic, IAnimals wild)
    {
        _domestic = domestic;
        _wild = wild;
    }

    public void Run(string[] args)
    {
        Console.WriteLine("Start console app");
        _domestic.PrintCharacteristics();
        _wild.PrintCharacteristics();
        Console.WriteLine("End console app");
    }
}