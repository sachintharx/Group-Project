using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01.DataModels
{
    public class Doctor
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SpecificField { get; set; }

        public int DoctorCharge { get; set; }
      public ObservableCollection<PatientDoctord> doctorPatient { get; set; }
      
        
    }
}
