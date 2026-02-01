public class Library
{
    public List<Book> Books = [];

    public Library()
    {
        this.Books = [];
    }

    public Library(List<Book> books)
    {
        this.Books = books;
    }
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine("Book is added successfully");
    }

    public Book? SearchBook(string title)
    {
        foreach (Book book in Books)
        {
            if (book.GetTitle().Contains(title))
                return book;
        }
        return null;
    }

    public bool BorrowBook(string title)
    {
        Book? book = SearchBook(title);
        if (book == null || book.GetIsAvailable() == Availability.borrowed)
        {
            Console.WriteLine("This book is not in the library");
            return false;
        }
        book.SetIsAvailable(Availability.borrowed);
        Console.WriteLine("Book is borrowed successfully");
        return true;
    }

    public bool ReturnBook(string title)
    {
        Book? book = SearchBook(title);
        if (book == null || book.GetIsAvailable() == Availability.available)
        {
            Console.WriteLine("This book is not borrowed");
            return false;
        }

        book.SetIsAvailable(Availability.available);
        Console.WriteLine("Book is returned successfully");
        return true;
    }
}