using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    public class StopWatch
    {
        private static DateTime TimeStart { get; set; }
        private static DateTime TimeStop { get; set; }
        private static bool isStarted = false;
        private static bool isStopped = false;

        private static void StartTimer(DateTime start)
        {
            if (isStarted)
            {
                throw new InvalidOperationException("Unable to start a stopwatch twice in a row.");
            }
            else
            {
                isStarted = true;
                isStopped = false;
                TimeStart = start;
            }
        }

        private static void StopTimer(DateTime stop)
        {
            if (isStopped)
            {
                throw new InvalidOperationException("Unable to stop a stopwatch twice in a row.");
            }
            else
            {
                isStarted = false;
                isStopped = true;
                TimeStop = stop;
            }
        }

        private static string ElapsedTimer() => (TimeStop - TimeStart).ToString();

        private static void Begin()
        {
            StartTimer(DateTime.Now);
            System.Console.WriteLine(" - Stopwatch has begun.");
        }
        private static void End()
        {
            StopTimer(DateTime.Now);
            Console.WriteLine($" - Stopwatch has stopped. Elapsed Time: {ElapsedTimer()}");
        }

        public  void RunProgram()
        {
            Console.WriteLine("Stopwatch program.");
            Console.WriteLine("Type \"S\" to start the program. Type \"T\" to stop the program. Type \"E\" to end the program.");

            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(false);

                if (cki.Key == ConsoleKey.E)
                {
                    Console.WriteLine(": \"E\" key was pressed.  Progam exited.");
                    return;
                }
                else if (cki.Key == ConsoleKey.S)
                {
                    Begin();
                }
                else if (cki.Key == ConsoleKey.T)
                {
                    End();
                }
                else
                {
                    Console.WriteLine("\nPlease type either \"S\" to start the program, \"T\" to stop the program, \"E\" to end the program.");
                }
            }
        }
    }
}