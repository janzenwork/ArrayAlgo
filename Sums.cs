using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
            int[] num = new[] { 1, 2, 3, 6, 7, 9 };
            int target = 5;

            Sums sum = new Sums();
            sum.Sum(num, target);
        }

    }

    public class Sums
    {

        public int[] Sum(int[] num, int target)
        {
            //Check which two numbers in array add up to target
            //Returns array

            for (int i = 0; i < num.Length; i++)
            {
                for (int k = 1 + i; k < num.Length; k++)
                {
                    if (target == num[i] + num[k])
                    {
                        return new int[]{ i, k };
                    }
                }
            }

            //throw exception because all code paths must return a value.
            throw new System.ArgumentException("No two values add up to target.");
        }
    }
}
