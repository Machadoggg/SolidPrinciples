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

