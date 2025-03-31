namespace Task_21_07
{
    internal class Program
    {
        //Написать метод, который находит первый ключ в словаре, соответствующий заданному значению.
        //Если значения нет, вернуть null.
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "key1", 10 },
            { "key2", 15 },
            { "key3", 30 },
            { "key4", 10 }
        };
            string result = FindKeyByValue(dict, 10);
            Console.WriteLine(result ?? "Значение нет");
        }
        static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Value.Equals(value))
                {
                    return pair.Key;
                }
            }
            return null;
        }
    }
}
