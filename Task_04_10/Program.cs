namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Заполнить массив из 10 элементов случайными числами в интервале[-10..10] и сделать реверс элементов
            //отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
            //использовать нельзя.

            int[] mil = new int[10];
            Random rnd = new Random();
            Console.WriteLine("исходный массив : ");
            for (int i = 0; i < mil.Length; i++)
            {
                mil[i] = rnd.Next(-10, 11);
                Console.WriteLine(mil[i]);
            }
            Console.WriteLine("Результат:");
            int x = mil.Length / 2;
            for (int i = x; i >= 0; i--)
            {
                Console.WriteLine(mil[i]);
            }
            for (int j = 9; j >= 5; j--)
            {
                Console.WriteLine(mil[j]);
            }
        }
    }
}
