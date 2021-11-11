using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Ts.DAL.Entities;
using Ts.DAL;

namespace TrySomeThings.Controllers
{
    [ApiController]
    [Route("api")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private readonly MsSqlRepository<Patient> _PatientRepository;     
        public PatientController(ILogger<PatientController> logger, MsSqlRepository<Patient> PatientRepository)
        {
            _logger = logger;
            _PatientRepository = PatientRepository;
            
        }
        [HttpPost]
        [Route("AddPatient")]
        public string AddPatient(Patient patient)
        {

            try
            {
                patient.Id = Guid.NewGuid();
                var message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
                _PatientRepository.Insert(patient);
                _logger.LogInformation(message);
                return "success";
            }
            catch (Exception) { throw; }
        }
        [HttpGet]
        [Route("DeletePatient")]
        public string DeletePatient(Guid Id)
        {
            try
            {
                _PatientRepository.Delete(x => x.Id == Id);
                return "success";
            }
            catch (Exception)
            {
               
                throw;
            }

        }
        [HttpPost]
        [Route("UpdatePatient")]
        public string UpdatePatient(Patient patient)
        {
            try
            {
                _PatientRepository.Update(patient);
                return "success";
            }
            catch (Exception)
            {  
                throw ;
            }
        }
        [HttpGet]
        [Route("AllPatient")]
        public IEnumerable<Patient> AllPatient(){
            var PatientsList = _PatientRepository.GetAll();
            return PatientsList;
        }
        [HttpGet]
        [Route("GetPatient")]
        public Patient GetPatient(long IdentityNo) {
            var result = _PatientRepository.Get(g=>g.IdentityNo == IdentityNo);
            if (result != null)
            {
                return result;
            }
            else
            {
                //null veri koşulu yaz
                return result;
            }
            
        }
        [HttpGet]
        [Route("GetPatientList")]
        public IEnumerable<Patient> GetPatientList(long Identityno) {
            var resultList = _PatientRepository.GetList(l => l.IdentityNo == Identityno);
            return resultList;
        }    
    }
}
