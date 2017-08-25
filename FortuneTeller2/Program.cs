using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting-Intro
            Console.WriteLine("Welcome to \"Madame Pearson's Amazing Fortune Teller!\"");
            Console.WriteLine("You've come to the right place if you are yearning to know your fate.");
            Console.WriteLine("Prepare to be completely astonished by her highly accurate predictions.");
            Console.WriteLine(" ");
            Console.WriteLine("The Fine Print: Do not take her predictions to heart as YOU ultimately hold the key to your future.");
            Console.WriteLine(" ");

            //Stretch Task - NO FUNCTION YET
            Console.WriteLine("If at any time you are too afraid to know your future, simply type: Quit.");
            Console.WriteLine(" ");

            //User input (C.WriteLine & C.ReadLine)
            Console.WriteLine("Let's get started!");
            Console.WriteLine(" ");
            Console.WriteLine("Please answer the following questions:");

            //Name
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");

            //Age=Retirement
            Console.WriteLine("What is your age?");
            Console.WriteLine("(Don't worry, we won't tell)");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            //1st: declare a variable for years until retirement
            int yearsUntilretirement;

            //2nd: calculating if the number is odd
            if (age % 2 > 0)
            {
                yearsUntilretirement = 2; //3rd: assigning the value to the variable years until retirement - odd
            }
            else
            {
                yearsUntilretirement = 22; //Then: if number is even
            }


            //Birth Month=Money in Bank
            Console.WriteLine("Please type the month number in which you were born? i.e. September, type: 9");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double amtMoney;

            if (birthMonth == 1)
            {
                amtMoney =
            }




            //Siblings=Vacation Home Location
            Console.WriteLine("How many siblings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            string vacationLocation;

            if (numberSiblings == 0)
            {
                vacationLocation = "Aruba";
            }
            else if (numberSiblings == 1)
            {
                vacationLocation = "Paris";
            }
            else if (numberSiblings == 2)
            {
                vacationLocation = "Iowa";
            }
            else if (numberSiblings == 3)
            {
                vacationLocation = "Cleveland, Ohio";
            }
            else if (numberSiblings < 0)
            {
                vacationLocation = "in a landfill";
            }
            else
            {
                vacationLocation = "at a campsite";
            }


            //Color=Transportation with Help section
            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //Console.WriteLine("**Unsure of what ROYGBIV means? For more info, type: Help");
            //string color = Console.ReadLine();
            //Console.WriteLine(" ");

            //Printing Fortune
            Console.WriteLine("According to Madame Pearson, here is what she sees:");
            Console.WriteLine(" ");
            Console.WriteLine(firstName + lastName + " will retire in " + yearsUntilretirement + " years, with");
            Console.WriteLine(" ");
            Console.WriteLine(vacationLocation);
            Console.WriteLine(" ");

            //Console.WriteLine($"{firstName} {lastName}, you will retire in {retireYears}. You will own a {vehicles}
            // and live in {vacationSpot}. You will own {dollars}");
            //Ending
            //Console.WriteLine("We hope you had fun learning what the future has in store for you!!");
        }
    }
}
