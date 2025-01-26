namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
            //которых равны.
            Random random = new Random(); /*Генерируем массив из 50 случайных чисел */
            int[] thay = new int[50];
            for (int i = 0; i < thay.Length; i++)
            {
                thay[i] = random.Next(1, 101); /*случайные числа от 1 до 100*/
            }
            //словарь для счета входа
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var number in thay)
            {
                if (pairs.ContainsKey(number))
                {
                    pairs[number]++;
                }
                else
                {
                    pairs[number] = 1;
                }
            }
            //подсчитываем кол-во пар
            int pppairs = 0;
            foreach (var count in pairs.Values)
            {
                if (count > 1)
                { pppairs += count * (count - 1) / 2; } /*формула для подсчета пар*/
            }
            Console.WriteLine("Кол-во пар элементов, значения которых равны:" + pppairs);
              



        }
    }
}
