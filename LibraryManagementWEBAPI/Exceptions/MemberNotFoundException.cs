namespace LibraryManagementWEBAPI.Exceptions
{
    public class MemberNotFoundException:ApplicationException
    {
        public MemberNotFoundException(int id) : base($"Member with id {id} not available")
        {

        }

    }
}
