using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    internal class question11
    {
        public static void Main()
        {
            Console.WriteLine("Enter a num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int ans = num1 / num2;
                Console.WriteLine("The answer is " + ans);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero " + ex.Message);
            }
        }
    }
}
