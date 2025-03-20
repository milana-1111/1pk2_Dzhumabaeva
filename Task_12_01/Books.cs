namespace Task_12_01
{
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
}
