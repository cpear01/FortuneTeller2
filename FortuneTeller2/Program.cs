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
            //Fortune Teller purpose: Develop a console application that will tell the user’s fortune based on data received from the user.
            //Greeting-Intro - DONE
            Console.WriteLine("Welcome to \"Madame Pearson's Amazing Fortune Teller!\"");
            Console.WriteLine("You've come to the right place if you are yearning to know your fate.");
            Console.WriteLine("Prepare to be completely astonished by her highly accurate predictions.");
            Console.WriteLine(" ");

            //Stretch Task - only works for right now, not throughout the program
            //Console.WriteLine("If at any time you are too afraid to know your future, simply type: Quit.");
            //Console.WriteLine(" ");
            //string userQuit = Console.ReadLine().ToLower();
            //if (userQuit == "quit")
            //{
            //    Console.WriteLine("Nobody like a quitter...");
            //    Environment.Exit(0);
            //}

            //User Name input - DONE
            Console.WriteLine("Let's get started!");
            Console.WriteLine(" ");
            Console.WriteLine("Please answer the following questions:");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");

            //User Age= Years til Retirement - DONE
            //1)Ask for user age 2) Determine if age input is even or odd  3)assign '# of years til retirement' values for odd or even answers
            Console.WriteLine("What is your age?");
            Console.WriteLine("(Don't worry, we won't tell)");
            int age = int.Parse(Console.ReadLine()); //convert user input age to an integer
            Console.WriteLine(" ");

            //1st: declare a variable for years until retirement, will be assigned in if statement according to if # is odd or even
            int yearsUntilretirement;
            
            //2nd: starting if statement
            if(age % 2 > 0)  //this condition is determining if age input is odd
            {
                yearsUntilretirement = 2; //3rd: If statement: if number input is odd, assigning the value:2 to the variable:yearsUntilretirement 
            }
            else
            {
                yearsUntilretirement = 22; //4th: Then statement: if number input is even, assigning the value:22
            }


            //Birth Month=Money in Bank - DONE
            //1)Ask for user birth month (by month#) 2)assign 'amount in bank' according to birth months: 1-4, 5-8, 9-12, & anything else input=0
            Console.WriteLine("Please type the month number in which you were born? i.e. September, type: 9");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double amtMoney;

            if(birthMonth >= 1 && birthMonth <= 4)
            {
                amtMoney = 5000;
            }
            else if(birthMonth >= 5 && birthMonth <= 8)
            {
                amtMoney = 100;
            }
            else if(birthMonth >= 9 && birthMonth <= 12)
            {
                amtMoney = 20000;
            }
            else
            {
                amtMoney = 0;
            }

            
            //Siblings=Vacation Home Location - DONE
            //1)Ask how many siblings  2)assign vacation location based sibling #: 0,1,2,3,less than 0=bad location, more than 3
            Console.WriteLine("How many siblings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            string vacationLocation = "";

            if (numberSiblings == 0)
            {
                vacationLocation = "Aruba";
            }
            else if (numberSiblings == 1)
            {
                vacationLocation = "Cleveland";
            }
            else if (numberSiblings == 2)
            {
                vacationLocation = "Hawaii";
            }
            else if (numberSiblings == 3)
            {
                vacationLocation = "Hawaii";
            }
            else if (numberSiblings < 0)
            {
                vacationLocation = "a landfill";
            }
            else   ////if any number input other than: less than 0, 1, 2, 3
            {
                vacationLocation = "Kazakhstan";
            }


            //Color=Transportation with Help section - DONE   
            //Console.ReadLine().ToLower();  to make case insensitive
            //Help section in a separate If statement and goes before the colors
            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation (i.e. car, boat, plane, etc.)
            //1)Ask user for fav color & offer Help section  2) assign transportation based on ROYGBIV color or if something else typed
            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("**Unsure of what ROYGBIV means? For more info type: Help.");
            string color = Console.ReadLine().ToLower();
            Console.WriteLine(" ");

            string transportMode = "";

            //Help if/then section
            if(color == "help")
            {
                Console.WriteLine("ROYGBIV Colors: R=red, O=orange, Y=yellow, G=green, B=blue, I=indigo, V=violet");
                Console.WriteLine("Please type your favorite color.");
                color = Console.ReadLine();
                Console.WriteLine(" ");
            }

            //Color if/then section
            if(color == "red")
            {
                transportMode = "scooter";
            }
            else if(color == "orange")
            {
                transportMode = "pogo stick";
            }
            else if(color == "yellow") 
            {
                transportMode = "city bus";
            }
            else if(color == "green")
            {
                transportMode = "Mercedes";
            }
            else if(color == "blue")
            {
                transportMode = "bicycle";
            }
            else if(color == "indigo")
            {
                transportMode = "Pinto";
            }
            else if(color == "violet")
            {
                transportMode = "Lexus";
            }
            else ////if anything else is typed
            {
                Console.WriteLine("This is not a valid color. Please type your favorite color.");
                Console.ReadLine();
            }

            //Printing Fortune 
            //Use if statement variable names: yearsUntilretirement, amtMoney, vacationLocation, transportMode
            //[First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] 
            //and a [Mode of Transportation].
            
            //Testing variables:
            //Console.WriteLine(yearsUntilretirement);
            //Console.WriteLine(amtMoney);
            //Console.WriteLine(vacationLocation);
            //Console.WriteLine(transportMode);

            Console.WriteLine("According to Madame Pearson, here is what she sees:");
            Console.WriteLine(" ");
            //Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilretirement + " years, with $" + amtMoney + " in the bank, ");
            //Console.WriteLine("a vacation home in " + vacationLocation + " and have a " + transportMode + " for getting around."); 

            //Using string.Concat
            Console.WriteLine(string.Concat(firstName, " ", lastName, " will retire in ", yearsUntilretirement, " years with $", amtMoney, " in the bank, "));
            Console.WriteLine(string.Concat("a vacation home in ", vacationLocation, " and have a ", transportMode, " for getting around."));
            Console.WriteLine(" ");
            
            //Ending - DONE
            Console.WriteLine("Hope you had fun learning what the future has in store for you!!");
            Console.WriteLine(" ");
            Console.WriteLine("The Fine Print: Do not take her predictions to heart as YOU ultimately hold the key to your future.");
            Console.WriteLine(" ");
        }
    }
}
