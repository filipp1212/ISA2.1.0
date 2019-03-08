using System;

namespace UnderstandigScope
{
    class Program
    {
        private static int j;
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                j = i;
                Console.WriteLine(i);
            }
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
