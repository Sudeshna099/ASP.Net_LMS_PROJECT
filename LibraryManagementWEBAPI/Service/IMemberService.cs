using LibraryManagementWEBAPI.Model;

namespace LibraryManagementWEBAPI.Service
{
    public interface IMemberService
    {
        IEnumerable<Member> GetMembers();
        Member GetMember(int id);
        void AddMember(Member member);
        void DeleteMember(int id);
        void UpdateMember(Member member);

    }
}
