using Intuit.Models.Common;

namespace Intuit.Application;

public interface IBaseRepository<T> where T : BaseEntity
{
	Task CreateAsync(T entity, CancellationToken cancellationToken);

	Task UpdateAsync(T entity, CancellationToken cancellationToken);

	void Delete(T entity);

	Task<T> GetAsync(int id, CancellationToken cancellationToken);

	Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
}
