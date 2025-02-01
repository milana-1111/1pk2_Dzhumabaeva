namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
            //вывести уникальные элементы массива. (LINQ использовать нельзя)

            int[] xter = new int[30];
            Random random = new Random();

            for (int i = 0; i < xter.Length; i++)
            {
                xter[i] = random.Next(10, 50);
            }
            bool yffer = true;
            Console.WriteLine($"Уникльные элементы:");
            for (int i = 0; i <= xter.Length; i++)
            {
                yffer = true;
                for (int j = 0; j < xter.Length; j++)
                {
                    if (xter[i] == xter[j] && i != j)
                    {
                        yffer = false;
                    }
                }
                if (yffer == true)
                {
                    Console.WriteLine(xter[i]);
                }
            }
            }
    }
}
