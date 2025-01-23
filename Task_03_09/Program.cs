namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
            //отбрасывается.Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
            //менее y рублей.
            double x = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            int s = 0;
            while (x <= y)
            {
                x = x + (x / 100 * p);
                x = Math.Truncate(x);
                s = s + 1;

            }
            Console.WriteLine(s);
        }
    }
}
