namespace Task_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создайте метод, который на вход принимает одномерный массив
            // и число для поиска, верните индексискомогоэлемента в массиве.
            // Если элемента нет – верните индекс = -1
            Console.WriteLine("Введите число от 1 до 99 для поиска в массиве:");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[4];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 100);// pаполнение массива случайными числами
            int index = FindIndex(array, x);// поиск элемента
            Console.WriteLine(index);
        }
        /// <summary>
        /// возвращает индекс этого элемента
        /// </summary>
        /// <param name="array">массив целых чисел</param>
        /// <param name="target">целое число</param>
        /// <returns></returns>
        public static int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == target)
                    return i;
            return -1;
            // else элемент не найден

        }
    }
}
