using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Conditinonal statements. It's a way for a computer to handle multiple scenarios.
            //int firstNumber = 2;
            //int secondNumber = 6;

            ////If else statement.
            //if (firstNumber > secondNumber)
            //{
            //    //Do something
            //    Console.WriteLine("You have broken math. Good Job");

            //}
            //else
            //{
            //    //
            //    Console.WriteLine("That makes sense.");
            //}

            
            Console.WriteLine("Please enter the day of the week.");
            string day = Console.ReadLine();
            if (day == "Monday")
            {
                Console.WriteLine("That sucks bruh.");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("Partiezeit!");
            }
            else
            {
                Console.WriteLine("Weekend!");
            }


        }
    }
}
