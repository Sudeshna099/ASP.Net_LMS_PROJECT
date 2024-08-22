using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Data;
namespace LibraryManagementWEBAPI.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LMSWEBAPIContext _context;

        public TransactionRepository(LMSWEBAPIContext context)
        {
            _context = context;
        }
        public void addBorrowing(Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
        }

        public void addReturn(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            _context.SaveChanges();
        }

        public IEnumerable<Transaction> GetAllTransaction()
        {
            var trainsactions = _context.Transaction.ToList();
            return trainsactions;
        }

        public IEnumerable<Transaction> GetTransactionsByMemberId(int id)
        {
            var trainsactions = _context.Transaction.Where(t => t.MemberId == id).ToList();
            return trainsactions;
        }

    }
}
