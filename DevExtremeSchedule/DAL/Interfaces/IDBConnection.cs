using Microsoft.Data.SqlClient;

namespace DevExtremeSchedule.DAL.Interfaces
{
    public interface IDBConnection
    {
        public SqlConnection CreateConnection();
    }
}
