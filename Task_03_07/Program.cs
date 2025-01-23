namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
            //где 2 g = 9,8 м / с2 – ускорение свободного падения.

            const double g = 9.8;
            double p = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.5; i <= p; i = i + 0.5)
            {
                double v = g * i;
                Console.WriteLine(v);
            }
        }
    }
}
