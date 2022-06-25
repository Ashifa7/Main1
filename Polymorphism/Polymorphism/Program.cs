using System;

namespace OopsConcepts
{
    public class SPBase                       //compile time polymorphism, method overloading,parameters change
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void AddNum(string c, int b, int a)                //number of parameter, order of parameters, and type of parameter different
        {
            Console.WriteLine("c + b + a = {0}", c + b + a);
        }
    }

    public class DPBase                                      //Dynamic, RunTime, Method overriding with virtual keyword in base class method
    {
        public virtual void Info()
        {
            Console.WriteLine("This a Base Class");
        }
    }

    public class DPderived : DPBase
    {
        public override void Info()
        {
            Console.WriteLine("This is a Derived Class");
        }
    }
    class SP
    {
        static void Main(string[] args)
        {
            SPBase s = new SPBase();
            s.AddNum(1, 10);
            s.AddNum("ashifa", 1, 10);
            Console.WriteLine("------------------------------------------");

            DPBase db = new DPBase();
            db.Info();
            DPderived dd = new DPderived();
            dd.Info();
            Console.ReadLine();

        }

    }
}

