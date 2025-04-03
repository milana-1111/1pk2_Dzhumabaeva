namespace Task_23_06
{
    internal class Program
    {
//        Напишите программу со следующими функциями:
//1. Выведите информации о всех дисках в системе
//2. Выведите содержимое каталога C:\Users(названия папок)
//3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
//a) Создание вложенного каталога “temp”
//b) Вывод информации о текущем каталоге(имя, родитель и тд)
//c) Вывод информации о вложенном каталоге
//4. Переместите каталог “temp” по пути “D:\work\newTemp”
//a) Реализуйте вывод информационного сообщения об успешном(или нет)
//перемещении
//5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном(или нет)
//удалении
        static void Main(string[] args)
        {
            //1. Выведите информации о всех дисках в системе
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Диск: {drive.Name}, Тип: {drive.DriveType}, свободное пространство: {drive.AvailableFreeSpace} bytes");
            }

            //2. Выведите содержимое каталога C:\Users(названия папок)
            string userDirectory = @"C:\Users";
            Console.WriteLine($"\nСодержимое {userDirectory}:");
            string[] directories = Directory.GetDirectories(userDirectory);
            foreach (string dir in directories)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }

            //3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            string workDirectory = @"D:\work";
            Directory.CreateDirectory(workDirectory);
            Console.WriteLine($"\nПапка '{workDirectory}' создана.");
            //a) Создание вложенного каталога “temp”
            string tempDirectory = Path.Combine(workDirectory, "temp");
            Directory.CreateDirectory(tempDirectory);
            Console.WriteLine($"Вложенный каталог '{tempDirectory}' создан.");
            //b) Вывод информации о текущем каталоге(имя, родитель и тд)
            DirectoryInfo currentDirectory = new DirectoryInfo(workDirectory);
            Console.WriteLine($"\nТекущий каталог: {currentDirectory.FullName}");
            Console.WriteLine($"Родительский каталог: {currentDirectory.Parent?.FullName}");
            //c) Вывод информации о вложенном каталоге
            DirectoryInfo tempDirInfo = new DirectoryInfo(tempDirectory);
            Console.WriteLine($"\nИнформация о каталоге 'temp':");
            Console.WriteLine($"Имя: {tempDirInfo.Name}");
            Console.WriteLine($"Полный путь: {tempDirInfo.FullName}");
            Console.WriteLine($"Создан: {tempDirInfo.CreationTime}");

            //4. Переместите каталог “temp” по пути “D:\work\newTemp
            string newTempDirectory = Path.Combine(workDirectory, "newTemp");
            try
            {
                Directory.Move(tempDirectory, newTempDirectory);
                Console.WriteLine($"Каталог 'temp' успешно перемещен в'{newTempDirectory}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении: {ex.Message}");
            }

            //5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном(или нет)
            try
            {
                Directory.Delete(newTempDirectory); // eдаляем новый каталог,так как "temp" уже перемещен
                Console.WriteLine($"Каталог '{newTempDirectory}' успешно удален.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении: {ex.Message}");
            }
        }
    }
}