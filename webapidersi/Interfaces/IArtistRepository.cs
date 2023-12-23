using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IArtistRepository 
	{
		ICollection<Artist> GetArtists();
		Artist GetArtist(int id);
		bool ArtistExists(int id);
	}
}
