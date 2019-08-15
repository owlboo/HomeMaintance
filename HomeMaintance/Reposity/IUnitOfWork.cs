using System.Threading.Tasks;

namespace HomeMaintance.Reposity
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;

        Task<int> Commit();

        void Rollback();
    }
}