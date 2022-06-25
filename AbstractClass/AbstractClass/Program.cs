using System;

namespace AbstractClass
{
    abstract class Pen
    {
        public abstract void color();       //abstract method has no body
        public void work()              //both simple and abstract methods can be declared in abstract class
        {
            Console.WriteLine("Writing");
        }
    }
    class inkpen : Pen                  //implement abstract class
    {
        public override void color()        //override abstract method and now it has body
        {
            Console.WriteLine("Red");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            inkpen obj = new inkpen();            //obj of implemented class
            obj.color();
            obj.work();                            //calling both methods
            Console.ReadLine();
        }
    }
}
