using System;

namespace införprov1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4.24
            for (int i = 1; i < 100; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            /* 5.23

            int[] tal = new int[5];
            int maxAntal = 0;
            Console.WriteLine("Skriv in 5 tal på varsin rad:");

            for (int i = 0; i < 5; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tal.Length; i++)
            {
                int antal = 0;
                for (int j = 0; j < tal.Length; j++)
                {
                    if (tal[i] == tal[j])
                    {
                        antal++;
                    }
                }

                if (antal > maxAntal)
                {
                    maxAntal = antal;
                }

            }

            Console.WriteLine("Följande tal är vanligast:");

            for (int i = 0; i < tal.Length; i++)
            {
                bool taletFinnsTidigare = false;

                for (int j = 0; j < i; j++)
                {
                    if (tal[i] == tal[j])
                    {
                        taletFinnsTidigare = true;
                        break;
                    }
                }

                if (taletFinnsTidigare)
                {
                    continue;
                }

                int antal = 1;
                for (int j = i + 1; j < tal.Length; j++)
                {
                    if (tal[i] == tal[j])
                    {
                        antal++;
                    }
                }

                if (antal == maxAntal)
                {
                    Console.WriteLine(tal[i]);
                }
            }
            */

            Console.WriteLine("Skriv in tal du vill addera sepparerade av ett plustecken (+)");
            string addition = Console.ReadLine();

           


            /*
            int förstaPlus = addition.IndexOf("+");

            string föreFörstaPlus = addition[..förstaPlus];
            double förstaTal = double.Parse(föreFörstaPlus);

            string efterFörstaPlus = addition[förstaPlus..];

            if (efterFörstaPlus.Contains("+"))
            {
                int andraPlus = efterFörstaPlus.IndexOf("+");
            }
            */
        }
    }
}
