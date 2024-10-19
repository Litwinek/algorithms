using System;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in length of array:");
            int tabLength = int.Parse(Console.ReadLine());
            int[] array = new int[tabLength];

            for (int i = 0; i < tabLength; i++)
            {
                Console.Write("Enter value into table: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int highest_value = array[0];
            int lowest_value = array[0];
            Console.WriteLine("Entered values:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
                if (item > highest_value)
                {
                    highest_value = item;
                }
                else if (item < lowest_value) 
                {
                    lowest_value = item;
                }
            }
            Console.WriteLine($"\nMin Value: {lowest_value}");
            Console.WriteLine($"\nMax Value: {highest_value}");
        }
    }
}