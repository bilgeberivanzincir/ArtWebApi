using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class MuseumConfig : IEntityTypeConfiguration<Museum>
	{
		public void Configure(EntityTypeBuilder<Museum> builder)
		{
			builder.HasData(
				new Museum { ID = 1, Name = "Pera Müzesi", City = "İstanbul", 
					Country = "Türkiye", Address = "Asmalı Mescit, Meşrutiyet Cd. No:65, 34430 Beyoğlu/İstanbul" },
				new Museum { ID = 2, Name = "Bargello Müzesi", City = "Florence",
					Country = "Italy", Address = "Via del Proconsolo,4,50122" });
		}
	}
}
