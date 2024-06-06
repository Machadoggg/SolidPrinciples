namespace SolidPrinciples.SingleResponsability
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    public class BookRepository
    {
        public void Save()
        {
            // Code for save the book in DB
        }
    }

    public class BookPrinter
    {
        public void Print()
        {
            // Code for print book details
        }
    }
}

