namespace Task_24_06
{
    internal class Program
    {
        //Напишите метод, который принимает путь к файлу и возвращает количество строк в нем.
        //ИспользуйтеStreamReader.
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            CreateFile(filePath);
            try
            {
                int lineCount = CountLines(filePath);
                Console.WriteLine($"Количество строк в файле: {lineCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        static void CreateFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Россия — священная наша держава");
                writer.WriteLine("Россия — любимая наша страна.");
                writer.WriteLine("Могучая воля, великая слава ");
                writer.WriteLine("Твоё достоянье на все времена!");
            }
        }
        static int CountLines(string filePath)
        {
            int lineCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            return lineCount;
        }
    }
}