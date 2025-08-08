using Intuit.Application.Repository.ModelRepository;
using Intuit.Models;
using Intuit.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Intuit.Persistence.Repository;

public class ClienteRepository(ClienteContext context) : IClienteRepository
{
	public async Task CreateAsync(Cliente entity, CancellationToken cancellationToken)
	{
		await context.AddAsync(entity, cancellationToken);
		await context.SaveChangesAsync(cancellationToken);
	}

	public void Delete(Cliente entity)
	{
		context.Remove(entity);
	}

	public async Task<Cliente?> GetAsync(int id, CancellationToken cancellationToken)
	{
		return await context.Set<Cliente>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
	}

	public async Task<List<Cliente>> GetAllAsync(CancellationToken cancellationToken)
	{
		return await context.Set<Cliente>().ToListAsync(cancellationToken);
	}

	public async Task UpdateAsync(Cliente entity, CancellationToken cancellationToken)
	{
		context.Update(entity);
		await context.SaveChangesAsync(cancellationToken);
	}
}
