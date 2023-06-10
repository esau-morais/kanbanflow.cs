using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanFlow.Helpers
{
    public class dbs
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["KanbanFlow.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
