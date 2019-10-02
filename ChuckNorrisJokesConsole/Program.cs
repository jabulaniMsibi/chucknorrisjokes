using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            JokeGenerator GenerateJoke = new JokeGenerator();
            string randomJoke = await GenerateJoke.GetRandomJoke();
            Console.WriteLine(randomJoke);

            string[] categories = await GenerateJoke.GetCategories();
            for (int index = categories.Length - 1; index >= 0; index--)
                Console.WriteLine(categories[index]);
        }
    }
}
