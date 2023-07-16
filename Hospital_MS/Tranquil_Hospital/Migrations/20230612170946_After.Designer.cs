﻿// <auto-generated />
using System;
using Hos_01;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hos_01.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230612170946_After")]
    partial class After
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Hos_01.DataModels.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SpecificField")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Dbdoctors");
                });

            modelBuilder.Entity("Hos_01.DataModels.Drugs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Contity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RegNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("Hos_01.DataModels.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LongTermDieseas")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MoNum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RegNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Dbpatients");
                });

            modelBuilder.Entity("Hos_01.DataModels.PatientDoctord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("patientDoctords");
                });

            modelBuilder.Entity("Hos_01.DataModels.PatientDrugs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DrugsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DrugsID");

                    b.HasIndex("PatientID");

                    b.ToTable("patientDrugs");
                });

            modelBuilder.Entity("Hos_01.DataModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dbusers");
                });

            modelBuilder.Entity("Hos_01.DataModels.Doctor", b =>
                {
                    b.HasOne("Hos_01.DataModels.Patient", null)
                        .WithMany("PatientDoctors")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Hos_01.DataModels.Drugs", b =>
                {
                    b.HasOne("Hos_01.DataModels.Patient", null)
                        .WithMany("PatientDrugs")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Hos_01.DataModels.PatientDoctord", b =>
                {
                    b.HasOne("Hos_01.DataModels.Doctor", "doctor")
                        .WithMany("doctorPatient")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hos_01.DataModels.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hos_01.DataModels.PatientDrugs", b =>
                {
                    b.HasOne("Hos_01.DataModels.Drugs", "drugs")
                        .WithMany("drugsPatient")
                        .HasForeignKey("DrugsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hos_01.DataModels.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drugs");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hos_01.DataModels.Doctor", b =>
                {
                    b.Navigation("doctorPatient");
                });

            modelBuilder.Entity("Hos_01.DataModels.Drugs", b =>
                {
                    b.Navigation("drugsPatient");
                });

            modelBuilder.Entity("Hos_01.DataModels.Patient", b =>
                {
                    b.Navigation("PatientDoctors");

                    b.Navigation("PatientDrugs");
                });
#pragma warning restore 612, 618
        }
    }
}
