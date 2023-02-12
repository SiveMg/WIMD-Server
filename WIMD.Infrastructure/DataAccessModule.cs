using Microsoft.Extensions.DependencyInjection;
using SampleProject.Application.Configuration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIMD.Domain.SeedWork;
using WIMD.Infrastructure.Database;
using WIMD.Infrastructure.Domain;

namespace WIMD.Infrastructure
{
    public class DataAccessModule
    {
        private readonly string _databaseConnectionString;
        public DataAccessModule(string databaseConnectionString)
        {
            this._databaseConnectionString = databaseConnectionString;
        }

        public void Load(IServiceCollection services)
        {
            services.AddScoped<ISqlConnectionFactory>(x => new SqlConnectionFactory(this._databaseConnectionString));
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
        }
    }
}
