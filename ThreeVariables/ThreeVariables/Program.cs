using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 variables:");
            String str = Console.ReadLine();
            char ch1 = Convert.ToChar(str);

            str = Console.ReadLine();
            char ch2 = Convert.ToChar(str);

            str = Console.ReadLine();
            char ch3 = Convert.ToChar(str);

            Console.WriteLine("You enter ({0}), ({1}), ({2})", ch1, ch2, ch3);

            Console.ReadLine();
        }
    }
}
