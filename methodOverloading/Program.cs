
using System;

namespace methodOverloading
{
    internal class Program
    {

        //Create a new Console app in Visual Studio Community.
        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        //Now create an overload of the Add method to account for being able to add two decimals together
        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

        public static int Add (int x, int y)
        { 
         return x + y;
        }
        public static decimal Add (decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add (int x, int y, bool z)
        {
            var sum = 0;
            var response = "";

            if (z==true)
            {
                sum= x + y;
                if (sum == 1)
                {
                    response+=($"{sum} dollar.");
                }
                else
                {
                   response+=($"{sum} dollars.");
                }
                
            }
           return response;
        }


        static void Main(string[] args)
        {
           var answer1= Add(1,2,true);
           var answer2=Add(0, 1, true);
            var answer3=Add(-1, 2, true);
            var answer4=Add(1.2m, 3.2m);
            var answer5 = Add(1, 3);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
        }
    }
}
