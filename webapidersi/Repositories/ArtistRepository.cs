using webapidersi.Interfaces;
using webapidersi.Models;

namespace webapidersi.Repositories
{
	public class ArtistRepository : IArtistRepository
	{
		private RepositoryContext _context;

		public ArtistRepository(RepositoryContext context)
		{

			_context = context;
		}
		public bool ArtistExists(int id)
		{
			return _context.Artists.Any(e=>e.ArtistId==id);
		}

		public Artist GetArtist(int id)
		{
			return _context.Artists.Where(e=>e.ArtistId == id).FirstOrDefault();
		}

		public ICollection<Artist> GetArtists()
		{
			return _context.Artists.ToList();
		}
	}
}
