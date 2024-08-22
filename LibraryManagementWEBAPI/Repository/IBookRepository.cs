using LibraryManagementWEBAPI.Model;

namespace LibraryManagementWEBAPI.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetById(int id);
        void DeleteById(int id);
        void Update(Book book);
        void AddBook(Book book);

    }
}
