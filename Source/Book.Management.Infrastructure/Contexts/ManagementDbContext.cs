using System.Reflection;
using Book.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Contexts
{
	public class ManagementDbContext(DbContextOptions<ManagementDbContext> options) : DbContext(options)
	{
		public DbSet<Domain.Entities.Book>? Books { get; set; }
		public DbSet<User>? Users { get; set; }
		public DbSet<Loan>? Loans { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}