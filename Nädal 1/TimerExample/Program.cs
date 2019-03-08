using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer MyTimer = new Timer(2000);
            MyTimer.Elapsed += MyTimer_Elapsed; 

            MyTimer.Start();
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed : {0:HH:mm:ss.fff}",e.SignalTime);
        }

        
    }
}
