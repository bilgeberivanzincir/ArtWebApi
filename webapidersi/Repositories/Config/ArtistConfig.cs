using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class ArtistConfig : IEntityTypeConfiguration<Artist>
	{
		public void Configure(EntityTypeBuilder<Artist> builder)
		{
			builder.HasData(
				new Artist { ArtistId = 1, Name = "Michelangelo", About = "İtalyan rönesans dönemi ressam, heykeltıraş, mimar ve şairidir." },
				new Artist { ArtistId = 2, Name = "Paula Rego", About = "Portekizli ressam ve desinatör" });
		}
	}
}
