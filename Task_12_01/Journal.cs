namespace Task_12_01
{
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
}
