using System;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void animalsound();
        public void Eat()
        {
            Console.WriteLine("Cat Eats Cat Food");
        }
    }

    class Cat : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Cat says Meow");
        }
    }
    
    class Abstraction
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.animalsound();
            c.Eat();
        }
    }
        
}
