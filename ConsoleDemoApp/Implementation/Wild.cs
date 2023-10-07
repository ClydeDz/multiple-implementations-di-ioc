using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp.Implementation
{
    internal class Wild : IAnimals
    {
        public void PrintCharacteristics()
        {
            Console.WriteLine("Wild animals live in the wildlife. They forge their own food and shelter.");
        }
    }
}
