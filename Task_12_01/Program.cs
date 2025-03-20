namespace Task_12_01
{
    internal class Program
    {
        //в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
        //дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса:
        //покупка журнала
        //просмотр содержания журнала
        //в этом же проекте реализуйте класс Newspaper(газета) со следующими данными:
        //дата издания, название газеты, заголовок главной полосы, количество страниц, цена
        //функционал класса:
        static void Main(string[] args)
        {
            Book book1 = new Book("Марсианские хроники", "Рей Бредберри");
            book1.DisplayInfo();
            book1.TryBorrow();
            book1.TryBorrow(); // Попытка повторного получения

            book1.ReturnBook(); // Возврат книги
            book1.TryBorrow(); // Выдача книги снова

            Console.WriteLine();

            Journal journal1 = new Journal("Непоседа", new DateTime(2015, 7, 20), "Детский", 123, 45);
            journal1.View();
            journal1.Buy();

            Console.WriteLine();

            Newspaper newspaper1 = new Newspaper("Новости Оренбург", new DateTime(2008, 3, 26), "Новости дня", 10, 50);
            newspaper1.GetInformation();
            newspaper1.Publish();
        }
    }
}
