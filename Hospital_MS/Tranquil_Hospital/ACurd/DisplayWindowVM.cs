using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Schema;

namespace Hos_01.ACurd
{
   public partial class DisplayWindowVM: ObservableObject

    {

       
        [ObservableProperty] public string topic;

        [ObservableProperty] public ObservableCollection<User> displayUser;
        [ObservableProperty] public ObservableCollection<Patient> displayPatient;
        [ObservableProperty] public ObservableCollection<Doctor> displayDoctor;
        [ObservableProperty] public ObservableCollection<Drugs> displayDrugs;

        [ObservableProperty] public bool isuser;
        [ObservableProperty] public bool ispatient;
        [ObservableProperty] public bool isdoctor;
        [ObservableProperty] public bool isdrugs;
        [ObservableProperty] public bool isrole;

        [ObservableProperty] public User selecteduser;
        [ObservableProperty] public Patient selectedpatient;
        [ObservableProperty] public Doctor selecteddoctor;
        [ObservableProperty] public Drugs selecteddrugs;


        [ObservableProperty]
        public ObservableCollection<dynamic> list2;

        private void getPatientAndPatientDrugInt()
        {
            using (var dbContext = new DataContext())
            {
                var lsit = (from Drugs in dbContext.Drugs
                            join PatientDrug in dbContext.patientDrugs
                                on Drugs.Id equals PatientDrug.DrugsID
                            select new
                            {
                                Drugs,
                                PatientDrug
                            }).ToList();
                list2 = new ObservableCollection<dynamic>(lsit);

            }
        }
        [ObservableProperty]
        public ObservableCollection<dynamic> list3;
        private void getDoctorToPAtient()
        {
            using (var db = new DataContext())
            {
                var lsit = (from Doctor in db.Dbdoctors
                            join PatientDoctord in db.patientDoctords
                                on Doctor.Id equals PatientDoctord.DoctorId
                            select new
                            {
                                Doctor,
                                PatientDoctord
                            }).ToList();
                list3 = new ObservableCollection<dynamic>(lsit);
                //UpdateDoctor();
                //UpdatePatient();

            }


        }
      

        [RelayCommand]
        public void DeleteUser()
        {
            User user = selecteduser;
            if (selecteduser != null)
            {
                using (var db = new DataContext())
                {
                    db.Dbusers.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("User deleted", "Message");
                    LoadUsers();
                }
            }
        }

        [RelayCommand]
        public void DeletePatient()
        {
            Patient patient= selectedpatient;
            if(selectedpatient!=null)
            {
                using(var db=new DataContext())
                {
                    db.Dbpatients.Remove(patient);
                    db.SaveChanges();
                    MessageBox.Show("User deleted", "Message");
                   LoadPatient();

                }
            }
        }


        [RelayCommand]
        public void DeleteDoctor()
        {
            Doctor doctor = selecteddoctor;
            if (selecteddoctor != null)
            {
                using (var db = new DataContext())
                {
                    db.Dbdoctors.Remove(doctor);
                    db.SaveChanges();
                    MessageBox.Show("User deleted", "Message");
                    LoadDoctor();

                }
            }
        }

        [RelayCommand]
        public void DeleteDrugs()
        {
            Drugs drugs = selecteddrugs;
            if (selecteddrugs != null)
            {
                using (var db = new DataContext())
                {
                    db.Drugs.Remove(drugs);
                    db.SaveChanges();
                    MessageBox.Show(" deleted", "Message");
                    LoadDrugs();
                    var updatedList = (from patient in db.Dbpatients
                                       join patientDoctord in db.patientDoctords
                                       on patient.Id equals patientDoctord.PatientId
                                       select new
                                       {
                                           Patient = patient,
                                           PatientDoctord = patientDoctord
                                       }).ToList();
                    List2.Clear();
                    foreach (var item in updatedList)
                    {
                        List2.Add(item);
                    }

                }
            }
        }


        [RelayCommand]

        public void UpdateDrugs()
        {
            if (Selecteddrugs != null)
            {

                var vm = new AddDruggVM(Selecteddrugs);
                var window = new AddDrugg(vm);
                window.ShowDialog();
                LoadDrugs();
            }
            else
            {
                MessageBox.Show("Select be fore edit");
            }

        }


        [RelayCommand]

        public void UpdateDoctor()
        {
            if(Selecteddoctor !=null)
            {

                var vm = new AddDoctorVM(Selecteddoctor);
                var window = new AddDoctor(vm);
                window.ShowDialog();
                LoadDoctor();
            }
            else
            {
                MessageBox.Show("Select be fore edit");
            }

        }





        [RelayCommand]
        public void UpdateUser()
        {
            if (Selecteduser != null)
            {

                var vm = new AddUserVM(Selecteduser);
                var window = new AddUser(vm);
                window.ShowDialog();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Select be fore edit");
            }
        }

        [RelayCommand]
        public void UpdatePatient()
        {
            if (selectedpatient != null)
            {
                var vm = new AddPatientVM(selectedpatient);
                var window = new AddPatient(vm);
                window.ShowDialog();
                LoadPatient();

               

            }
            else
            {
                MessageBox.Show("Select be fore edit");
            }
        }


        public void LoadUsers()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbusers.ToList();
                DisplayUser = new ObservableCollection<User>(list);


            }
        }
        [RelayCommand]
        public void LoadDrugs()
        {
            using (var db = new DataContext())
            {
                var list = db.Drugs.ToList();
                DisplayDrugs = new ObservableCollection<Drugs> (list);
            }
        }
       
        public void LoadPatient()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbpatients.ToList();
                DisplayPatient = new ObservableCollection<Patient>(list);


            }
         
        }

        [RelayCommand]
        public void LoadDoctor()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbdoctors.ToList();
                DisplayDoctor = new ObservableCollection<Doctor>(list);


            }
        }



        public DisplayWindowVM()
        {
            getPatientAndPatientDrugInt();
            getDoctorToPAtient(); 
        
            //PopulateCombinedList();
        }
    }
}
