 using Hos_01.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hos_01
{
    public class DataContext : DbContext
    {
        public DbSet<User> Dbusers { get; set; }

        public DbSet<Patient> Dbpatients { get; set; }

        public DbSet<Doctor> Dbdoctors { get; set; }

        public DbSet<PatientDoctord> patientDoctords { get; set; }

        public DbSet<PatientDrugs> patientDrugs { get; set; }

        public DbSet<Drugs> Drugs { get; set; }
     
        private readonly string _path = @"C:\Users\Asus\Downloads\Hospital_Management_System\Tranquil_Care_Hospital\Tranquil Database F\dbhmst.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={_path}");
    }
}
