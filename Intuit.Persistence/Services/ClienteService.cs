using Intuit.Application.Repository.ModelRepository;
using Intuit.Application.Service;
using Intuit.Models;

namespace Intuit.Persistence.Services;

public class ClienteService(IClienteRepository clienteRepository) : IClienteService
{
	public async Task CreateAsync(Cliente entity, CancellationToken cancellationToken)
	{
		await clienteRepository.CreateAsync(entity, cancellationToken);
	}

	public void Delete(Cliente entity)
	{
		clienteRepository.Delete(entity);
	}

	public async Task<List<Cliente>> GetAllAsync(CancellationToken cancellationToken)
	{
		return await clienteRepository.GetAllAsync(cancellationToken);
	}

	public async Task<Cliente> GetAsync(int id, CancellationToken cancellationToken)
	{
		return await clienteRepository.GetAsync(id, cancellationToken);
	}

	public async Task UpdateAsync(Cliente entity, CancellationToken cancellationToken)
	{
		await clienteRepository.UpdateAsync(entity, cancellationToken);
	}
}
