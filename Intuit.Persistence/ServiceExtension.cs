using Intuit.Application.Repository.ModelRepository;
using Intuit.Application.Service;
using Intuit.Persistence.Context;
using Intuit.Persistence.Repository;
using Intuit.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Intuit.Persistence;

public static class ServiceExtension
{
	public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
	{
		var connection = configuration.GetConnectionString("RentalConnection");
		services.AddDbContext<ClienteContext>(options => options.UseSqlServer(connection));
		services.AddScoped<IClienteRepository, ClienteRepository>();
		services.AddScoped<IClienteService, ClienteService>();
	}
}
