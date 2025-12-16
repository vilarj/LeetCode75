using System.Text;

namespace Problems.Problem_6
{
    public class ReverseWords
    {

        public ReverseWords(string s)
        {
            Console.WriteLine($"Less Efficient Approach: ${ReverseWordsInString(s)}");
            Console.WriteLine($"More Efficient Approach: ${ReverseWordsInStringAsSpan(s)}");
        }

        public static string ReverseWordsInString(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";

            int i = s.Length - 1;
            StringBuilder result = new();

            while (i >= 0)
            {
                while (i >= 0 && s[i] == ' ') i--;

                if (i < 0) break;

                int end = i;

                while (i >= 0 && s[i] != ' ') i--;

                int start = i + 1;

                if (result.Length > 0)
                    result.Append(' ');

                result.Append(s.AsSpan(start, end - start + 1));
            }

            return result.ToString();
        }

        private static string ReverseWordsInStringAsSpan(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";

            int i = s.Length - 1;
            StringBuilder result = new();

            while (i >= 0)
            {
                while (i >= 0 && s[i] == ' ') i--;

                if (i < 0) break;

                int end = i;

                while (i >= 0 && s[i] != ' ') i--;

                int start = i + 1;

                if (result.Length > 0)
                    result.Append(' ');

                result.Append(s.Substring(start, end - start + 1));
            }

            return result.ToString();
        }
    }
}
