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

            //1. printing and reading for the console

            //Console.WriteLine("Please enter your first name");
            //string FirstName = Console.ReadLine();

            //Console.WriteLine("Please enter your last name");
            //string LastName = Console.ReadLine();

            //Console.WriteLine("Hello {0}, {1}, FirstName, LastName");

            //2. determining a value of a value type

            //int i = 0;
            //Console.WriteLine("Min = {0}", int.MinValue);
            //Console.WriteLine("max = {0}", int.MaxValue);

            //3.  use of ternary operator

            //3.a -without ternary operator

            //int Number = 10;

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


            // 3.b -Rewrite the same algo with the ternary operator

            //bool IsNumber10 = Number == 10 ? true : false;
            //Console.WriteLine("Number == 10 is {0}", IsNumber10);

            //4. use of reminder operator

            //int Numerator = 20;
            //int Denominator = 2;

            //int Result = Numerator % Denominator;

            //Console.WriteLine("Result = {0}", Result );


            //5. Nullable value type

            //all value type can have  their nullable type use the use of "?" just like reference type 

            //bool? AreYouMajor = null;

            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("User is Not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the Question");
            //}

            //6. use of switch to replace multiple if else statement

            //Console.WriteLine("Please enter a number");
            //int UserNumber = int.Parse(Console.ReadLine());

            //switch (UserNumber)
            //{
            //    case 10:
            //        Console.WriteLine("Your number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Your number is 20");
            //        break;
            //    case 30:
            //        Console.WriteLine("Yoru number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("Your number is not 10, 20, 30");
            //            break;
            //}

            //7.Null coalescing operator ??

            // 7.a) example without coalescing operator

            //int? TicketsOnSale = 100;

            //int AvailableTickets;

            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;

            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale;
            //}

            //Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

            //7.b) same example with null coalescing operator

            int? TicketsOnSale = 100;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("AvailableTickets = {0}", TicketsOnSale);
        }
            
    }
}
