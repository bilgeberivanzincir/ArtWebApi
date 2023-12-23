using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class MuseumRepository : IMuseumRepository
	{
		private RepositoryContext _context;

		public MuseumRepository(RepositoryContext context)
		{

			_context = context;
		}
		public bool MuseumExists(int id)
		{
			return _context.Artists.Any(e => e.ArtistId == id);
		}

		public Museum GetMuseum(int id)
		{
			return _context.Museums.Where(e => e.ID == id).FirstOrDefault();
		}

		public ICollection<Museum> GetMuseums()
		{
			return _context.Museums.ToList();
		}
	}
}
