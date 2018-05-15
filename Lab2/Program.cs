using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var purse = new Purse();
            
            var money = new Money();
            int a = 10;
            var goldenCarc = new GoldenCard();
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
