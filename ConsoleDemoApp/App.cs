using ConsoleDemoApp.Implementation;
using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp;

public class App
{
    private readonly IAnimals _domestic;
    private readonly IAnimals _wild;

    public App(Func<AnimalTypes, IAnimals> serviceResolver)
    {
        _domestic = serviceResolver(AnimalTypes.Domestic);
        _wild = serviceResolver(AnimalTypes.Wild);
    }

    public void Run(string[] args)
    {
        Console.WriteLine("Start console app");
        _domestic.PrintCharacteristics();
        _wild.PrintCharacteristics();
        Console.WriteLine("End console app");
    }
}