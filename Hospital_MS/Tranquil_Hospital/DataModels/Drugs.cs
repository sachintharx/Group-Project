using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01.DataModels
{
    public  class Drugs
    {
        [Key]
        public int Id { get; set; }

        public int RegNo { get; set; }
        public string Name { get; set; }

        public int Contity { get; set; }
     
        public int Price { get; set; }
        public ObservableCollection<PatientDrugs> drugsPatient { get; set; }
    }
}
