using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objem_a_povrch_koule
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, povrch, objem;
            double PI = 3.14;
            Console.WriteLine("Zadejte poloměr koule");
            r = Convert.ToDouble(Console.ReadLine());
            povrch = 4 * PI * r * r;
            objem = (4.0 / 3) * PI * r * r * r;
            Console.WriteLine("Povrch koule je {0} ", povrch);
            Console.WriteLine("Objem koule je {0}", objem);
            Console.Read();
        }
    }
}