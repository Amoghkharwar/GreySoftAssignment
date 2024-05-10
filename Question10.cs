using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    delegate void mydel();
    delegate int yourdel(int a);
    internal class Question10
    {
      
        public static void Main(string[] args)
        {
            mydel obj1;
            Console.WriteLine("Greeting.....");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            if (choice == "GREET")
            {
                obj1 = new mydel(greet);
            }
            else
            {
                obj1 = new mydel(marryChritmas);

            }
            obj1();

            yourdel obj2;
            Console.WriteLine("Calculate Even And Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                obj2 = new yourdel(Even);
                Console.WriteLine("Even number");
            }
            else
            {
                obj2 = new yourdel(Odd);
                Console.WriteLine("Odd number");
            }

           
            obj2(num);
        }
        static void greet()
        {
            Console.WriteLine("Good morning");
        }
        static void marryChritmas()
        {
            Console.WriteLine("marry chritmas");
        }

        static int Even(int num)
        {
            return num;
            Console.WriteLine("Even number is " + num);
        }
        static int Odd(int num)
        {
            return num;
            Console.WriteLine("Odd number is " + num);

        }
    }
}
