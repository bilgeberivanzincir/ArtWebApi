using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class WorkConfig : IEntityTypeConfiguration<Work>
	{
		public void Configure(EntityTypeBuilder<Work> builder)
		{
			builder.HasData(
				new Work
				{
					ID = 1,
					Kunye = "Michelangelo,Adem'in Yaratılışı,1512,2,8 m x 5,7 m",
					Aciklama = "Adem'in Yaratılışı, Sistine Şapeli'nin tavanındaki ünlü bir fresktir Tüm zamanların en çok replikası yapılan dinî resimlerinden biridir.",
					ArtistId = 1, ExhibitionId = 2,
				},
				new Work
				{
					ID=2,
					Kunye="Paula Rego, The Dance, 1988",
					Aciklama= "ay ışığının aydınlattığı bir kumsalda ön planda dans eden sekiz figürün yer aldığı büyük bir tablodur.",
					ArtistId=2, ExhibitionId=1
				}

				);
		}
	}
}
