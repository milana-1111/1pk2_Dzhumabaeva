namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
            //которых равны.

            int[] ints = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(0, 100);
                Console.WriteLine(ints[i]);
            }
            int mints = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (ints[i] == ints[j])
                    {
                           mints++;
                    }
                }
            }
            Console.WriteLine($"Коллисество пар: {mints}");
        }
    }
}
