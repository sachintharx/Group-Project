using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hos_01.ACurd
{
    public partial class AddUserVM : ObservableObject
    {
        [ObservableProperty] public string userName;
        [ObservableProperty] public string password;
        [ObservableProperty] public bool isRole;

        [ObservableProperty] public string title = "dfgdf";

        [ObservableProperty] public bool isUser;
        [ObservableProperty] public bool isstudent;
        [ObservableProperty] public bool ismodule;


        [ObservableProperty] public string email;
        [ObservableProperty] public int regNoint;
       

      

        [ObservableProperty] public bool isUpdateMenu;

         public User updateuser {get ; set; }
       
        [ObservableProperty] public int mark;



        public AddUserVM(User user)
        {
            userName = user.UserName;
            password = user.Password;
            if (user.Role == "admin")
            {
                isRole = true;
            }
            isUpdateMenu = true;
            updateuser = user;
        }
      
       

        public AddUserVM()
        {
            //isUpdateMenu = false;
        }

     
        [RelayCommand]
        public void AddUser()
        {
            if (updateuser == null)
            {
                if (userName != null)
                {
                    User user = new User()
                    {
                        UserName = userName,

                        Password = password

                    };
                    if (isRole)
                    {
                        user.Role = "admin";
                    }
                    else
                    {
                        user.Role = "regular";
                    }
                    using (var db = new DataContext())
                    {
                        db.Dbusers.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("new user added", "message");

                    }


                }
            }
            else
            {
                using (var db = new DataContext())
                {
                    User u = db.Dbusers.Find(updateuser.Id);
                    u.UserName = userName;
                    u.Password = password;
                    if (isRole)
                    {
                        u.Role = "admin";
                    }
                    else
                    {
                        u.Role = "regular";
                    }
                    db.SaveChanges();
                    MessageBox.Show("user updated", "message");

                }
            }

        }







    }



    }






