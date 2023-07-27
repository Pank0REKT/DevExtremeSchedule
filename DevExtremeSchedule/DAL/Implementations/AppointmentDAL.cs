using DevExtremeSchedule.DAL.Interfaces;
using DevExtremeSchedule.DAL.Models;
using Dapper;

namespace DevExtremeSchedule.DAL.Implementations
{
    public class AppointmentDAL : IAppointmentDAL
    {
        private readonly IDBConnection _connection;

        public AppointmentDAL(IDBConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Appointment> GetAll() 
        {
            using(var connection = _connection.CreateConnection())
            {
                return connection.Query<Appointment>("select Id,Text,Description,StartDate,EndDate,AllDay from [Appointments]");
            }
        }

        public Appointment Find(int id) 
        {
            using (var connection = _connection.CreateConnection())
            {
                return connection.Query<Appointment>("select Id,Text,Description,StartDate,EndDate,AllDay from [Appointments] where Id = @id ", new {id = id}).FirstOrDefault();
            }
        }

        public void Create(Appointment appointment) 
        {
            using (var connection = _connection.CreateConnection())
            {
                connection.Query<Appointment>("insert into Appointments (Text,Description,StartDate,EndDate,AllDay) values (@text,@description,@startDate,@endDate,@allDay)", 
                    new { text = appointment.Text, description = appointment.Description, startDate = appointment.StartDate, endDate = appointment.EndDate, allDay = appointment.AllDay });
            }
        }

        public void Update(int id,Appointment newAppointment)
        {
            using (var connection = _connection.CreateConnection())
            {
                connection.Query("update [Appointments] set Text = @text, Description = @description, StartDate = @startDate, EndDate = @endDate, AllDay = @allDay where Id = @key ",
                    new { key = id, text = newAppointment.Text, description = newAppointment.Description, startDate = newAppointment.StartDate, endDate = newAppointment.EndDate, allDay = newAppointment.AllDay });
            }
        }

        public void Delete(int id) 
        {
            using (var connection = _connection.CreateConnection())
            {
                connection.Query("delete from [Appointments] where Id = @key ", new { key = id });
            }
        }
    }
}
