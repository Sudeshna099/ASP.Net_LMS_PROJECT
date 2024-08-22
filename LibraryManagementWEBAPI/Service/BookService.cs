using LibraryManagementWEBAPI.Exceptions;
using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Repository;

namespace LibraryManagementWEBAPI.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public void DeleteBook(int id)
        {
            var book = _repository.GetById(id);
            if (book == null)
            {
                throw new BookNotFoundException(id);
            }
            _repository.DeleteById(id);
        }

        public Book GetBook(int id)
        {
            var book = _repository.GetById(id);
            if (book == null)
            {
                throw new BookNotFoundException(id);
            }
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.GetAllBooks();
        }

        public void UpdateBook(Book book1)
        {
            var book = _repository.GetById(book1.Id);
            if (book == null)
            {
                throw new BookNotFoundException(book1.Id);
            }
            _repository.Update(book1);
        }

    }
}
