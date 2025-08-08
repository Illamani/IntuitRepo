using Intuit.Models;

namespace Intuit.Application.Service;

public interface IClienteService
{
	Task CreateAsync(Cliente entity, CancellationToken cancellationToken);
	void Delete(Cliente entity);
	Task<Cliente> GetAsync(int id, CancellationToken cancellationToken);
	Task<List<Cliente>> GetAllAsync(CancellationToken cancellationToken);
	Task UpdateAsync(Cliente entity, CancellationToken cancellationToken);
}
