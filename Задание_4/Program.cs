using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        //Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1).
        //После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите целое число N > 0.");
            int N = Convert.ToInt32(Console.ReadLine());
            //Sum - текущее значение суммы.
            int Sum = 0;
            int i;
            for (i = 1; (i <= N); i++)
            {
                Sum = Sum + (2 * i - 1);
                Console.WriteLine("Текущее значение суммы: Sum = {0}", Sum);
            }
            Console.WriteLine("Квадрат числа N = {0}", Sum);
            Console.WriteLine("Для завершения программы нажмите любую кнопку на клавиатуре");
            Console.ReadKey();
        }
    }
}
