namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан квадратный массив размерность n* n. Произведите анализ данной матрицы и выясните является ли данная матрица
            //диагональной(все элементы вне главной диагонали равны нулю)
            //Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
            //сообщение что матрица не является диагональной.

            int n = 3; // Задайте размерность матрицы
            int[,] matrix = new int[n, n];
            // Ввод элементов матрицы
            Console.WriteLine("Введите элементы матрицы (по строкам):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Проверка на диагональность
            bool isDiagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
                if (!isDiagonal) break;
            }
            // Вывод результата
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow; // Выделение главной диагонали
                        }
                        Console.Write(matrix[i, j] + " ");
                        Console.ResetColor(); // Сброс цвета после каждого элемента
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }
    }
}
