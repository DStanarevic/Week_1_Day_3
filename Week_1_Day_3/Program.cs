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


            //Console.WriteLine("Please enter the day of the week.");
            //string day = Console.ReadLine();
            //if (day == "Monday")
            //{
            //    Console.WriteLine("That sucks bruh.");
            //}
            //else if (day == "Friday")
            //{
            //    Console.WriteLine("Partiezeit!");
            //}
            //else
            //{
            //    Console.WriteLine("Weekend!");
            //}


            //If is used to account for a range, switch is used if mulitple scenarios have same outcome.
            //Console.WriteLine("How old are you ?");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge >= 0 && userAge <=1)
            //{
            //    Console.WriteLine("Just a baby.");
            //}

            //else if(userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}

            //else if(userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childgood.");
            //}

            //else if(userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}
            //else if(userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement.");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age.");
            //}

            //Switch statements.
            //Ctrl + K + D organizes the 
            Console.WriteLine("How many points did you earn ?");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned) // Selector for the variable, you have to enter the variable name that you are checking.
            {
                case 0: //Ends with a : symbol.
                    Console.WriteLine("You loose.");
                    break; // Always have to break at the end of the case.
                case 1:
                    Console.WriteLine("Needs practice.");
                    break;
                case 2:
                    Console.WriteLine("On target.");
                    break;
                case 3:
                    Console.WriteLine("Superstar.");
                    break;
                case 4:
                    Console.WriteLine("Overachiever.");
                    break;
                case 5:
                    Console.WriteLine("You cheated.");
                    break;
                default: //Anything else that might come up.
                    Console.WriteLine("Invalid score entered.");
                    break;



            }

        }
    }
}
