using System;

namespace ArrayDesc
{
    class Descending
    {
        static void Main()
        {
            int[] array = { 9, 3, 1, 2, 6, 5, 4, 7, 8, 4, 9 };
            Desc(array);
        }

        //Takes an int[] and prints it in descending order
        public static void Desc(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = 1 + i; k< arr.Length; k++)
                {
                    if (arr[k] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
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
