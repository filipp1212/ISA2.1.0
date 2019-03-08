using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Porche";
            car1.Model = "911";

            Car car2 = new Car();
            car2.Make = "Ferrari";
            car2.Model = "LaFerrari";

            Book BK = new Book();
            BK.Author = "Bob";
            BK.Title = "Microsoft";
            BK.ISBN = "00";

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
