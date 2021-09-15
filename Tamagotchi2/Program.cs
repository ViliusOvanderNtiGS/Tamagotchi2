using System;
using System.Linq;

namespace Tamagotchi2
{
    class Program
    {
        static void Main(string[] args)
        {

            Tamagotchi tama = new Tamagotchi();

            System.Console.WriteLine("Nu har du gått och skaffat en tamagotchi");
            System.Console.WriteLine("försök att få den att inte dö.");

            System.Console.WriteLine("vad ska din sak heta?");
            tama.name = Console.ReadLine();
            Console.Clear();

            while (tama.GetAlive())
            {

            }

            Console.ReadLine();


        }
    }
}
