using Book.Management.Application.Commands.Book.CreateBook;
using Book.Management.Application.Validators.User;
using Book.Management.Infrastructure;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Book.Management.Application;

public static class ApplicationInjection
{
	public static async Task AddApplicationInjection(this IServiceCollection services, IConfiguration configuration)
	{
		await services.AddInfrastructureInjection(configuration);
		services.AddFluentValidation();
		services.AddMediatR();
	}

	private static void AddFluentValidation(this IServiceCollection services)
	{
		services
			.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>()
			.AddFluentValidationAutoValidation()
			.AddFluentValidationClientsideAdapters();
	}

	private static void AddMediatR(this IServiceCollection services)
	{
		services.AddMediatR(op => op.RegisterServicesFromAssemblyContaining(typeof(CreateBookCommand)));
	}
}