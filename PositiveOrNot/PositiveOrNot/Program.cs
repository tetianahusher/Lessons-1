using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Enter a:");
            String str = Console.ReadLine();
            bool result = Int32.TryParse(str, out a);
            if (!result)
            {
                Console.WriteLine("Incorrect number");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter b:");
            str = Console.ReadLine();
            result = Int32.TryParse(str, out b);
            if (!result)
            {
                Console.WriteLine("Incorrect number");
                Console.ReadLine();
                return;
            }

            bool answer = a > 0 && b > 0;
            Console.WriteLine(answer);
            
            Console.ReadLine();

        }
    }
}
