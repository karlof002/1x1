

using System;

namespace Table1x1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1x1 Tabelle");
            for (int i = 1; i <= 10; i++)
            {
                for (int u = 1; u <= 10; u++)
                {
                    Console.WriteLine("{0,2} mal {1,2} ist {2,3}", i, u, i * u);
                }
                Console.WriteLine("\n\nBeliebige Taste drücken!\n");
                Console.ReadKey();
            }

        }
    }
}
