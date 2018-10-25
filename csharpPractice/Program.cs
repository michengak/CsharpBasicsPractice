using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your fist name");
            //string FirstName = Console.ReadLine();

            //Console.WriteLine("Please enter your last name");
            //string LastName = Console.ReadLine();

            //Console.WriteLine("Hello {0}, {1}, FirstName, LastName");

            //int i = 0;
            //Console.WriteLine("Min = {0}", int.MinValue);
            //Console.WriteLine("max = {0}", int.MaxValue);

            //ternary operator

            int Number = 10;

            //bool IsNumber10;

            //if (Number == 10)
            //{
            //    IsNumber10 = true;

            //}
            //else
            //{
            //    IsNumber10 = false;
            //}
            //Console.WriteLine("Number == 10 is {0}", IsNumber10);


            //Rewrite the same algo with the ternary operator

            bool IsNumber10 = Number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", IsNumber10);


        }
    }
}
