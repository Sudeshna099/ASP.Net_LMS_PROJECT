using LibraryManagementWEBAPI.Model;

namespace LibraryManagementWEBAPI.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAllMembers();
        Member GetById(int id);
        void DeleteById(int id);
        void Update(Member member);
        void AddMember(Member member);

    }
}
