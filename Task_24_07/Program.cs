namespace Task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            CreateFile(filePath);
            string searchWord = "тебя";
            try
            {
                List<string> matchingLines = FindLinesContainingWord(filePath, searchWord);
                Console.WriteLine($"Строки, содержащие слово \"{searchWord}\":");
                foreach (string line in matchingLines)
                {
                    Console.WriteLine(line);
                }
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
                writer.WriteLine("Я разлюбила тебя ночью.");
                writer.WriteLine("Я больше не люблю тебя.");
                writer.WriteLine("Я наконец смогла,");
                writer.WriteLine("Я сама, я без тебя");
                writer.WriteLine("Не полюблю тебя я никогда!");
            }
        }
        static List<string> FindLinesContainingWord(string filePath, string word)
        {
            List<string> matchingLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }
            return matchingLines;
        }
    }
}