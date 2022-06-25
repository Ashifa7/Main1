using System;

namespace Interface
{
    interface AInterface                //Interfaces are public by default because they aim to enable other types to access class
    {
        void myMethod1();          //method withoud body
        void myMethod2();
    }

    interface BInterface
    {
        void myMethod3();
    }
        class myClass : BInterface , AInterface            //Multiple Interfaces implementation
    {
        public void myMethod1()      //Implemented class has body
        {
        Console.WriteLine("My Method 1");
        }
        public void myMethod2()
        {
            Console.WriteLine("My Method 2");
        }
        public void myMethod3()
        {
            Console.WriteLine("My Method 3");
        }

    }
    class InterfaceProg
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.myMethod1();
            obj.myMethod2();
            obj.myMethod3();
        }
    }  
}