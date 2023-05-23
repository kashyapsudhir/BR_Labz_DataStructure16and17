using System;
namespace DataStructureAloorithm
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int[] array = { 92, 15, 22, 90, 11,34 };
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in array)
                Console.Write(p + " ");
            Console.Read();
        }
    
    }
}