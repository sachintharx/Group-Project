using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01.DataModels
{
    public  class PatientDoctord
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey ("Doctor")]
        public int DoctorId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set;}

        

        public Patient patient { get; set; }
        public Doctor doctor { get; set; }

    }
}
