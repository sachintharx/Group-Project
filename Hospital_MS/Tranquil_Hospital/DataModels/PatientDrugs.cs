using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01.DataModels
{
    public  class PatientDrugs
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [ForeignKey("Drugs")]
        public int DrugsID { get; set; }

        public Patient patient { get; set; }

        public Drugs drugs { get; set; }
    }
}


