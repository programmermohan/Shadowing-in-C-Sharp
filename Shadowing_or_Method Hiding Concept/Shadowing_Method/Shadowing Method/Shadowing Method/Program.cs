using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowing_Method
{
    class Program
    {
        public string GetMethod()
        {
            return "Base Class String";
        }
        public void ShowMethod()
        {
            Console.WriteLine("Base Class Show Method");
        }
    }
    class NewProgram : Program
    {
        public new int GetMethod()     // in shadowing we can change the return type but in overriding it is not possible
        {
            return 5 ;
        }
        public new void ShowMethod()
        {
            Console.WriteLine("Derived Class Show Method");
        }
    }

    class ForMain
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Method Return:{0}", obj.GetMethod());
            obj.ShowMethod();
            obj = new NewProgram();   // creating an object of Derived class NewProgram and storing its reference in the reference
                                     // variable obj of type Program
            Console.WriteLine("Method Return:{0}", obj.GetMethod());
            obj.ShowMethod();
            NewProgram obj1 = new NewProgram();
            Console.WriteLine("Method Return:{0}", obj1.GetMethod());
            obj1.ShowMethod();
            obj1 = (NewProgram)obj; // cast the Base class object to Derived class type
            Console.WriteLine("Method Return:{0}", obj1.GetMethod());
            obj1.ShowMethod();
            Program NewObj = (Program)obj1;  // cast the derived class object to base class type
            Console.WriteLine("Method Return:{0}", NewObj.GetMethod());
            NewObj.ShowMethod();
            Console.Read();
        }
    }
}
