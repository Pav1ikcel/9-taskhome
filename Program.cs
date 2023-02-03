/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

namespace NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N:");
            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n);
        }

        static void PrintNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNumbers(n - 1);
        }
    }
}
*/
/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

using System;

namespace NaturalNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for M and N:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int sum = SumOfNumbers(m, n);

            Console.WriteLine("The sum of natural numbers between " + m + " and " + n + " is " + sum);
        }

        static int SumOfNumbers(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
*/
/*   
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29


using System;


namespace AckermannFunction
{
    class Program
    {
        static int Ackermann(int m, int n)
        {
            while (m != 0)
            {
                if (n == 0)
                {
                    n = 1;
                }
                else
                {
                    n = Ackermann(m, n - 1);
                }
                m--;
            }
            return n + 1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(Ackermann(m, n));
        }
    }
}
*/
