
namespace Problems.Problem_8
{
    public class IncreasingTriplets
    {
        public IncreasingTriplets(int[] n)
        {
            Console.WriteLine(Triplets(n));
        }
        private static bool Triplets(int[] nums)
        {
            int first = int.MaxValue, second = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= first) first = num; // Update first
                else if (num <= second) second = num; // Update second
                else return true; // num > first && num > second
            }
            return false;
        }
    }
}
