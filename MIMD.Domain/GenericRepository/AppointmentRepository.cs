using WIMD.Domain.SeedWork;

namespace WIMD.Domain.GenericRepository
{
    public class AppointmentRepository<TEntity> : IAppointmentRepository<TEntity> where TEntity : Entity, new()
    {
        public AppointmentRepository()
        {

        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(long entityId, TEntity newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
