namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an array");

            int tabLength = int.Parse(Console.ReadLine());

            int[] array = new int[tabLength];

            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine("Enter value into table: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array sorted in ASC order: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
