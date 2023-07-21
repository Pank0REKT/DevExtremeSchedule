using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeSchedule.BL.Interfaces;
using DevExtremeSchedule.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevExtremeSchedule.Controllers
{
    [Route("api/[controller]")]
    public class SchedulerController : Controller
    {
        private readonly IAppointmentBL _appointmentBL;

        public SchedulerController(IAppointmentBL appointmentBL)
        {
            _appointmentBL = appointmentBL;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return new JsonResult(DataSourceLoader.Load(_appointmentBL.GetAllAppointments(), loadOptions));
        }

        [HttpPost]
        public IActionResult Post([FromForm] string values)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Appointment, BL.Models.Appointment>());
            var mapper = new Mapper(config);


            var appointment = new Appointment();
            JsonConvert.PopulateObject(values, appointment);

            _appointmentBL.CreateAppointment(mapper.Map<Models.Appointment, BL.Models.Appointment>(appointment));


            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromForm] int key, [FromForm] string values)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Appointment, BL.Models.Appointment>());
            var mapper = new Mapper(config);

            var appointment = new Models.Appointment();
            JsonConvert.PopulateObject(values, appointment);

            _appointmentBL.UpdateAppointment(key, mapper.Map<Models.Appointment, BL.Models.Appointment>(appointment));

            return Ok();
        }

        [HttpDelete]
        public void Delete([FromForm] int key)
        {
            _appointmentBL.DeleteAppointment(key);
        }
    }
}
