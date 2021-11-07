using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Football Federation of Armenia";
            Console.WriteLine(str._IsNullOrEmpty());
            Console.WriteLine(str._Contains('k'));
            Console.WriteLine(str._IndexOf('f'));
            Console.WriteLine(str._IndexOf('f', 2));
            Console.WriteLine(str._IndexOf('f', 2, 4));
            Console.WriteLine(str._Replace("Armenia", "Japony"));
            Console.WriteLine(str._Replace("Football", "Bascetball"));
        }
    }
}
