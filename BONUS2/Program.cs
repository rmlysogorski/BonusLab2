using System;

namespace BONUS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthMonth = 0, birthDay = 0, birthYear = 0, age = 0;
            string input = String.Empty;
            bool check = false;
            DateTime today = DateTime.Now, userBirthday;

            Console.WriteLine("This program will calculate your age.\n");

            do
            {
                Console.Write("Please enter your birth month (MM): ");
                input = Console.ReadLine();
                check = int.TryParse(input, out birthMonth);
                if (!check)
                {
                    Console.WriteLine("Please enter a number between 1-12. ");
                }
                else if (birthMonth < 1 || birthMonth > 12)
                {
                    Console.WriteLine("Please enter a number between 1-12.");
                    check = false;
                }
            } while (check == false);
            check = false;

            do
            {
                Console.Write("Please enter your birth day (DD): ");
                input = Console.ReadLine();
                check = int.TryParse(input, out birthDay);
                if (!check)
                {
                    Console.WriteLine("Please enter a number between 1-31.");
                }
                else if (birthDay < 1 || birthDay > 31)
                {
                    Console.WriteLine("Please enter a number between 1-31.");
                    check = false;
                }                
            } while (check == false);
            check = false;

            do
            {
                Console.Write("Please enter your birth year (YYYY): ");
                input = Console.ReadLine();
                check = int.TryParse(input, out birthYear);
                if (!check)
                {
                    Console.WriteLine("Please enter a year between 0001-" + today.Year.ToString() + ".");
                }
                else if (birthYear < 1 || birthYear > today.Year)
                {
                    Console.WriteLine("Please enter a year between 0001-" + today.Year.ToString() + ".");
                    check = false;
                }

            } while (check == false);
            check = false;
            
            try
            {
                userBirthday = new DateTime(birthYear, birthMonth, birthDay);
                Console.WriteLine("\nYour birthday is " + userBirthday.ToString("d") + ".");

                TimeSpan difference = today.Subtract(userBirthday);
                DateTime ageInDays = DateTime.MinValue + difference;
                if (today.Month == userBirthday.Month && today.Day == userBirthday.Day)
                {
                    Console.WriteLine("Happy Birthday!");
                }
                Console.WriteLine("You are " + (ageInDays.Year - 1) + " years, " 
                    + (ageInDays.Month - 1) +" months, and " + (ageInDays.Day - 1) + " days old.");
            }
            catch
            {
                Console.WriteLine("You did not enter a valid birthday!");
            }
            

        }
    }
}
