
using SolidPrinciples.SingleResponsability;

Console.WriteLine("Hello, World!");


Book book = new Book();

string title = book.Title = "Don Quijote";
string author = book.Author = "Miguel De Cervantes";
string isbn = book.ISBN = "894859084350980";


BookRepository bookRepository = new BookRepository();
bookRepository.Save(title, author, isbn);

BookPrinter bookPrinter = new BookPrinter();
bookPrinter.Print(title, author, isbn);


