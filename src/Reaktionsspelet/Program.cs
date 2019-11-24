using System;
using System.Threading;

namespace Reaktionsspelet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till reaktionsspelet!");
            Console.WriteLine("Ok, get ready...");

            NumberGenerator newTime = new NumberGenerator();
            int sleepTime = newTime.ReturnsARandomNumber();

            Thread.Sleep(sleepTime);

            Console.WriteLine(sleepTime);
            Console.WriteLine("Now!");
        }
    }
}
