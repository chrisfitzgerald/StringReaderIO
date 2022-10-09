using System;
using System.Linq;

namespace StringReaderIO
{
    public class StringManipulations
    {
            //String Manipulations
            public static string stringTrim(string s)
            {
                string trimmedString = s.TrimStart();
                return trimmedString;
            }

            public static int countWhiteSpaces(string s)
            {
                int count = s.TakeWhile(Char.IsWhiteSpace).Count();
                return count;
            }

            public static int countChars(string s)
            {
                int count = s.Count();
                return count;
            }

            public static string reverseIt(string s)
            {
                char[] myArray = s.ToCharArray();
                Array.Reverse(myArray);
                return new string(myArray);
            }

            public static bool pallindrome(string s)
            {
                string orig = s;
                string reversed = new string(orig.Reverse().ToArray());
                return orig == reversed;
            }
        
    }
}
