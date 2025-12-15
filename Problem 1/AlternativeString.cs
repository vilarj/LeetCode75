using System.Text;

namespace Problems._1768._Merge_Strings_Alternately
{
    public class AlternativeString
    {
        public AlternativeString (string w1, string w2)
        {
            Console.WriteLine("Word 1: " + w1);
            Console.WriteLine("Word 2: " + w2);
            Console.WriteLine("Merged: " + MergeAlternately(w1, w2));
        }

        private static string MergeAlternately(string word1, string word2)
        {
            var output = new StringBuilder();
            int i = 0, j = 0, w1Length = word1.Length, w2Length = word2.Length;

            while (i < w1Length || j < w2Length)
            {
                if (i < w1Length)
                    output.Append(word1[i++]);
                if (j < w2Length)
                    output.Append(word2[j++]);
            }

            return output.ToString();
        }
    }
}
