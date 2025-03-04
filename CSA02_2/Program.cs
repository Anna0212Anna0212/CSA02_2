
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA02_2
{
    class Program
    {
        public static int max_number;
        public static int min_number = 1;
        public static bool tru_fal = true;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("輸入數字數量：");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    tru_fal = false;
                    int[] numbers = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("輸入第" + (i + 1) + "個數字：");
                        if (int.TryParse(Console.ReadLine(), out int number) && number <= 100 && number > 0)
                        {
                            numbers[i] = number;
                        }
                        else
                        {
                            Console.WriteLine("輸入錯誤，請重新輸入");
                            i--;
                        }
                    }
                    Array.Sort(numbers);
                    for (int i = numbers[0]; i > 0; i--)
                    {
                        int k = 0;
                        for (int j = n - 1; j >= 0; j--)
                        {
                            if (numbers[j] % i == 0)
                            {
                                k++;
                            }
                        }
                        if (k == n)
                        {
                            max_number = i;
                            break;
                        }
                    }
                    for (int k = n - 1; k >= 0; k--)
                    {
                        Console.Write($"\n{numbers[k]}的因數有：");
                        for (int i = 1; i <= numbers[k]; i++)
                        {
                            if (numbers[k] % i == 0)
                            {
                                if (i == max_number)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                                Console.Write(i + " ");
                                Console.ResetColor();
                            }
                        }
                    }
                    Console.WriteLine($"\n\n最大公因數為：{max_number}");
                    for (int i = n - 1; i >= 0; i--)
                    {
                        min_number *= numbers[i] / max_number;
                    }
                    min_number *= max_number;
                    Console.WriteLine($"最小公倍數為：{min_number}");
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                    tru_fal = true;
                }
            }
            while (tru_fal);
        }
    }
}
