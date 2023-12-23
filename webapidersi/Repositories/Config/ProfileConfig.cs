using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class ProfileConfig : IEntityTypeConfiguration<Profile>
	{
		public void Configure(EntityTypeBuilder<Profile> builder)
		{
			builder.HasData(
				new Profile { ProfileId = 1, Fallowers = 1, Fallowing = 1, Comment = "Büyüleyici bir eser", Favorites = null, Visited = "fsfsff" },
				new Profile { ProfileId = 2, Fallowers = 1, Fallowing = 1, Comment = "Büyüleyici bir yer", Favorites = null, Visited = "jsdjsks" });
		}
	}
}
