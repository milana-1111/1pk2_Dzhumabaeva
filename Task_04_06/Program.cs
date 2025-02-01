namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
            //модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
            //двух равных по модулю.В полученном массиве найти наибольшее по модулю число.

            int[] x = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Вывод чисел в массиве: ");
            for (int i = 0; i < x.Length; i++)

            {
                x[i] = rnd.Next(-100, 100);

                Console.WriteLine(x[i]);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Максимальное число по модулю : ");
            Console.WriteLine(x.Max(Math.Abs));
        }

            
    }
}
