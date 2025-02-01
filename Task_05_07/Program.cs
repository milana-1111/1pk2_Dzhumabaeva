namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе[n * n].Заполнение случайными
            // числами в диапазоне от 10 до 99 включительно.
            //Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
            //минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве

            // Запрос у пользователя размера массива
            Console.Write("Введите размер n для квадратной матрицы n*n: ");
            int n = int.Parse(Console.ReadLine());
            // Создание квадратного массива
            int[,] matrix = new int[n, n];
            Random random = new Random();
            // Заполнение массива случайными числами от 10 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }
            // Поиск минимального элемента в матрице
            int minElement = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в матрице: {minElement}");

            // Умножение матрицы на минимальный элемент
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] *= minElement;
                }
            }
            // Поиск пяти максимальных значений
            int[] maxValues = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < maxValues.Length; k++)
                    {
                        if (matrix[i, j] > maxValues[k])
                        {
                            // Сдвиг значений в массиве maxValues
                            for (int l = maxValues.Length - 1; l > k; l--)
                            {
                                maxValues[l] = maxValues[l - 1];
                            }
                            maxValues[k] = matrix[i, j];
                            break;
                        }
                    }
                }
            }
            // Вывод матрицы с выделением 5ти максимальных значений
            Console.WriteLine("\nРезультирующая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isMaxValue = false;
                    for (int k = 0; k < maxValues.Length; k++)
                    {
                        if (matrix[i, j] == maxValues[k])
                        {
                            isMaxValue = true;
                            break;
                        }
                    }
                    // Выделение цветом максимальных значений
                    if (isMaxValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
