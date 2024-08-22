using LibraryManagementWEBAPI.Exceptions;
using LibraryManagementWEBAPI.Model;
using LibraryManagementWEBAPI.Repository;

namespace LibraryManagementWEBAPI.Service
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository repository)
        {
            _repository = repository;
        }

        public void AddMember(Member member)
        {
            _repository.AddMember(member);
        }

        public void DeleteMember(int id)
        {
            var Member = _repository.GetById(id);
            if (Member == null)
            {
                throw new MemberNotFoundException(id);
            }
            _repository.DeleteById(id);
        }

        public Member GetMember(int id)
        {
            var Member = _repository.GetById(id);
            if (Member == null)
            {
                throw new MemberNotFoundException(id);
            }
            return Member;
        }

        public IEnumerable<Member> GetMembers()
        {
            return _repository.GetAllMembers();
        }

        public void UpdateMember(Member Member1)
        {
            var Member = _repository.GetById(Member1.MemberId);
            if (Member == null)
            {
                throw new MemberNotFoundException(Member1.MemberId);
            }
            _repository.Update(Member1);
        }

    }
}
