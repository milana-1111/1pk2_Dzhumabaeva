namespace Task_21_08
{
    internal class Program
    {
        //напишите метод, который на вход получается массив параметров(строк) и возвращает только уникальные строки
        static void Main(string[] args)
        {
            string[] input = new string[] {"игрушка","кот","игрушка","стол","кот","цветок","книга"};
            string[] uniqueStrings = GetUniqueStrings(input);

            Console.WriteLine(string.Join(",", uniqueStrings));
        }
        static string[] GetUniqueStrings(string[] strings)
        {
            HashSet<string> uniqueSet = new HashSet<string>(strings);
            return new List<string>(uniqueSet).ToArray();
        }
    }
}
