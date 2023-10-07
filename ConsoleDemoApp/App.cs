using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp;

public class App
{
    public App(IEnumerable<IAnimals> animals)
    {
        foreach (var animal in animals)
        {
            animal.PrintCharacteristics();
        }
    }

    public void Run(string[] args)
    {
        Console.WriteLine("Start console app");
        Console.WriteLine("End console app");
    }
}