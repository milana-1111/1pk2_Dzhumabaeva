namespace Task_21_10
{
    internal class Program
    {
        //Написать метод, который объединяет два словаря.
        //Если ключ присутствует в обоих словарях, суммироватьихзначения.
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"a",1},
            {"b",3},
            {"c",5}
        };
            Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"b",2},
            {"c",4},
            {"d",6}
        };
            Dictionary<string, int> combinedDict = MergeDictionaries(dict1, dict2);
            foreach (var kvp in combinedDict)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
            }
        }
        static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            Dictionary<string, int> result = new Dictionary<string, int>(dict1);
            foreach (var kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    result[kvp.Key] += kvp.Value;//складываем значения
                }
                else
                {
                    result[kvp.Key] = kvp.Value;//добавляем новый ключ
                }
            }
            return result;
        }
    }
}
