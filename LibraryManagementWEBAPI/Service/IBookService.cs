using LibraryManagementWEBAPI.Model;

namespace LibraryManagementWEBAPI.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);

    }
}
