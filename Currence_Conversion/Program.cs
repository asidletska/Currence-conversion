using System;

namespace Currence_Conversion
{
    class Converter
    {
        public double USD;
        public double UA;
        public double EUR;

        public Converter(double USD, double UA, double EUR)
        {
            this.USD = USD;
            this.UA = UA;
            this.EUR = EUR;

        }

    }
    class Program
    {
        static void Main()
        {
            Converter convert = new Converter(0, 0, 0);
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("Choose function:\n 1. UA - USD\n 2. UA - EUR\n 3. USD - UA\n 4. EUR - UA\n ESC - exit ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Write("Enter hryvnia:");
                        double hrivnia = Convert.ToDouble(Console.ReadLine());
                        double usd = hrivnia / 40.25;
                        Console.WriteLine($"UA - USD {usd}");
                        break;
                    case 2:
                        Console.Write("Enter hryvnia:");
                        double hrivniaEUR = Convert.ToDouble(Console.ReadLine());
                        double eur = hrivniaEUR / 43.52;
                        Console.Write($"UA - EUR  {eur}");
                        break;
                    case 3:
                        Console.Write("Enter USD:");
                        double USD = Convert.ToDouble(Console.ReadLine());
                        double dollars = USD * 40.25;
                        Console.WriteLine($"USD - UA {dollars}");
                        break;
                    case 4:
                        Console.Write("Enter EUR:");
                        double EUR = Convert.ToDouble(Console.ReadLine());
                        double euros = EUR * 43.52;
                        Console.WriteLine($"EUR - UA {euros}");
                        break;
                }
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.Escape:
                        break;
                }
            } while (consoleKey != ConsoleKey.Escape);
        }
    }
}
