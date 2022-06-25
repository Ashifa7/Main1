using System;

namespace Inheritance
{
    public class Employee
    {
        public int salary = 35000;
    }
    public class Developer : Employee
    {
        public int bonus = 10000;
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Developer D1 = new Developer();
            Console.WriteLine("Salary: "+ D1.salary);
            Console.WriteLine("Bonus: "+ D1.bonus);
            Console.ReadKey();
        }
    }
}
