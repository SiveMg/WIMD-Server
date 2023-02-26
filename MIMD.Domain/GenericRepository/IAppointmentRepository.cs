
using WIMD.Domain.SeedWork;

namespace WIMD.Domain.GenericRepository
{
    public interface IAppointmentRepository<TEntity> : IDisposable where TEntity : Entity
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TEntity entity);
        void Delete(TEntity entity);
        void Update(long entityId, TEntity newEntity);
        void Add(TEntity entity);
    }
}
