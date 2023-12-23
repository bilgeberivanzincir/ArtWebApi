using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class ExhibitionConfig : IEntityTypeConfiguration<Exhibition>
	{
		public void Configure(EntityTypeBuilder<Exhibition> builder)
		{
			builder.HasData(

				new Exhibition { ExhibitionId = 1, Name = "Hikayelerin Hikayesi", Description = "kskskjfjffsf" },
				
				new Exhibition { ExhibitionId = 2, Name = "Varoluş ve Yüzey", Description = "aaaaa" }
				);
		}
	}
}
