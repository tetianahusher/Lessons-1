using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //b) perimeter squara
            int a;
            Console.WriteLine("Enter length of squara side:");
            String str = Console.ReadLine();
            bool isCorrect = Int32.TryParse(str, out a);
            if(!isCorrect)
            {
                Console.WriteLine("Incorrect value");
            }
            else
            {
                int perimeter = 4 * a;
                Console.WriteLine("perimetr = {0}", perimeter);
            }

            //c) person name and age

            String name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you,{0}?", name);
            str = Console.ReadLine();
            isCorrect = Int32.TryParse(str, out age);
            if (!isCorrect)
            {
                Console.WriteLine("Age is incorrect");
            }
            else
            {
                Console.WriteLine("{0}, {1} age", name, age);
            }

            //d) circle

            double r;
            double length, area, volume;
            Console.WriteLine("Enter circle radius:");
            str = Console.ReadLine();
            isCorrect = Double.TryParse(str, out r);
            if (!isCorrect)
            {
                Console.WriteLine("Incorrect value");
            }
            else
            {
                length = 2 * Math.PI * r;
                area = Math.PI * r * r;
                volume = 4 / 3 * Math.PI * r * r * r;

                Console.WriteLine("length = {0:F2}", length);
                Console.WriteLine("area = {0:F2}", area);
                Console.WriteLine("volume = {0:F2}", volume);
            }

            Console.ReadLine();
        }
    }
}
