namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан квадратный массив размерность n* n. Произведите анализ данной матрицы и выясните является ли данная матрица Z - матрицей
            //  (это матрица, где все недиагональные элементы меньше нуля)
            //Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то
            //вывести сообщение что данная матрица не является Z - матрицей

            // Размерность матрицы
            Console.Write("Введите размерность матрицы n: ");
            int n = int.Parse(Console.ReadLine());
            // Создание и заполнение матрицы
            int[,] matr = new int[n, n];
            Random random = new Random();
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = random.Next(-10, 10); // Заполнение случайными числами от -10 до 9
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Проверка на Z--матрицу
            bool isZMatrix = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matr[i, j] >= 0) // Проверка недиагональных элементов
                    {
                        isZMatrix = false;
                        break;
                    }
                }
                if (!isZMatrix) break;
            }
            // Вывод результата
            if (isZMatrix)
            {
                Console.WriteLine("\nДанная матрица является Z-матрицей. Вывод с цветовой индикацией главной диагонали:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // Цвет для главной диагонали
                            Console.Write(matr[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matr[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nДанная матрица не является Z-матрицей.");
            }
        }
    }
}
