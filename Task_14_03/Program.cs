namespace Task_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.
            //Сделайтетак, чтобы метод работал только для неотрицательных чисел.

            Console.WriteLine("Введите неотрицательное целое число:");
            if (long.TryParse(Console.ReadLine(), out long n) && n >= 0)
            {
                Console.WriteLine($"Факториал числа {n} = {Factorial(n)}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Факториал определен только для неотрицательных чисел.");
            }
        }
        /// <summary>
        /// Вычисление факториала числа.
        /// </summary>
        /// <param name="x>Число, для которого считается факториал.</param>
        /// <returns>Факториал числа.</returns>
        static long Factorial(long x)
        {
            long factorial = 1;
            for (long i = 2; i <=x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}