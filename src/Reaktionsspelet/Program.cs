using System;
using System.Threading;

namespace Reaktionsspelet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program starts with a welcome message:
            Console.WriteLine();
            Console.WriteLine("Välkommen till reaktionsspelet!");
            start:  // start location if the user wants to try again.
            Console.WriteLine("Ok, var redo...");

            /* Reference to a numbergenerator that generates 
            a random sleep time to be used in Thread.Sleep: */ 
            NumberGenerator newTime = new NumberGenerator();
            int sleepTime = newTime.ReturnsARandomNumber();

            /* A for-loop with a Thread.Sleep that checks
            if a key is pressed before sleep time runs out: */
            for (int i = 0; i<1; i++)
            {
                Thread.Sleep(sleepTime);
                
                /* If a key is pressed the user gets a choice to either try again 
                or to quit the program: */
                if (Console.KeyAvailable)
                {
                    Console.WriteLine();
                    Console.WriteLine("Du tjuvstartade, försök igen.");
                    Console.Write("Välj [y] för att försöka igen ");
                    Console.Write("eller tryck på valfri tangent för att avsluta. ");

                    Console.ReadKey();
                    ConsoleKeyInfo choice;
                    choice = Console.ReadKey();

                    if (choice.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        goto start;
                    }
                    else if (choice.Key != ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }

            /* When sleep time runs out a TickCount starts measuring recation time.
            When a key is pressed the program displays the reaction time: */
            Console.WriteLine("Nu!");

            int start = Environment.TickCount;
            var read = Console.ReadKey();
            int duration = Environment.TickCount - start;

            Console.WriteLine();
            Console.WriteLine($"Din reaktionstid blev: {duration} ms");

            // A check whether the user wants to try again or to quit the program:
            Console.WriteLine();
            Console.WriteLine("Vill du försöka igen?");
            Console.Write("Välj [y] för att försöka igen ");
            Console.Write("eller tryck på valfri tangent för att avsluta. ");

            ConsoleKeyInfo choiceToEnd;
            choiceToEnd = Console.ReadKey();

            if (choiceToEnd.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                goto start;
            }
            else if (choiceToEnd.Key != ConsoleKey.Y)
            {
                Console.WriteLine();
                return;
            }
        }
    }
}
