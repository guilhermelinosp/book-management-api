using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Contexts.Persistence;

public static class ManagementDbContextFactory
{
	public static async Task CreateAsync(string connectionString)
	{
		try
		{
			var optionsBuilder = new DbContextOptionsBuilder<ManagementDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			await using var authenticationDbContext = new ManagementDbContext(optionsBuilder.Options);
			await authenticationDbContext.Database.EnsureCreatedAsync();
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error creating database: {ex.Message}");
			throw;
		}
	}
}