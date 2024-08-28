using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; //declares sum variable

            Console.Write("Enter an integer: "); //displays text asking for user input
            int userInput = Convert.ToInt32(Console.ReadLine()); //converts user input into integer variable userInput

            for (int i = userInput; i > 0; i = i / 10) //for loop where i is created = userInput and where the loop will continue as long as i is greater than 0. Each iteration will be divided by 10
            {
                sum = sum + i % 10; //calculates the sum by adding the remander of i / 10 to the current sum value
            }

            Console.WriteLine("The sum of the digits is: " + sum); //displays the sum of the digits
            Console.ReadLine(); //allows user to read program
        }
    }
}
