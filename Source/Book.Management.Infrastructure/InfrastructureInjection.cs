using Book.Management.Domain.Repositories;
using Book.Management.Infrastructure.Contexts;
using Book.Management.Infrastructure.Contexts.Persistence;
using Book.Management.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Book.Management.Infrastructure;

public static class InfrastructureInjection
{
	public static async Task AddInfrastructureInjection(this IServiceCollection services, IConfiguration configuration)
	{
		await services.AddContexts(configuration);
		services.AddRepositories();
	}

	private static void AddRepositories(this IServiceCollection services)
	{
		services.AddScoped<IBookRepository, BookRepository>();
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<ILoanRepository, LoanRepository>();
	}

	private static async Task AddContexts(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ManagementDbContext>(options =>
			options.UseSqlServer(configuration["ConnectionStrings:SqlServer"],
				sqlServerOptions => { sqlServerOptions.EnableRetryOnFailure(); }));

		await ManagementDbContextFactory.CreateAsync(configuration["ConnectionStrings:SqlServer"]!);
	}
}