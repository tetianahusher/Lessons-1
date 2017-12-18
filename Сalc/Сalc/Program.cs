using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            String str = Console.ReadLine();
            bool isCorrect = Int32.TryParse(str, out a);
            if(!isCorrect)
            {
                Console.WriteLine("Incorrect number");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter b:");
            str = Console.ReadLine();
            isCorrect = Int32.TryParse(str, out b);
            if (!isCorrect)
            {
                Console.WriteLine("Incorrect number");
                Console.ReadLine();
                return;
            }

            double result = 0;
            result = a + b;
            Console.WriteLine("a + b = {0}", result);

            result = a - b;
            Console.WriteLine("a - b = {0}", result);

            result = a * b;
            Console.WriteLine("a * b = {0}", result);

            result = (double)a / b;
            Console.WriteLine("a / b = {0:F3}", result);

            Console.ReadLine();
        }
    }
}
