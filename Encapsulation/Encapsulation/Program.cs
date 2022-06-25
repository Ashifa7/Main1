using System;

namespace OopsConcepts
{
    public class Encapsulation
    {
        private string Name;                 // Name is a field, it must be private
        private int Age;
        private string City;                //wont be called in same class since no property defined

        public string name                  // name is a property, used to access private fields or variables
        {
            get { return Name; }
            set { Name = value; }           //Inshort, encapsulation property=gets private fields and sets it in value 
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
    }
        class program
        {
            static void Main(string[] args)
            {
                Encapsulation student = new Encapsulation();

                student.name = "Ashifa";
                student.age = 21;
                student.City = "Ahmedabad";
                Console.WriteLine("My Name is {0} and I am {1} years old", student.name, student.age);
                Console.WriteLine("City = {0}", student.City);
                Console.ReadKey();
            }
        }

    }

