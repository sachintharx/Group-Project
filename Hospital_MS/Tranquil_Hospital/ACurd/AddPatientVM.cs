using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hos_01.ACurd
{
    public partial class AddPatientVM : ObservableObject
    {
        [ObservableProperty] public string userName;
        [ObservableProperty] public string password;

        [ObservableProperty]
        public string topic = "Curd Window";


        [ObservableProperty] public bool isuser;
        [ObservableProperty] public bool ispatient;
        [ObservableProperty] public bool isdoctor;
        [ObservableProperty] public bool isrole;
        [ObservableProperty] public Doctor selectedDoctor;
        [ObservableProperty] 
        public Drugs seletedDrug;
        [ObservableProperty]
        public ObservableCollection<Drugs> selectedDrugs;
        [ObservableProperty]
        public ObservableCollection<Doctor> selectedDoctors;

  
        public void LoadDoctor()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbdoctors.ToList();
               SelectedDoctors = new ObservableCollection<Doctor>(list);


            }
        }

        public void LoadDrugs()
        {
            using (var db = new DataContext())
            {
                var list = db.Drugs.ToList();
                SelectedDrugs = new ObservableCollection<Drugs>(list);
            }
        }



        [ObservableProperty]
        public int moNum;
        [ObservableProperty]
        public string longTermDies;
        [ObservableProperty] public int regNo;

        [ObservableProperty] public string specificField;

        [ObservableProperty] public bool isUpdateContent;

       
        public Patient updatePatient { get; set; }



        [RelayCommand]
        public void AddDocToPa()
        {
            if (SelectedDoctor != null)
            {
                using (var db = new DataContext())
                {
                    PatientDoctord pd = new PatientDoctord()
                    {
                        PatientId = RegNo - 1000, 
                        DoctorId = SelectedDoctor.Id
                    };

                    db.patientDoctords.Add(pd);
                    db.SaveChanges();

                    MessageBox.Show("Doctor added to patient successfully", "Message");
                }
            }
        }



        [RelayCommand]
        public void AddDrugsToPa()
        {
            //MessageBox.Show();
            if (SeletedDrug != null)
            {
                using (var db = new DataContext())
                {
                    PatientDrugs pdd = new PatientDrugs()
                    {
                        PatientID = RegNo - 1000,
                        DrugsID = SeletedDrug.Id
                    };

                    db.patientDrugs.Add(pdd); // Use db.Set<PatientDrugs>() instead of db.patientDrugs

                    db.SaveChanges();
                    MessageBox.Show("Drugs added", "Message");
                }
            }
        }

        public AddPatientVM(Patient patient)
        {
            userName = patient.Name;
            isUpdateContent = true;
            moNum = patient.MoNum;
            longTermDies = patient.LongTermDieseas;
            regNo = patient.RegNo;
            updatePatient = patient;
            


        }


   

        public AddPatientVM()
        {
            //isUpdateContent = false;
        }

    



        [RelayCommand]

        public void AddPatient()
        {
            using (var db = new DataContext())
            {
                if (updatePatient == null)
                {
                    Patient patient = new Patient()
                    {
                        Name = userName,
                        RegNo = regNo,
                        MoNum = moNum,
                        LongTermDieseas = longTermDies
                    };

                    if (patient.Name != null)
                    {
                        db.Dbpatients.Add(patient);
                        db.SaveChanges();
                        MessageBox.Show("New patient added", "Message");
                    }
                }
                else
                {
                    Patient p = db.Dbpatients.Find(updatePatient?.Id);
                    if (p != null)
                    {
                        p.Name = userName;
                        p.RegNo = regNo;
                        p.MoNum = moNum;
                        p.LongTermDieseas = longTermDies;
                        db.SaveChanges();
                        MessageBox.Show("Success");
                    }
                }
            }
        }












}
}
