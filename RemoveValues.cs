using System;

namespace RemoveElements
{
    class Elements
    {
        static void Main()
        {

            int[] nums = { 3, 2, 2, 4,3,3,4,5,6,10,8,9 };
            int val = 3;
            remove(nums, val);

        }

        public static void remove(int[] nums, int val)
        {

            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[temp] = nums[i];
                    temp++;
                }
            }
            Console.Write(temp);
        }
    }
}
