namespace LibraryManagementWEBAPI.Exceptions
{
    public class BookNotFoundException:ApplicationException
    {
        public BookNotFoundException(int id) : base($"Book with id {id} not available")
        {

        }

    }
}
