namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
//Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
//время работы программы
            // Ввод начальной температуры в Цельсия
            Console.WriteLine("Введите начальную температуру в градусах Цельсия: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // Ввод конечной температуры в Цельсия
            Console.WriteLine("Введите конечную температуру в градусах Цельсия: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Ввод шага
            Console.WriteLine("Введите шаг изменения температуры в градусах Цельсия:");
            double z = Convert.ToDouble(Console.ReadLine());

            // Вывод таблицы 
            Console.WriteLine("\nЦельсий  tФаренгейт");
            Console.WriteLine(" ");

            //Цикл
            for (double C = x; C <= y; C += z)

            {
                double F = C * 1.8 + 32;
                Console.WriteLine($"{C:F2}\t{F:F2}");
                Console.ReadKey();
            }

        }
    }
}
