namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
            //вывести уникальные элементы массива. (LINQ использовать нельзя)

            int[] artik = { 1, 2, 2, 3 , 4, 4, 5, 6, 6, 7 };
            Dictionary<int, int> map = new Dictionary<int, int>();
            //считаем кол-во вхождений каждого элемента
            foreach (var item in artik)
            {
                if (map.ContainsKey(item))
                { map[item]++; }
                else { map[item] = 1; }
            }
            //выводим элементы, которые встречаются только 1 раз
            foreach (var krut in map)
            {
                if (krut.Value ==1)
                {
         Console.WriteLine(krut.Key);
                }
            }
        }
    }
}
