using Microsoft.EntityFrameworkCore;
using WIMD.Domain.SeedWork;

namespace WIMD.Infrastructure.Database.GenericRepository
{
    public class AppointmentGenericRepository<TEntity> : IAppointmentGenericRepository<TEntity> where TEntity : Entity, new()
    {
        private WIMDContext _context;
        public AppointmentGenericRepository(WIMDContext context)
        {
            this._context = context;
        }
        private DbSet<TEntity> DbSet
        {
            get
            {
                return this._context.Set<TEntity>();
            }
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
            this._context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            this.DbSet.Remove(entity);
            this._context.SaveChanges();
        }
        
        public IQueryable<TEntity> GetAll()
        {
            return this.DbSet.AsQueryable();
        }

        public void Update(long entityId, TEntity newEntity)
        {
            var ent = DbSet.Find(entityId);
            this._context.Entry(ent).CurrentValues.SetValues(newEntity);
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this._context != null)
                {
                    this._context.Dispose();
                    this._context = null;
                }
            }
        }
    }
}
