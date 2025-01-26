namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
            //отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
            //мальчиков и девочек. При выводе избавиться от отрицательных значений.

            int raszmer = 30; //Размер массива
            int[] heiter = new int[raszmer];
            Random rendevy = new Random();
            //Заполняем массив рандомными значениями
            for (int i = 0; i < raszmer; i++)
            {
                //Генерируем рандомный рост от -150 до 200см
                heiter[i] = rendevy.Next(-150, 201);
            }
            int boysC = 0;
            int girlsC = 0;
            int boysS = 0;
            int girlsS = 0;
            foreach (var heite in heiter)
            {
                if (heite < 0) //рост мальчиков
                {
                    boysC++;
                    boysS += Math.Abs(heite);
                }

            }
            // Находим средний рост
            double boys = boysC > 0 ? (double)boysS / boysC : 0;
            double girl = girlsC > 0 ? (double)girlsS / girlsC : 0;
            //Выводим результат
            Console.WriteLine($"кол-во мальчиков:{boysC}");
            Console.WriteLine($"кол-во девочек:{girlsC}");
            Console.WriteLine($"средний рост мальчиков:{boys:F2}см");
            Console.WriteLine($"средний рост девочек:{girl:F2}см");
            //Вывод роста без отрицательных значений
            Console.WriteLine("\nРост мальчиков(без отрицательных значений):");
            foreach (var heit in heiter)
            {
                if (heit < 0)
                {
                    Console.WriteLine(Math.Abs(heit));
                }
            }
            Console.WriteLine("Рост девочек:");
            foreach (var heit in heiter)
            {
                if (heit >= 0)
                {
                    Console.WriteLine(heit);
                }
                }
            }
        }
}
