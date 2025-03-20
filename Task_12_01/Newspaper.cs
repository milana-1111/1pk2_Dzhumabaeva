namespace Task_12_01
{
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
