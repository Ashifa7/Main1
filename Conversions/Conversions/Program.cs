using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    //Int to Enum
    public enum Week
    {
        Monday,                 //0
        Tuesday,                //1
        Wednesday,              //2
        Thursday,               //3
        Friday,                 //4
        Saturday,               //5
        Sunday                  //6
    }
    class Conversions
    {
        static void Main(string[] args)
        {
            int a = 3, b= 5, c = 11;
            Week myDay1, myDay2, myDay3;

            myDay1 = (Week)a;
            myDay2 = (Week)b;
            myDay3 = (Week)c;
            Console.WriteLine("Int To Enum");
            Console.WriteLine(myDay1);
            Console.WriteLine(myDay2);
            Console.WriteLine(myDay3);

            Console.WriteLine();

            //DateTime To String
            var myBDate = new DateTime(2000, 11, 02);
            string str = myBDate.ToString();
            Console.WriteLine("DateTime To String");
            Console.WriteLine(myBDate);
            Console.ReadLine();

            //String to Int
            var int1 = Int16.Parse("(100)", System.Globalization.NumberStyles.AllowParentheses);
            var int2 = Int32.Parse("100");
            Console.WriteLine(@"int1 " + int1);
            Console.WriteLine(@"int2 " + int2);
        }
    }
}
