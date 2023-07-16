using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hos_01.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hos_01.ACurd
{
    public partial class AddDruggVM:ObservableObject
    {

        [ObservableProperty] public string name;
        [ObservableProperty] public int contity;
        [ObservableProperty] public int regNo;
        [ObservableProperty] public int price;
        public Drugs updateDrugs { get; set; }

        public AddDruggVM() { }

        public AddDruggVM(Drugs drugs)
        {
            name = drugs.Name;
            contity = drugs.Contity;
            regNo = drugs.RegNo;
            price = drugs.Price;
            updateDrugs = drugs;
        }
       
        
        [RelayCommand]

        public void AddDrugs()
        {
            using (var db = new DataContext())
            {
                if (updateDrugs == null)
                {
                    Drugs drugs= new Drugs()
                    {
                        Name = name,
                        Contity = contity,
                        RegNo = regNo,
                        Price = price
                    };

                    if (drugs.Name != null)
                    {
                        db.Drugs.Add(drugs);
                        db.SaveChanges();
                        MessageBox.Show("New Drugs added", "Message");
                    }
                }
                else
                {
                    Drugs d = db.Drugs.Find(updateDrugs.Id);
                    if (d != null)
                    {
                        d.Name = name;
                        d.Contity = contity;
                        d.RegNo = regNo;
                        d.Price = price;
                        db.SaveChanges();
                        MessageBox.Show("Success");
                    }
                }
            }
        }

    }
}
