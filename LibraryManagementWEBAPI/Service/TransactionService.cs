using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Repository;

namespace LibraryManagementWEBAPI.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepo;
        private readonly IBookService _bookService;

        public TransactionService(ITransactionRepository repo, IBookService bookService)
        {
            _transactionRepo = repo;
            _bookService = bookService;
        }
        public void addBorrowing(Transaction transaction)
        {
            var book = _bookService.GetBook((int)transaction.BookId);
            _bookService.UpdateBook(book);
            _transactionRepo.addBorrowing(transaction);
        }

        public void addReturn(Transaction transaction)
        {
            var book = _bookService.GetBook((int)transaction.BookId);
            _bookService.UpdateBook(book);
            _transactionRepo.addReturn(transaction);

        }

        public IEnumerable<Transaction> GetAllTransaction()
        {
            return _transactionRepo.GetAllTransaction();
        }

        public IEnumerable<Transaction> GetTransactionsByMemberId(int id)
        {
            return _transactionRepo.GetTransactionsByMemberId(id);
        }

    }
}
