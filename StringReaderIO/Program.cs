using System;

namespace StringReaderIO
{
    class Program : StringManipulations
    {
        static void Main(string[] args)
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
                    Console.WriteLine("Would you like to enter a new string? (y/n)");
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
    }
}


