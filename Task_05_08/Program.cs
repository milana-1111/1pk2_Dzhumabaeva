namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Даны два массива размером 10 * 10, заполненные целыми числами в диапазоне от 1 до 9 вкл.Создать новый массив, который будет
            //произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
            //результирующий массив)
            //Вывести результирующий массив

            // Размер матриц
            int size = 10;
            // Создание и заполнение первых двух массивов случайными числами от 1 до 9
            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix1[i, j] = random.Next(1, 10); // Заполнение первого массива
                    matrix2[i, j] = random.Next(1, 10); // Заполнение второго массива
                }
            }
            // Создание результирующего массива
            int[,] resultMatrix = new int[size, size];

            // Перемножение элементов двух массивов
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            // Вывод результирующего массива
            Console.WriteLine("Результирующий массив (произведение двух матриц):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
