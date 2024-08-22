using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Data;

namespace LibraryManagementWEBAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly  LMSWEBAPIContext _context;

        public BookRepository(LMSWEBAPIContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            _context.Book.Remove(_context.Book.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Book.ToList<Book>();
        }

        public Book GetById(int id)
        {
            return _context.Book.Find(id);
        }

        public void Update(Book book)
        {
            _context.Book.Update(book);
            _context.SaveChanges();
        }


    }
}
