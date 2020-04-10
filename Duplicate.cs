using System;

namespace Duplicates
{
    class Dups
    {
        static void Main()
        {
            int[] array = { 9, 3, 1, 2, 6, 5, 4, 7, 8, 4, 9 };
            DuplicateValues(array);
        }

        public static void DuplicateValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 1 + i; k< arr.Length; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        Environment.Exit(0);
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
    }
}
