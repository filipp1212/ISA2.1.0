using System;

namespace AssmebliesAndNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "asas kukuk";
            System.IO.File.WriteAllText(@"C:/User/tt", text);
            Console.ReadLine();
        }
    }
}
