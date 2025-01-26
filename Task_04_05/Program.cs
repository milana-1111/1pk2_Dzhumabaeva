namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве хранятся сведения о количестве осадков за месяц(30 дней).Необходимо определить общее
            //количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
            //отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
            //осадков, до 300 мм выпавших осадков.

            //Создаем массив для для хранения осадков за 30 дней
            int[] aresk = new int[30];
            Random rnd = new Random();
            //Заполняем массив рандомными значениями от 0 до 30
            for (int i = 0; i < aresk.Length; i++)
            {
                aresk[i] = rnd.Next(0, 301);
            }
            //Выводим данные о кол-ве осадков
            Console.WriteLine("кол-во осадков за месяц:");
            for (int i= 0; i< aresk.Length; i++)
            {
                Console.WriteLine($"День{i + 1}:{aresk [i] }");
            }
            //Определяем общее кол-во осадков за каждую декаду 
            for (int decada= 0; decada<3; decada++)
            {
                int x = decada * 10;
                int y = 0;
                for (int day = y; day<y+10;day++)
                {
                    y += aresk[day];
                }
                Console.WriteLine($"Общее кол-во осадков {decada + 1}:{y}");
            }
            //Находим день  с самыми сильными осадками
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < aresk.Length; i++)
            {
                if (aresk[i] > max1)
                {
                    max1 = aresk[i];
                    max2 = aresk[i + 1];
                }
            }
            Console.WriteLine($"День с самыми сильными осадками: День {max2}({max1}мм)");
            //Дни без осадков
            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < aresk.Length; i++)
            {
                if (aresk[i] == 0)
                { Console.WriteLine($"День{i + 1}");
                }
            }





        }
    }
}
