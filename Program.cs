using System;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regular Expressions

            //Asking for name
            Console.Write("Please enter a valid name: ");
            //regular experssion for name
            string name = Console.ReadLine();
            string namePattern = @"^[A-Z]{1}[a-z]{1,29}$";
            //Calling GetMatch Method
            Console.WriteLine(GetMatch(name, namePattern));

            //asking for email
            Console.Write("Please enter a valid email: ");
            //regular expression for email
            string email = Console.ReadLine();
            string emailPattern = @"^[A-Za-z0-9]{5,30}@{1}[A-Za-z0-9]{5,10}\.{1}[A-Za-z]{2,3}$";
            //Calling GetMatch Method
            Console.WriteLine(GetMatch(email, emailPattern));

            //Phone Number
            Console.Write("Please enter a phone number: ");
            //regular expression for phone number
            string phone = Console.ReadLine();
            string phonePattern = @"^[0-9]{3}\-[0-9]{3}\-[0-9]{4}$";
            //Calling GetMatch Method
            Console.WriteLine(GetMatch(phone, phonePattern));

            //Date
            Console.Write("Please enter a date: day/month/year: ");
            //regular expression for date
            string date = Console.ReadLine();
            string datePattern = @"^([0-2]{1}[0-9]{1}|[3]{1}[0-1]{1})\/([0]{1}[1-9]{1}|[10-12]{2})\/[0-9]{4}$";
            //Calling GetMatch Method
            Console.WriteLine(GetMatch(date, datePattern));

        }
        public static string GetMatch(string input, string pattern)
        {
            Match getMatch = Regex.Match(input, pattern);
            if(getMatch.Success)
            {
                string output = $"{input} is valid";
                return output;
            }
            else
            {
                string output = "input is NOT valid";
                return output;
            }
            
        }
    }
}
