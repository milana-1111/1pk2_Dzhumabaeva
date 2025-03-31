namespace Task_21_06
{
    internal class Program
    {
        //Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
        static void Main(string[] args)
        {
            List<int> number = new List<int> {1,2,3,2,4,1,5,6,7,6};
            List<int> Number = RemoveDuplicates(number);

            Console.WriteLine(string.Join(",", Number));
        }
        static List<T> RemoveDuplicates<T>(List<T> list)
        {
            HashSet<T> seen = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (T item in list)
            {
                if (seen.Add(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}