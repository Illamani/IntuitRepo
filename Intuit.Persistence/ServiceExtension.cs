using Intuit.Persistence.Context;
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
	}
}
