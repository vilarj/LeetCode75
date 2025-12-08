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
