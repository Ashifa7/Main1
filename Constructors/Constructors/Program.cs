using System;

namespace Constructors             //same name as class, no return type like void,int, used to initialize obj, called when obj created
{
    public class add
    {
        int a, b;
        static long dt;
     
        
        public add()               //Default Constructor
        {
            a = 10;
            b = 10;
        }
       
        
        public add(int x, int y)   //parameterized constructor
        {
            a = x;
            b = y;
        }

        
        static add()                //static constructor
        {
            dt = DateTime.Now.Ticks;
        }
        public void display()           //method to execute static before obj created
        {
            Console.WriteLine(dt);
        }


        static void Main(string[] args)
        {
            add obj = new add();                   //constructor called
            Console.WriteLine(obj.a + obj.b);

            add obj1 = new add(20, 20);
            Console.WriteLine(obj1.a + obj1.b);

            add obj2 = new add();
            obj2.display();
            
        }
    }
}



//static constructor : only 1 static constructor within a class is allowed
//used to initialize static data
//executed even BEFORE 1st instance(obj) of class is created
//no access modifiers allowed when creating static constructor
//cant access non static data members of class
