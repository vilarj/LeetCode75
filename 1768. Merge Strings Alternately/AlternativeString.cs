using System.Text;

/*
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d 
*/
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

        public string MergeAlternately(string word1, string word2)
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
