using System;
namespace DataStructureAloorithm
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello Data Structure Algorithm Program");

            {
                string str = "SUDHIR";
                char[] MyCharArray = str.ToCharArray();
                Permute(MyCharArray, 0, 2);
            }

            static void Permute(char[] arry, int i, int n)
            {
                int j;
                if (i == n)
                    Console.WriteLine(arry);
                else
                {
                    for (j = i; j <= n; j++)
                    {
                        Swap(ref arry[i], ref arry[j]);
                        Permute(arry, i + 1, n);
                        Swap(ref arry[i], ref arry[j]); //backtrack
                    }
                }
            }

            static void Swap(ref char a, ref char b)
            {
                char tmp;
                tmp = a;
                a = b;
                b = tmp;
            }
        }
    }
}