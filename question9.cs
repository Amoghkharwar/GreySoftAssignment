using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    internal class question9
    {
        public static void Main(string[] args)
        {
            add(12,23);
            System.Console.WriteLine("******************");
            add(12, 23,44);
            System.Console.WriteLine("******************");
            pricelist("parle","Hide ansseek","Cream Biscuits","Glucose");

        }
        static void add(params int[]a)
        {
            foreach(int i in a)
            {
                System.Console.WriteLine(i);
            }
        }
        static void pricelist(string companyname,params string[] products)
        {
            System.Console.WriteLine("{0} has the following products",companyname);
            for(int i = 0;i<products.Length;i++)
            {
                System.Console.WriteLine(products[i]);
            }
        }
    }
}
