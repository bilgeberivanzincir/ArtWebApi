using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IProfileRepository
	{
		ICollection<Profile> GetProfiles();

		Profile GetProfile(int id);

		bool ProfileExists(int id);
	}
}
