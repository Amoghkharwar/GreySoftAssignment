using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    interface Salary
    {
        void calhra(float basic);
        void calcda(float basic);
    }
    class trainer : Salary
    {
        public void calcda(float basic)
        {
            float s = basic * 0.1f;
            Console.WriteLine("trainer calcda" + s);
        }

        public void calhra(float basic)
        {
            float s = basic * 0.1f;
            Console.WriteLine("Trainer hra" + s);
        }
    }
    class ProjectManager : Salary
    {
        public void calcda(float basic)
        {
            float s = basic * 0.1f;
            Console.WriteLine("Project Manager cda" + s);
        }



        public void calhra(float basic)
        {
            float s = basic * 0.1f;
            Console.WriteLine("Project Manager hra" + s);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectManager t = new ProjectManager();
            t.calhra(10000);
            t.calcda(20000);
            trainer trainer = new trainer();
            trainer.calhra(50000);
            trainer.calcda(60000);
        }
    }
}
