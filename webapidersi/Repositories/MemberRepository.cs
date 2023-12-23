using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class MemberRepository : IMemberRepository
	{
		private RepositoryContext _context;

		public MemberRepository(RepositoryContext context)
		{

			_context = context;


		}

		public Member GetMember(int id)
		{
			return _context.Members.Where(e => e.ID == id).FirstOrDefault();

		}

		public ICollection<Member> GetMembers()
		{
			return _context.Members.ToList();
		}


		public void CreateMember(Member member)
		{
			_context.Members.Add(member);
		}

		public void DeleteMember(int id)
		{
			var member = GetMember(id);
			if (member != null)
			{
				_context.Members.Remove(member);
			}

		}

		public bool MemberExists(int id)
		{
			return _context.Members.Any(e => e.ID == id);
		}

		public void UpdateMember(Member member)
		{
			_context.Members.Update(member);
		}

		public bool Save()
		{
			var saved = _context.SaveChanges();
			return saved > 0 ? true : false;
			
		}
	}
}
