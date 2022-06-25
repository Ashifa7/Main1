using System;

namespace ConstructorChaining
{
    //Calling Connstructor in a constructor
    //Two Types : 1) Within same class using "this" keyword
    //2) in a derived class using "base" keyword
    //used for multiple tasks in one constructor
    class Student
    {
        int Id;
        string Name;
        int Age;
        string City;
        
        public Student(int id, string name)         //First Constructor with 2 parameters, same name as class name
        {
            this.Id = id;
            this.Name = name;
        }

        public Student(int id, string name, int age, string city) : this(id, name)        //2nd Constructor with other two parameters calling                                                                                   first constructor with :this() keyword
        { 
            this.Age = age;
            this.City = city;
        }
        class CnstrctrChaining
        {
            static void Main(string[] args)
            {
                Student s = new Student(1, "Ashifa");
                Console.WriteLine("Id: " + s.Id + " Name: " + s.Name);

                Student st = new Student(2, "Ashi", 21, "Ahmedabad");
                Console.WriteLine("Id: " + st.Id + " Name: " + st.Name + " Age: " + st.Age + " City: " + st.City);
            }

        }
        
    }
}
