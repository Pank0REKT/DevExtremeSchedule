using DevExtremeSchedule.BL.Interfaces;
using DevExtremeSchedule.BL.Models;
using DevExtremeSchedule.DAL.Interfaces;
using AutoMapper;

namespace DevExtremeSchedule.BL.Implementations
{
    /// <summary>
    /// Так как в данном проекте не предусмотрена бизнес-логика, я обернул методы DAL в методы BL и добавил DI
    /// </summary>
    public class AppointmentBL : IAppointmentBL
    {
        private readonly IAppointmentDAL _appointmentDAL;

        public AppointmentBL(IAppointmentDAL appointmentDAL) 
        {
            _appointmentDAL = appointmentDAL;
        }

        public void CreateAppointment(Appointment appointment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BL.Models.Appointment, DAL.Models.Appointment>());
            var mapper = new Mapper(config);

            _appointmentDAL.Create(mapper.Map<BL.Models.Appointment, DAL.Models.Appointment>(appointment));
        }

        public void DeleteAppointment(int id)
        {
            _appointmentDAL.Delete(id);
        }

        public Appointment FindAppointment(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.Appointment, BL.Models.Appointment>());
            var mapper = new Mapper(config);

            return mapper.Map<DAL.Models.Appointment, BL.Models.Appointment>(_appointmentDAL.Find(id));
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.Appointment, BL.Models.Appointment>());
            var mapper = new Mapper(config);

            return mapper.Map<IEnumerable<DAL.Models.Appointment>, IEnumerable<Models.Appointment>>(_appointmentDAL.GetAll());
        }

        public void UpdateAppointment(int id, Appointment newAppointment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BL.Models.Appointment, DAL.Models.Appointment>());
            var mapper = new Mapper(config);

            _appointmentDAL.Update(id, mapper.Map<BL.Models.Appointment,DAL.Models.Appointment>(newAppointment));
        }
    }
}
