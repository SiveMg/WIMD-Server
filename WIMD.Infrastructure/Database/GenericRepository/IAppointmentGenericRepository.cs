
using WIMD.Domain.SeedWork;

namespace WIMD.Infrastructure.Database.GenericRepository
{
    public interface IAppointmentGenericRepository<TEntity> : IDisposable where TEntity : Entity
    {
        IQueryable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Update(long entityId, TEntity newEntity);
        void Add(TEntity entity);
    }
}
