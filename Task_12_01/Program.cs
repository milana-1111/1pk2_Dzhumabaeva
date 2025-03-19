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

    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private bool IsBorrowed { get; set; }

        public Books(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Author} : {Title}");
        }

        public string GetTitle()
        {
            return Title;
        }

        public void TryBorrow(string title)
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"Книгав данный момент выдана другому читателю");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"Книга выдана на неделю.");
            }
        }

        public void ReturnBook()
        {
            IsBorrowed = false;
            Console.WriteLine($"Книга  возвращена.");
        }
    }

    class Journal
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Theme { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public Journal(string title, DateTime date, string theme, int pageCount, decimal price)
        {
            Title = title;
            Date = date;
            Theme = theme;
            PageCount = pageCount;
            Price = price;
        }

        public void View()
        {
            Console.WriteLine($"Журнал: {Title}, Дата: {Date.ToShortDateString()}, Тематика: {Theme}, Страницы: {PageCount}, Цена: {Price} руб.");
        }

        public void Buy()
        {
            Console.WriteLine($"Вы купили журнал за {Price} руб.");
        }
    }

    class Newspaper
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Headline { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public Newspaper(string title, DateTime date, string headline, int pageCount, decimal price)
        {
            Title = title;
            Date = date;
            Headline = headline;
            PageCount = pageCount;
            Price = price;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Газета: {Title}, Дата: {Date.ToShortDateString()}, Заголовок: {Headline}, Страницы: {PageCount}, Цена: {Price} руб.");
        }

        public void Publish()
        {
            Console.WriteLine($"Газета опубликована.");
        }
    }
}
