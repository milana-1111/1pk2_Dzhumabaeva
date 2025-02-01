namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Осуществить генерация двумерного[10 * 5] массива по следующему правилу:
            //• 1 столбец содержит нули
            //• 2 столбце содержит числа кратные 2
            //• 3 столбец содержит числа кратные 3
            //• 4 столбец содержит числа кратные 4
            //• 5 столбец содержит числа кратные 5
            //Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив

            // создаем двумерный массив размером 10x5
            int rows = 10;
            int cols = 5;

            // Создание двумерного массива
            int[,] array = new int[rows, cols];

            // Заполнение массива по заданным правилам
            for (int i = 0; i < rows; i++)
            {
                array[i, 0] = 0; // 1 столбец содержит нули
                array[i, 1] = (i + 1) * 2; // 2 столбец содержит числа кратные 2
                array[i, 2] = (i + 1) * 3; // 3 столбец содержит числа кратные 3
                array[i, 3] = (i + 1) * 4; // 4 столбец содержит числа кратные 4
                array[i, 4] = (i + 1) * 5; // 5 столбец содержит числа кратные 5
            }
            // Вывод исходного массива
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Транспонирование массива
            int[,] transposedArray = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedArray[j, i] = array[i, j];
                }
            }
            // Вывод обновленног массива
            Console.WriteLine("\nТранспонированный массив:");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposedArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
