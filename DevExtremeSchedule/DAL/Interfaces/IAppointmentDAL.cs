using DevExtremeSchedule.DAL.Models;

namespace DevExtremeSchedule.DAL.Interfaces
{
    public interface IAppointmentDAL
    {
        IEnumerable<Appointment> GetAll();
        Appointment Find(int id);
        void Create(Appointment appointment);
        void Update(int id, Appointment newAppointment);
        void Delete(int id);
    }
}
