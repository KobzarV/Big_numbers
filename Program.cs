using System;

namespace Big_numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть число: ");
            string num = Console.ReadLine();
            string[] numbers = {
                " 000 \n0   0\n0   0\n0   0\n0   0\n0   0\n 000 ",
                "  1  \n 11  \n  1  \n  1  \n  1  \n  1  \n11111",
                " 222 \n2   2\n   2 \n  2  \n 2   \n2    \n22222",
                " 333 \n3   3\n    3\n 333 \n    3\n3   3\n 333 ",
                "4   4\n4   4\n4   4\n44444\n    4\n    4\n    4",
                " 5555\n5    \n5 55 \n5   5\n    5\n5  5 \n 55  ",
                "66666\n6    \n66666\n6   6\n6   6\n6   6\n66666",
                "77777\n    7\n   7 \n  7  \n 7   \n7    \n7    ",
                " 888 \n8   8\n8   8\n 888 \n8   8\n8   8\n 888 ",
                " 999 \n9   9\n9   9\n 9999\n    9\n    9\n 999 "
            };
            foreach (char numb in num)
            {
                if (int.TryParse(numb.ToString(), out int number))
                {
                    Console.WriteLine(numbers[Convert.ToInt32(numb.ToString())]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Введено некоректне число");
                }
            }

            Console.ReadLine();
        }
    }
}
