using System;

namespace TestRensyu
{
    public class Program
    {
        /// 以下をコピペ。冒頭に
        /// 
        /// using System;
        /// 
        /// が必要
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine().Trim());

            for (int i = 1; i <= num; i++)
            {
                 if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("" + i);
                }
            }
        }

    }
}
