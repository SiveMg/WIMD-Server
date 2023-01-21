using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMD.Infrastructure
{
    public class DataAccessModule
    {
        private readonly string _databaseConnectionString;
        public DataAccessModule(string databaseConnectionString)
        {
            _databaseConnectionString = databaseConnectionString;
        }

        public void Load(IServiceCollection serviceProvider)
        {
            service
        }
    }
}
