using System;
using System.Threading;

namespace Reaktionsspelet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Välkommen till reaktionsspelet!");
            Console.WriteLine("Ok, var redo...");

            NumberGenerator newTime = new NumberGenerator();
            int sleepTime = newTime.ReturnsARandomNumber();

            Thread.Sleep(sleepTime);

            Console.WriteLine("Nu!");

            int start = Environment.TickCount;
            var read = Console.ReadKey();
            int duration = Environment.TickCount - start;

            Console.WriteLine();
            Console.WriteLine($"Din reaktionstid blev: {duration} ms");
        }
    }
}
