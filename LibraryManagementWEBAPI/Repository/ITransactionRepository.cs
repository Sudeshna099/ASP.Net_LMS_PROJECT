using LibraryManagementWEBAPI.Model;
namespace LibraryManagementWEBAPI.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransaction();
        void addBorrowing(Transaction transaction);
        void addReturn(Transaction transaction);
        IEnumerable<Transaction> GetTransactionsByMemberId(int id);

    }
}
