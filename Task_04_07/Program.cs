namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
            //отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
            //мальчиков и девочек. При выводе избавиться от отрицательных значений.

            int[] x = new int[30];
            Random rnd = new Random();
            int y = 0;
            int z = 0;
            int number1 = 0;
            int number2 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(-300, 190);
                if (x[i] < 0)
                {
                    Console.WriteLine($"Рост мальчика {i} :");
                    Console.WriteLine(Math.Abs(x[i]));
                    number1 += Math.Abs(x[i]);
                    y++;
                }
                else
                {
                    Console.WriteLine($"Рост девочки {i} :");
                    Console.WriteLine(x[i]);
                    number2 += x[i];
                    z++;
                }
            }
            Console.WriteLine($"кол-во мальчиков:{y}");
            Console.WriteLine($"кол-во девочек:{z}");
            Console.WriteLine("Средний рост мальчиков:  ");
            Console.WriteLine(number1 / y);
            Console.WriteLine("Средний рост девочек:  ");
            Console.WriteLine(number2 / z);




        }
    }

}
    