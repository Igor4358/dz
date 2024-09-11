using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала:"); 
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = CalculateFactorial(number); 
            Console.WriteLine($"Факториал числа {number} равен {factorial}");
        }
        static long CalculateFactorial(int n) 
        {
            if (n == 0)
            {
                return 1;
            } 
            long result = 1;
            for (int i = 1; i <= n; i++) 
            {
                result *= i;
            } 
            return result;
        }
    }
}

