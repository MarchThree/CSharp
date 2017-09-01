using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(1000);
            t.Enabled = true;
            t.Elapsed += timeTest;
            Console.ReadKey();
        }

        static void timeTest(object sender, ElapsedEventArgs e) {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToLongTimeString());
        }
    }
}
