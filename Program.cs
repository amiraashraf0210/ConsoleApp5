using System;

namespace first_project
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an array (comma-separated values):");
            string input = Console.ReadLine();
            var number = input.Split(new[] { ", " }, StringSplitOptions.None);
            int[] arr = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                int result = 1;
                for (int j = 0; j < number.Length; j++)
                {
                    if (i != j)
                    {
                        result = result * int.Parse(number[j]);
                    }
                }
                arr[i] = result;
            }
            for (int a = 0; a < number.Length; a++)
            {
                Console.Write(arr[a] + " ");
            }
            Console.ReadLine();
        }
    }
}