using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ts.DAL.Entities
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string MedicalServicesId { get; set; }
    }
}
