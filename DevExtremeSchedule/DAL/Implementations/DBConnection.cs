using DevExtremeSchedule.DAL.Interfaces;
using Microsoft.Data.SqlClient;

namespace DevExtremeSchedule.DAL.Implementations
{
    public class DBConnection: IDBConnection
    {
        private readonly IConfiguration _configuration;

        public DBConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
