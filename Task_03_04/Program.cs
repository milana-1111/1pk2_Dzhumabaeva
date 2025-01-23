namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.Когда
//пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
//введенных пользователем.

            int x = 0;
            string y;

            while (true)
            {
                Console.WriteLine("Введите текст (или'exit' для выхода): ");
                y = Console.ReadLine();

                if (y == "exit" || y == "")
                {
                    break;

                }

                x++;
                Console.Clear();
            }

            Console.WriteLine($"кол-во введенных строк: {x}");
            Console.ReadKey();
        }
    }
}
   
