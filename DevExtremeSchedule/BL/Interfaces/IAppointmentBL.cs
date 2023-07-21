using DevExtremeSchedule.BL.Models;

namespace DevExtremeSchedule.BL.Interfaces
{
    public interface IAppointmentBL
    {
        IEnumerable<Appointment> GetAllAppointments();
        Appointment FindAppointment(int id);
        void CreateAppointment(Appointment appointment);
        void UpdateAppointment(int id, Appointment newAppointment);
        void DeleteAppointment(int id);
    }
}
