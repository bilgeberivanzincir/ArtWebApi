using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IMemberRepository
	{
		ICollection<Member> GetMembers();
		Member GetMember(int id);
		bool MemberExists(int id);

		void CreateMember(Member member);
		void UpdateMember(Member member);
		void DeleteMember(int id);
		bool Save();

	}
}
