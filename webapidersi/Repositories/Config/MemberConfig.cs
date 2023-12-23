using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapidersi.Models;

namespace webapidersi.Repositories.Config
{
	public class MemberConfig : IEntityTypeConfiguration<Member>
	{
		public void Configure(EntityTypeBuilder<Member> builder)
		{
			builder.HasData(
				new Member { ID = 1, Name = "Bilge Berivan ", Surname = "Zincir", Email = "zincirberivan@gmail.com", Password = 147414, ProfileId=1},
				new Member { ID = 2, Name = "Derin", Surname = "Çağdaş", Email = "derincagdas@gmail.com", Password = 150707,ProfileId = 2});
		}
	}
}
