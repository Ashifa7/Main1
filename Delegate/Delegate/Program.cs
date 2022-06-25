using System;

namespace Delegate
{
    public delegate void Calculate(int a, int b);
    class Program
    {
        public static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is: "+ c);
        }
        public static void Subtraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Subtraction is: " + c);
        }
        public static void Multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication is: " + c);
        }
        public static void Division(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Division is: " + c);
        }
        static void Main(string[] args)
        {
            Calculate obj = new Calculate(Program.Addition);
            obj(10,20);
            obj = Subtraction;
            obj(20,20);
            obj = Multiplication;
            obj(30,20);
            obj = Division;
            obj(40,20);

            Console.ReadLine();
        }
    }
}
