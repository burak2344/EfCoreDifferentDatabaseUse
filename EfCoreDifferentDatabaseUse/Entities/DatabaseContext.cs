using Microsoft.EntityFrameworkCore;

namespace EfCoreDifferentDatabaseUse.Entities
{
	public class DatabaseContext : DbContext
	{
		protected DatabaseContext()
		{
		}

		public DatabaseContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Album> Albums { get; set; }
	}
}
