using ConsoleDemoApp.Implementation;
using ConsoleDemoApp.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDemoApp;

public class App
{
    private readonly IAnimals _domestic;
    private readonly IAnimals _wild;

    public App(IEnumerable<IAnimals> animals, IServiceProvider serviceProvider)
    {
        foreach (var animal in animals)
        {
            if (animal.GetType() == typeof(Domestic))
                _domestic = serviceProvider.GetService<Domestic>()!;
            if (animal.GetType() == typeof(Wild))
                _wild = serviceProvider.GetService<Wild>()!;
        }
    }

    public void Run(string[] args)
    {
        Console.WriteLine("Start console app");
        _domestic.PrintCharacteristics();
        _wild.PrintCharacteristics();
        Console.WriteLine("End console app");
    }
}