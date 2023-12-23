using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class ProfileRepository : IProfileRepository
	{
		private readonly RepositoryContext _context;
		public ProfileRepository(RepositoryContext context) { 
		 
			_context = context;
		}

		public Profile GetProfile(int id)
		{
			return _context.Profiles.Where(p => p.ProfileId == id).FirstOrDefault();
		}

		public ICollection<Profile> GetProfiles()
		{
			return _context.Profiles.OrderBy(p => p.ProfileId).ToList();

		}

		public bool ProfileExists(int id)
		{
			return _context.Profiles.Any(e => e.ProfileId == id);
		}

	

	}
}
