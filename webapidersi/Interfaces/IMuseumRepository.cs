using webapidersi.Models;

namespace webapidersi.Interfaces
{
	public interface IMuseumRepository
	{ 
		ICollection<Museum> GetMuseums();
		Museum GetMuseum(int id);
		bool MuseumExists(int id);

	}
}
