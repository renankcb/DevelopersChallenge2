using BankReconciliation.Domain.Repositories;
using BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BankReconciliation.Infrastructure.Data.Persistense.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected BankReconciliationContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        protected BaseRepository(BankReconciliationContext dbContext)
        {
            //_dbContext = dbContext;
            //_dbSet = _dbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await this._dbSet.AddAsync(entity);
        }
    }
}
