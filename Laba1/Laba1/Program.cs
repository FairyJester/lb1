using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите x, модуль которого в диапозоне от -1 до 1");
            double x = Convert.ToDouble(Console.ReadLine());
            while(x <= -1 || x >= 1)
            {
                Console.WriteLine("внимательно читайте условие, введите x еще раз");
                x = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите n больше -1");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("внимательно читайте условие, введите n еще раз");
                n = Convert.ToInt32(Console.ReadLine());
            }
            double result = 0;
            for (int i = 0; i < n+1; i++)
            {
                result += Math.Pow(x, 2*n+1); // / (2 * n + 1);
            }
            Console.WriteLine(result);
            //Console.WriteLine(result * 2);
        }
    }
}
