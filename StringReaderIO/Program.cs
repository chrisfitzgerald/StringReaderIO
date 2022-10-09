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

            do //Keep App Active
            {
                
                do //Take Input String
                {
                    Console.WriteLine("Please enter string to trim:");
                    myString = Console.ReadLine();
                    if (myString == "") Console.WriteLine("No text entered. Try Again. [0]");
                } while (myString == "");
                
                //Actions
                Console.WriteLine($"Un-trimmed string is:\n{myString}\n");
                Console.WriteLine($"Trimmed String:\n{stringTrim(myString)}\n");
                Console.WriteLine($"Total Character Count:\n{countChars(myString)}\n");
                Console.WriteLine($"White Spaces Trimmed:\n{countWhiteSpaces(myString)}\n");
                Console.WriteLine($"Reverse it:\n{reverseIt(stringTrim(myString))}\n");
                Console.WriteLine($"Reversed white trimmed:\n{countWhiteSpaces(reverseIt(myString))}\n");
                Console.WriteLine($"Is Palindrom? {pallindrome(stringTrim(myString))}\n");

                do //Rerun Prompt
                {
                    Console.WriteLine("would you like to enter a new string? (y/n)");
                    string ans2 = Console.ReadLine();
                    if (ans2.ToLower() == "y") break;
                    if (ans2.ToLower() == "n")
                    {
                        rerun = false; active = false;
                    }
                    else 
                    { 
                        Console.WriteLine("Not a valid answer. Try again. [1]"); 
                    }

                } while (rerun == true);

            } while (active == true);
                

        }

        //String Manipulations
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

    }
}


