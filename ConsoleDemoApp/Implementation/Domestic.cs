using ConsoleDemoApp.Interface;

namespace ConsoleDemoApp.Implementation
{
    internal class Domestic : IAnimals
    {
        public void PrintCharacteristics()
        {
            Console.WriteLine("Domestic animals live with humans as pets or on farms. Humans provide them with food and shelter.");
        }
    }
}
