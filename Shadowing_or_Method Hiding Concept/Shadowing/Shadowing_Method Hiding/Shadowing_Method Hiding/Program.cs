using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowing_Method_Hiding
{
    class Program
    {
        public string GetString()
        {
            return "Base Class String";
        }
        public void Show()
        {
            Console.WriteLine("Base Class Show Method");
        }
    }
    class NewProgram : Program
    {
        public new string GetString()
        {
            return "Derived Class String";
        }
        public new void Show()
        {
            Console.WriteLine("Derived Class Show Method");
        }
    }

    class ForMain
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string Str = obj.GetString();
            Console.WriteLine("Method Return:{0}", Str);
            obj.Show();
            obj = new NewProgram();  // creating an object of Derived class NewProgram and storing its reference in the reference
                                    // variable obj of type Program
            Str = obj.GetString();
            Console.WriteLine("Method Return:{0}", Str);  // see craefully in shadowing it will give base class method //
            obj.Show();                                  // see craefully in shadowing it will give base class method //
            NewProgram obj1 = new NewProgram(); // New derived class object //
            Str = obj1.GetString();
            Console.WriteLine("Method Return:{0}", Str);
            obj1.Show();
            obj1 = (NewProgram)obj;  // cast the Base class object to Derived class type
            Str = obj1.GetString();
            Console.WriteLine("Method Return:{0}", Str);
            obj1.Show();
            Program NewObj = (Program)obj1;  // Casting derive class object to base class type //
            Str = NewObj.GetString();
            Console.WriteLine("Method Return:{0}", Str); // in shadowing it will give base class method
            NewObj.Show();                              // in shadowing it will give base class method    
            Console.Read();
        }
    }
}
