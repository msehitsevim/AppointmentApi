using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ts.DAL.Entities
{
    public class Patient
    {
    
        [Key]
        public Guid Id { get; set; }
        public long IdentityNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
     
    }
}
