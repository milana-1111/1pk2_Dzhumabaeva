namespace Task_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать Метод ArrayGeneration не возвращающий значения,
            //принимает целое число n, выводит наконсольсгенерированный массив размерности n*n

            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            ArrayGeneration(n); // dызов метода для генерации и вывода массива
        }
        /// <summary>
        /// производит генерацию и вывод на консоль массива 
        /// </summary>
        /// <param name="n">размер массива</param>
        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
