using System.Threading.Tasks;

namespace BankReconciliation.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
    }
}
