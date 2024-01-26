using Book.Management.Application;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var service = builder.Services;

await service.AddApplicationInjection(configuration);
service.AddControllers();
service.AddEndpointsApiExplorer();
service.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
	configuration.AddUserSecrets<Program>();
}
else
{
	app.UseHsts();
}

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();