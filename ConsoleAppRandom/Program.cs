using System;
using System.Threading;

namespace ConsoleAppRandom
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int lowerASCIIBound = 32;
            const int upperASCIIBound = 128;

            Random rand = new Random();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            for (int i = 1; i < 10000;)
            {
                i += 2;
                Console.ForegroundColor = (ConsoleColor)rand.Next(10, 16);
                char c = Convert.ToChar(rand.Next(lowerASCIIBound, upperASCIIBound));             
                Console.SetCursorPosition(rand.Next(1,115), rand.Next(1,29));
                Console.Write(c);
                Console.WriteLine(i);
                Console.WriteLine();
                Thread.Sleep(20);
            }

        }
    }
}
