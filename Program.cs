using System;

namespace ReverseArray
{
    class Program
    {
        public static void Main()
        {
            char[] phrase = new char[] { 'h','e','l','l','o' };

            for (int i = phrase.Length - 1; i >= phrase.Length / 2; i--)
            {
                char temp = phrase[i];
                phrase[i] = phrase[phrase.Length - 1 - i];
                phrase[phrase.Length - 1 - i] = temp;
            }
            Console.Write(phrase);
        }
    }
}
