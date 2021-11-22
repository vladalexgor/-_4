using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_App2
{
    class Program
    {
        //Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
        //Последовательность потенциально не ограничена, окончанием последовательности служит число 0
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел в любом количестве, в конце последовательности поставьте 0:");
            int positive = 0;
            int negative = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (N > 0)
                {
                    positive++;
                }
                else if (N < 0)
                {
                    negative++;
                }
                N = Convert.ToInt32(Console.ReadLine());
            } while (N != 0);
            if (positive > negative)
            {
                Console.WriteLine("Положительных чисел больше отрицательных.");
            }
            else if (positive < negative)
            {
                Console.WriteLine("Отрицательных чисел больше положительных.");
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных чисел равно.");
            }
            Console.WriteLine("Для завершения программы нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
