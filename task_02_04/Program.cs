namespace task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
//расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
//этом

            Console.WriteLine("Ведите нынешний год");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите нынешний месяц");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите нынешний день");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите свой год рождения: \n ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите свой месяц рождения: \n");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите дату рождения: \n");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = x - a;
             if ((y < b & d== 18) || (y==b & z<c))
            { d -= 1; }
            Console.WriteLine(d);
            if (d >= 18)
            {
                Console.WriteLine("Совершеннолетний");

            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }

            Console.ReadKey();




        }
    }
}
