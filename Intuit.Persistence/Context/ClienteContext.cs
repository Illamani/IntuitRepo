using Intuit.Models;
using Microsoft.EntityFrameworkCore;

namespace Intuit.Persistence.Context;

public class ClienteContext : DbContext
{
	public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
	{
	}

	DbSet<Cliente> Clientes { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Cliente>().ToTable("Cliente"); 
	}
}
