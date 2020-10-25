using System.Threading.Tasks;

namespace BankReconciliation.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();

        void Rollback();
    }
}
