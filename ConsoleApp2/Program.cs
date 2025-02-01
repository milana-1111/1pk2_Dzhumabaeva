namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ошибка, введите снова");
            }
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("ошибка, введите снова");
            }
            //создаем прямоугольный двумерный массив 
            int[,] pr = new int[n, m];
            Random rnd = new Random();
            //проверяем массив 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pr[i, j] = rnd.Next(-99, 100);
                    if (pr[i, j] < 0)
                    {
                        pr[i, j] = Math.Abs(pr[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(pr[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (pr[i, j] == 0)
                    {
                        pr[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(pr[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(pr[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
