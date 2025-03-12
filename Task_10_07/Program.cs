namespace Task_10_07
{
    internal class Program
    {
        static void Main()
        {
            // Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив
            // (состоящийиз символов русского алфавита) и выведите на консоль данный массив
            // с помощью другого метода(которыйпринимает данный массив в качестве параметра)
            char[,] array = Generate();
            Print(array);
        }
        /// <summary>
        /// создаёт и возвращает массив без передачи
        /// </summary>
        /// <returns>енерация случайных символов русского алфавита</returns>
        static char[,] Generate()
        {
            char[,] array = new char[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = (char)rnd.Next(1040, 1104);

            return array;
        }
        /// <summary>
        /// массив создаётся и заполняется
        /// </summary>
        /// <param name="array">размер массива</param>
        static void Print(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }
        }

    }
}
