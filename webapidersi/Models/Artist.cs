using Microsoft.Identity.Client;

namespace webapidersi.Models
{
	public class Artist
	{
        public int ArtistId { get; set; }
		public string Name { get; set; }
		public string About { get; set; }

		public ICollection<Work> Works { get; set;} //one-to-many ilişkisi/ list<Work>

    }
}
