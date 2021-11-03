using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ts.DAL.Entities;

namespace Ts.DAL
{
    public class MsDbContext :DbContext
    {
        public MsDbContext(DbContextOptions options): base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
