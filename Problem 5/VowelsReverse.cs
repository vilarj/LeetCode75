
namespace Problems.Problem_5
{
    public class VowelsReverse
    {
        public VowelsReverse(string s)
        {
            Console.WriteLine("Original String: " + s);
            Console.WriteLine("Reversed Vowels String: " + ReverseVowels(s));
        }

        private static string ReverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            char[] chars = s.ToCharArray();
            int i = 0, k = chars.Length - 1;

            while (i < k)
            {
                if (!IsVowel(chars[i]))
                {
                    i++;
                }
                else if (!IsVowel(chars[k]))
                {
                    k--;
                }
                else
                {
                    (chars[i], chars[k]) = (chars[k], chars[i]);
                    i++;
                    k--;
                }
            }

            return new string(chars);
        }

        private static bool IsVowel(char c)
        {
            return 
                c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || 
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}