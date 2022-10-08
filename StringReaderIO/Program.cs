using System;
using System.Linq;
using System.Net.Mail;

namespace StringReader
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool active = true;
            bool rerun = true;
            string myString;
            do
            {

                do
                {
                    //Take Input String
                    Console.WriteLine("Please enter string to trim:");
                    myString = Console.ReadLine();
                    if (myString == "") Console.WriteLine("no text entered");
                } while (myString == "");
                //Actions
                Console.WriteLine($"Un-trimmed string is:\n{myString}\n");
                Console.WriteLine($"Trimmed String:\n{stringTrim(myString)}\n");
                Console.WriteLine($"Total Character Count:\n{countChars(myString)}\n");
                Console.WriteLine($"White Spaces Trimmed:\n{countWhiteSpaces(myString)}\n");
                Console.WriteLine($"Reverse it:\n{reverseIt(stringTrim(myString))}\n");
                Console.WriteLine($"Reversed white trimmed:\n{countWhiteSpaces(reverseIt(myString))}\n");
                Console.WriteLine($"Is Palindrom? {pallindrome(stringTrim(myString))}");
                //Console.WriteLine($"Is Email? {isEmail(myString)}");
                do
                {
                    Console.WriteLine("would you like to enter a new string? (y/n)");
                    string ans2 = Console.ReadLine();
                    if (ans2.ToLower() == "y") rerun = true;
                    else if (ans2.ToLower() == "n") rerun = false;
                    else { Console.WriteLine("not a valid answer"); }
                } while (rerun == true);
            } while (active == true);

        }
        static string stringTrim(string s)
        {
            string trimmedString = s.TrimStart();
            return trimmedString;
        }

        static int countWhiteSpaces(string s)
        {
            int count = s.TakeWhile(Char.IsWhiteSpace).Count();
            return count;
        }

        static int countChars(string s)
        {
            int count = s.Count();
            return count;
        }

        static string reverseIt(string s)
        {
            char[] myArray = s.ToCharArray();
            Array.Reverse(myArray);
            return new string(myArray);
        }

        static bool pallindrome(string s)
        {
            string orig = s;
            string reversed = new string(orig.Reverse().ToArray());
            return orig == reversed;

        }

        //static bool isEmail(string s)
        //{
        //    try
        //    {
        //        MailAddress m = new MailAddress(s);
        //        return true;
        //    }
        //    catch (FormatException)
        //    {
        //        return false;
        //    }
        //}

    }
}


