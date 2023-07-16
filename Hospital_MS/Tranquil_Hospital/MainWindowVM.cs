 using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hos_01
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string userName="admin";
        [ObservableProperty]
        public string password="admin";


        [RelayCommand]
        public void Login()
        {
            if (userName != null)
            {

                using (var db = new DataContext())
                {

                    bool userfound = db.Dbusers.Any(usr => usr.UserName == userName && usr.Password == password);

                    if (userfound)
                    {
                        bool isUserAdmin = db.Dbusers.Any(usr => usr.UserName == userName && usr.Password == password && usr.Role == "admin");

                        var vm = new HandlerWindowVM();
                        vm.IsAdmin = isUserAdmin;
                        if (isUserAdmin)
                        {
                            vm.topic = "Admin User";
                        }
                        else { vm.topic = "Reguler User"; }


                        var window = new HandlerWindow(vm);
                        window.ShowDialog();
                        window.Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("User name or password was incorrect", "Warning");
                    }


                }


            }
        }
    }
}
