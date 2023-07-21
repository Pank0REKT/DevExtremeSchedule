using DevExtremeSchedule.DAL.Interfaces;
using Microsoft.Data.SqlClient;

namespace DevExtremeSchedule.DAL.Implementations
{
    public class DBConnection: IDBConnection
    {
        private readonly IConfiguration configuration;

        public DBConnection(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
