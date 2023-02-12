using WIMD.Domain.SeedWork;
using WIMD.Infrastructure.Database;
using WIMD.Infrastructure.Processing;

namespace WIMD.Infrastructure.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WIMDContext _wimdContext;
        private readonly IDomainEventsDispatcher _domainEventsDispatcher;

        public UnitOfWork(
            WIMDContext wimdContext,
            IDomainEventsDispatcher domainEventsDispatcher)
        {
            this._wimdContext = wimdContext;
            this._domainEventsDispatcher = domainEventsDispatcher;
        }
        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            await this._domainEventsDispatcher.DispatchEventsAsync();
            return await this._wimdContext.SaveChangesAsync();
        }
    }
}
