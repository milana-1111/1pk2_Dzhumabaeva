namespace Task_24_08
{
    internal class Program
    {
        //реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения,
        //    введенные пользователем
        static void Main(string[] args)
        {
            string filePath = "myFail.txt"; 
            CreateFile(filePath); 

            Console.WriteLine("Введите текст для поиска:");
            string searchText = Console.ReadLine();

            Console.WriteLine("Введите текст для замены:");
            string replacementText = Console.ReadLine();
            try
            {
                ReplaceTextInFile(filePath, searchText, replacementText);
                Console.WriteLine("Замена выполнена. Содержимое файла:");
                Console.WriteLine(File.ReadAllText(filePath));
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
                writer.WriteLine("Славься, славься, ты Русь моя\r\nСлавься, ты русская наша земля\r\nДа будет во веки веков сильна\r\nЛюбимая наша страна\r\nТак было в России с далёких времён\r\nЧем выше давление, тем крепче бетон\r\nИ если опасность державе грозит\r\nСтановится Родина, как монолит\r\nВ горниле победы сегодня как встарь\r\nОпять закаляется Родины сталь");
                writer.WriteLine("Россия, Россия — в этом слове огонь и сила\r\nВ этом слове победы пламя\r\nПоднимаем России знамя\r\nРоссия, Россия — в этом слове огонь и сила\r\nВ этом слове победы пламя\r\nПоднимаем России знамя");
                writer.WriteLine("Пусть время нас бурным потоком несёт\r\nЗа нами Россия, за нами народ\r\nТрадиции святы и тысячи лет\r\nПродолжится летопись наших побед\r\nА если врагов налетит вороньё\r\nИх снова Отечество встретит моё");
                writer.WriteLine("Россия, Россия — в этом слове огонь и сила\r\nВ этом слове победы пламя\r\nПоднимаем России знамя\r\nРоссия, Россия — в этом слове огонь и сила\r\nВ этом слове победы пламя\r\nПоднимаем России знамя");
            }
        }
        static void ReplaceTextInFile(string filePath, string searchText, string replacementText)
        {
            string fileContent = File.ReadAllText(filePath);
            string updatedContent = fileContent.Replace(searchText, replacementText);
            File.WriteAllText(filePath, updatedContent);
        }
    }
}
