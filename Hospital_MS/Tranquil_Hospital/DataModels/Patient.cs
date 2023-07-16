using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01.DataModels
{
    public class Patient
    {

        [Key]
        public int Id { get; set; }

        
        
        public int RegNo { get; set; }
        public string Name { get; set; }

        public int MoNum { get; set; }

        public string  LongTermDieseas { get; set; }
        public ObservableCollection<Doctor> PatientDoctors { get; set; }

       
        ObservableCollection<PatientDoctord> addDoctor =new ObservableCollection<PatientDoctord>();

        public ObservableCollection<Drugs> PatientDrugs { get; set; }
        
        ObservableCollection<PatientDrugs> addDrugs=new ObservableCollection<PatientDrugs>();

        
        public void AddDoctorto()
        {
            using (var db= new DataContext())
            {
                var list = db.patientDoctords.ToList();

                ObservableCollection<PatientDoctord> Doctors= new ObservableCollection<PatientDoctord>(list);
                foreach (var dp in Doctors)

                {
                    if(dp.PatientId==Id)
                    {
                        addDoctor.Add(dp);
                    }

                }
            }
           
        }

        public void AddDrugsto()
        {
            using(var db=new DataContext())
            {
                var list=db.patientDrugs.ToList();

                ObservableCollection<PatientDrugs> drugs= new ObservableCollection<PatientDrugs>(list);
                foreach(var dp in drugs)
                {
                    if(dp.PatientID==Id)
                    { addDrugs.Add(dp);  }
                }
            }
        }



    }
}
