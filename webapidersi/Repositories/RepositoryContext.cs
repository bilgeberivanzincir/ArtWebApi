using Microsoft.EntityFrameworkCore;
using webapidersi.Models;
using webapidersi.Repositories.Config;

namespace webapidersi.Repositories
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) {
		
		}

        public DbSet<Work> Works{ get; set; }
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<Museum> Museums { get; set; }
		public DbSet<Member> Members { get; set; }
		public DbSet<Exhibition> Exhibitions { get; set; }
		public DbSet<Artist> Artists { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ExhibitionConfig());
			modelBuilder.ApplyConfiguration(new MemberConfig());
			modelBuilder.ApplyConfiguration(new ProfileConfig());
			modelBuilder.ApplyConfiguration(new MuseumConfig());
			modelBuilder.ApplyConfiguration(new WorkConfig());
			modelBuilder.ApplyConfiguration(new ArtistConfig());


			modelBuilder.Entity<Work>()
                .HasOne(w => w.Artist)
                .WithMany(a => a.Works)
				.HasForeignKey(w => w.ArtistId);


			modelBuilder.Entity<Work>()
				.HasOne(w => w.Exhibition)
				.WithMany(e => e.Works)
				.HasForeignKey(e => e.ExhibitionId);

			modelBuilder.Entity<Exhibition>()
				.HasOne(e=>e.Museum)
				.WithMany(m=>m.Exhibitions)
				.HasForeignKey(e=>e.MuseumId);


		}

	}
}
