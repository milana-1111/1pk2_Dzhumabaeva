namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
            //модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
            //двух равных по модулю.В полученном массиве найти наибольшее по модулю число.

            int mannym = 10; //создаем массив
            int[] namb = new int[mannym];
            HashSet<int> seTTS = new HashSet<int>();
            Random randdd = new Random();
            for (int i = 0; i < mannym; i++)
            {
                int namber ;
                do
                {
                    //Генерируем рандомное число от -mannym до mannym
                    namber = randdd.Next(-mannym, mannym + 1);
                }
                while (seTTS.Contains(Math.Abs(namber)) || namber == 0);
                namb [i] = namber;
                seTTS.Add(Math.Abs(namber));
            }
            //Выводим массив
            Console.WriteLine("Сгенерированный массив:");
            foreach (var num in namb)
            {
                Console.WriteLine(num);
            }
            //Находим наибольшее по модулю число
            int max1 = namb[0];
            for (int i = 1; i < namb.Length; i++)
            {
                if (Math.Abs(namb[i]) > Math.Abs(max1))
                {
                    max1 = namb[i];
                }
            }
            Console.WriteLine($"Наибольшее по модулю число:{max1}");
        }

            
    }
}
