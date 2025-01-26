namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Заполнить массив из 10 элементов случайными числами в интервале[-10..10] и сделать реверс элементов
//отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
//использовать нельзя.

            Random rraruy = new Random();
            int[] amary = new int[10];

            //заполняем массив случайными числами

            for (int i = 0; i < amary.Length; i++)
            {
                amary[i] = rraruy.Next(-10, 11); /*генерация числа от -10 до 10*/
            }
            Console.WriteLine("Исходный массив:");
            Priamary(amary);

            //Реверс 1ой половины массива



            {
                
            }
        }
    }
}
