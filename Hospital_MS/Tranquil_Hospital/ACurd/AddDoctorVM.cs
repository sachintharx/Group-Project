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

namespace Hos_01.ACurd
{
    public partial class AddDoctorVM : ObservableObject

    {

        [ObservableProperty] public string userName;
        
        [ObservableProperty]
        public string topic = "Curd Window";

        [ObservableProperty]
        public int moNum;
        [ObservableProperty]
        public string longTermDies;
        [ObservableProperty] public int regNo;



        [ObservableProperty] public string specificField;
        [ObservableProperty] public int doctorCharge;

        [ObservableProperty] public bool isUpdateContent;

        public Doctor updateDoctor { get; set; }

        

      


        public AddDoctorVM(Doctor doctor)
        {
            userName = doctor.Name;
            isUpdateContent = true;
            specificField = doctor.SpecificField;
            doctorCharge= doctor.DoctorCharge;
            updateDoctor = doctor;


        }


        public AddDoctorVM()
        {
           
        }

        

        [RelayCommand]

        public void AddDoctor()
        {
            using (var db = new DataContext())
            {
                if (updateDoctor == null)
                {
                    Doctor doctor = new Doctor()
                    {
                        Name = userName,
                        SpecificField = specificField,
                        DoctorCharge= doctorCharge

                    };

                    if (doctor.Name != null)
                    {
                        db.Dbdoctors.Add(doctor);
                        db.SaveChanges();
                        MessageBox.Show("New Doctor added", "Message");
                    }
                }
                else
                {
                    Doctor p = db.Dbdoctors.Find(updateDoctor.Id);
                    if (p != null)
                    {
                        p.Name = userName;
                        p.SpecificField = specificField;
                        p.DoctorCharge = doctorCharge;
                        db.SaveChanges();
                        MessageBox.Show("Success");
                    }
                }
            }
        }






}
}
