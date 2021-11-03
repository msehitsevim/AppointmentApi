using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ts.DAL;
using Ts.DAL.Entities;

namespace TrySomeThings.Controllers
{
    [ApiController]
    [Route("Appointment")]
    public class AppointmentController : ControllerBase
    {
        private readonly MsSqlRepository<Appointment> _AppointmentRepository;
        public AppointmentController(MsSqlRepository<Appointment> AppointmentRepository)
        {
            _AppointmentRepository = AppointmentRepository;
        }
        [HttpPost]
        [Route("AddAppointment")]
        public string AddAppointment(Appointment appointment)
        {

            try
            {
                appointment.Id = Guid.NewGuid();
               
                _AppointmentRepository.Insert(appointment);
               
                return "success";
            }
            catch (Exception) { throw; }
        }
        [HttpGet]
        [Route("DeleteAppointment")]
        public string DeleteAppointment(Guid Id)
        {
            try
            {
                _AppointmentRepository.Delete(d=>d.Id == Id);
                return "success";
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        [Route("UpdateAppointment")]
        public string UpdateAppointment(Appointment appointment)
        {
            try
            {
                _AppointmentRepository.Update(appointment);
                return "success";
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("AllAppointment")]
        public IEnumerable<Appointment> AllAppointment()
        {
            var AppointmentList = _AppointmentRepository.GetAll();
            return AppointmentList;
        }
        [HttpGet]
        [Route("GetAppointment")]
        public Appointment GetAppointment(Guid Id)
        {
            var result = _AppointmentRepository.Get(g => g.Id == Id);
            return result;
        }
        [HttpGet]
        [Route("GetAppointmentList")]
        public IEnumerable<Appointment> GetAppointmentList(Guid Id)
        {
            var resultList = _AppointmentRepository.GetList(l => l.Id == Id);
            return resultList;
        }
    }
}
