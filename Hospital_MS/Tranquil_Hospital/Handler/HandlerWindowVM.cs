using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.ACurd;
using Hos_01.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Hos_01.Handler
{
    public partial class HandlerWindowVM : ObservableObject
    {
        public bool IsAdmin { get; set; }

       // public int cons = 1;
       
        [ObservableProperty]
        public string topic;

        [ObservableProperty]
        public ObservableCollection<User> haUsers;

        [ObservableProperty]

        public ObservableCollection<Doctor> haDoctors;

        [ObservableProperty]

        public ObservableCollection<Patient> haPatients;
        [ObservableProperty]
        public ObservableCollection<Drugs> haDrugs;
        public const int adn = 1000;

       // public const int drg = 1;

        public void LoadUsers()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbusers.ToList();
                haUsers = new ObservableCollection<User>(list);


            }
        }
        public void LoadDrugs()
        {
            using (var db = new DataContext())
            {
                var list = db.Drugs.ToList();
                haDrugs = new ObservableCollection<Drugs> (list );
            }
        }
        public void LoadPatient()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbpatients.ToList();
                haPatients = new ObservableCollection<Patient>(list);


            }
        }

        public void LoadDoctors()
        {
            using (var db = new DataContext())
            {

                var list = db.Dbdoctors.ToList();
                haDoctors = new ObservableCollection<Doctor>(list);


            }

        }
        public HandlerWindowVM()
        {
          
        }
        
        [RelayCommand]
         public void AddUser()
         {

            var vm = new AddUserVM();
            
           
            var window = new AddUser(vm);
            window.ShowDialog();

           
         }
      

        [RelayCommand]
        public void AddDoctor()
        {
            var vm = new AddDoctorVM();
            var window = new AddDoctor(vm);
            window.ShowDialog();



        }

        [RelayCommand]

        public void AddPatient()
        {
            var vm = new AddPatientVM();
           
            var window = new AddPatient(vm);

            using (var db = new DataContext())
            {
                int? maxId = db.Dbpatients.OrderByDescending(s => s.Id).FirstOrDefault()?.Id;
                vm.RegNo = adn + 1 + (maxId ?? 0);
            }

            vm.LoadDoctor();
            vm.LoadDrugs();

            window.ShowDialog();



        }

        [RelayCommand]
        public void AddDrugs()
        {
            var vm = new AddDruggVM();
            var window = new AddDrugg(vm);
          

           
          

            window.ShowDialog();
        }

        [RelayCommand]
        public void DisplayUser()
        {
            var vm = new DisplayWindowVM();
            vm.topic= "Display Users";
            LoadUsers();
            vm.isuser = true;
            vm.isdoctor = false;
            vm.ispatient = false;
            vm.isdrugs= false;
            vm.displayUser = haUsers;
            var window=new DisplayWindow(vm);
            window.ShowDialog();
        }
        [RelayCommand]
        public void DisplayDrugs()
        {
            var vm = new DisplayWindowVM();
            vm.topic = "Display Drugs";
            LoadDrugs();
            vm.isuser = false;
            vm.isdoctor = false;
            vm.ispatient = false;
            vm.Isdrugs = true;
            vm.DisplayDrugs = haDrugs;
            var window = new DisplayWindow(vm);
            window.ShowDialog();
        }
        [RelayCommand]
        public void DisplayPatient()
        {
            var vm = new DisplayWindowVM();
            vm.topic = "Dispaly Patient";
            LoadPatient();
            vm.isuser = false;
            vm.isdoctor = false;
            vm.ispatient = true;
            vm.isdrugs= false;
            vm.displayPatient = haPatients;
            var window=new DisplayWindow(vm);
            window.ShowDialog();
        }

        [RelayCommand]
        public void DisplayDoctor()
        { var vm = new DisplayWindowVM();
            vm.topic = "Dis Doc";
            LoadDoctors();
            vm.isuser = false;
            vm.isdoctor = true;
            vm.ispatient = false;
            vm.isdrugs = false;
            vm.displayDoctor = haDoctors;
            var window=new DisplayWindow(vm);
            window.ShowDialog();

        
        
        }
    }
}
