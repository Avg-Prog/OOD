using Ucll.OOD.Validations.Models;

namespace Ucll.OOD.Validations.Repositories;

public sealed class BookRepository
{
    private static BookRepository _instance = new BookRepository();
    private static object _locker = new object();

    public static BookRepository Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_locker)
                {
                    _instance = new BookRepository();
                }
            }
            return _instance;
        }
    }

    private readonly List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Name = "The Clean Coder", Author = "Robert Martin", ISBN13 = " 9780137081073", ISBN10 = "0137081073", Releaseyear=2011},
        new Book { Id = 2, Name ="The Mythical Man-Month", Author="Frederick Brooks Jr.", ISBN13="9780201835953", ISBN10="0201835953", Releaseyear=1995}

    };

    public bool AddBook(Book book)
    {
        try
        {
            _books.Add(book);
            return true;

        }
        catch (Exception)
        {
            return false;
        }

    }

    public bool DeleteBook(int id)
    {
        var toDelete = _books.FirstOrDefault(book => book.Id == id);
        if (toDelete != null)
        {
            _books.Remove(toDelete);
            return true;
        }
        return false;
    }

    public Book? GetBook(int id)
    {
        return _books.FirstOrDefault(book => book.Id == id);
    }

    public List<Book> GetBooks()
    {
        return _books;
    }
}
