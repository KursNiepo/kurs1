using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy1
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Podaj a: ");
            string vala = Console.ReadLine();
            Console.Write("Podaj b: ");
            string valb = Console.ReadLine();
            int aa = Convert.ToInt32(vala);
            int bb = Convert.ToInt32(valb);
            
            Console.WriteLine(aa+" + "+bb+" = "+(aa+bb));
            Console.ReadKey();
        }
    }
}
