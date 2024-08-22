using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Data;

namespace LibraryManagementWEBAPI.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly LMSWEBAPIContext _context;

        public MemberRepository(LMSWEBAPIContext context)
        {
            _context = context;
        }

        public void AddMember(Member member)
        {
            _context.Member.Add(member);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            _context.Member.Remove(_context.Member.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _context.Member.ToList<Member>();
        }



        public Member GetById(int id)
        {
            return _context.Member.Find(id);
        }

        public void Update(Member member)
        {
            _context.Member.Update(member);
            _context.SaveChanges();
        }


    }
}
