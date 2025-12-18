
namespace Problems.Problem_7
{
    public class ProductOfArray
    {
        public ProductOfArray(int[] nums)
        {
            Console.WriteLine(ProductExceptSelf(nums));
        }
        private static int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return nums;
            if (nums.Length == 1) return [1];

            int len = nums.Length;
            int[] answer = new int[len];
            int leftProduct = 1;
            int rightProduct = 1;

            for (int i = 0; i < len; i++)
            {
                answer[i] = leftProduct;
                leftProduct *= nums[i];
            }

            for (int i = len - 1; i >= 0; i--)
            {
                answer[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return answer;
        }

    }
}
