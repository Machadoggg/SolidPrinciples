namespace SolidPrinciples.SingleResponsability
{
    //// Class with 3 resposabilities:
    // 1. Store information about a book.
    // 2. Save the book.
    // 3. Manage printing of book details.


    // Store information about a book //
    //public class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public string ISBN { get; set; }

    // Save the book //
    //    public void Save()
    //    {
    //        // Código para guardar el libro en la base de datos
    //    }

    // Manage printing of book details //
    //    public void Print()
    //    {
    //        // Código para imprimir los detalles del libro
    //    }
    //}



    public class Book
    {
        public string Title { get; set; } = default!;
        public string Author { get; set; } = default!;
        public string ISBN { get; set; } = default!;
    }

    public class BookRepository
    {
        public void Save(string title, string author, string isbn)
        {
            Console.WriteLine($"The book {title} of the author {author} with ISBN #: {isbn} Save successfully!");
        }
    }

    public class BookPrinter
    {
        public void Print(string title, string author, string isbn)
        {
            Console.WriteLine($"The book {title} of the author {author} with ISBN #: {isbn} Print successfully!");
        }
    }
}

