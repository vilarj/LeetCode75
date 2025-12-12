/*
For two strings s and t, we say "t divides s" if and only if 
s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"

Output: "ABC"

Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"

Output: "AB"

Example 3:

Input: str1 = "LEET", str2 = "CODE"

Output: ""

Example 4:

Input: str1 = "AAAAAB", str2 = "AAA"

Output: ""
*/

namespace Problems.Greatest_Common_Divisor_of_Strings
{
    public class CommonDivisor
    {
        public CommonDivisor(string str1, string str2)
        {
            Console.WriteLine("String 1: " + str1);
            Console.WriteLine("String 2: " + str2);
            Console.WriteLine("GCD of Strings: " + GcdOfStrings(str1, str2));
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";
            int gcdLength = GCD(str1.Length, str2.Length);
            return str1.Substring(0, gcdLength);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
