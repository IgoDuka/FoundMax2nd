using System;

namespace Test_AKVELON
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 1, 2, 4, 15, 3, 8, 5, 7, 6, 9, 0, 11 };
            int Max2nd = FoundMax2nd(Array);
            
            Console.WriteLine("Max 2-nd: " + Max2nd);
            Console.ReadKey();
        }

        public static int FoundMax2nd(int[] inputArray)
        {
            for(int i = 0; i < 2; i++)
                for(int j = 0; j < inputArray.Length - 1 - i; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        int tmp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = tmp;
                    }
                }
            return inputArray[inputArray.Length - 2];
        }
    }
}
