using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    abstract class Arithmetic
    {
        public void add(int num1,int num2)
        {
            int a = num1 + num2;
            Console.WriteLine(a);

        }
        abstract public  void Multi(int num1, int num2);

        abstract public  void Divide(int num1, int num2);

    }
    class excel : Arithmetic
    {
        public void add(int num1, int num2)
        {
            int a = num1 + num2;
            Console.WriteLine(a);

        }
        public override void Multi(int num1, int num2) 
        {
            Console.WriteLine("The addtion of {0} and {2}",num1,num2,(num1*num2));
        }
        public  override void Divide(int num1, int num2)
        {
            Console.WriteLine("The addtion of {0} and {2}", num1, num2, (num1 / num2));
        }
    }
    
    internal class Question6
    {
        public static void Main(string[] args) 
        {
            excel e = new excel();
            e.add(1,2);
            e.Multi(1,2);
            e.Divide(1,2);
        }
        
    }
}
