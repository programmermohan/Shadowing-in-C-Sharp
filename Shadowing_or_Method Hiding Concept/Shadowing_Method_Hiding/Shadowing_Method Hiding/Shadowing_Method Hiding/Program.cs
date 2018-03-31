using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowing_Method_Hiding
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Base Class Constructor Called");
        }

        public void Show()
        {
            Console.WriteLine("Base Class Method Show Called");
        }
    }

    class NewProgram : Program
    {
        public NewProgram()
        {
            Console.WriteLine("Derived Class Constructor Called");
        }
        public new void Show()
        {
            Console.WriteLine("Derived Class Method Show Called");
        }
    }

    class main
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show();
            obj = new NewProgram();
            obj.Show();
            Console.ReadKey();
        }
    }
}
