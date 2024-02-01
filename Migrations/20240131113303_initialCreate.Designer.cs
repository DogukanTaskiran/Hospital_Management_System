﻿// <auto-generated />
using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240131113303_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.ApplicationUser", b =>
                {
                    b.Property<int>("ApplicationUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationUserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationUserID");

                    b.ToTable("User", (string)null);

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            ApplicationUserID = -1,
                            Address = "IYTE Müh F Binası",
                            BloodType = "A",
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2384),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@hospitaladmin.com",
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kerem",
                            Password = "123",
                            PhoneNumber = "5554446677",
                            Role = "Admin",
                            Status = 1,
                            Surname = "mereK"
                        });
                });

            modelBuilder.Entity("Entities.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentID"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AppointmentTime")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("AppointmentID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Entities.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HospitalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("DepartmentID");

                    b.HasIndex("HospitalID");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2343),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Kardiyoloji",
                            HospitalID = 1,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            DepartmentID = 2,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2346),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Nöroloji",
                            HospitalID = 1,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            DepartmentID = 3,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2348),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Dahiliye",
                            HospitalID = 1,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            DepartmentID = 4,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2350),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Göz Hastalıkları",
                            HospitalID = 2,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            DepartmentID = 5,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2351),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Radyoloji",
                            HospitalID = 2,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            DepartmentID = 6,
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2354),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Nöroloji",
                            HospitalID = 2,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        });
                });

            modelBuilder.Entity("Entities.Models.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DiagnosisDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiagnosisDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("diagnoses");
                });

            modelBuilder.Entity("Entities.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HospitalID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("HospitalID");

                    b.ToTable("hospitals");

                    b.HasData(
                        new
                        {
                            HospitalID = 1,
                            Address = "Kemaliye Caddesi , Borno Mahallesi, No:188",
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2225),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HospitalName = "Medical Park",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNum = "123456789",
                            Status = 1
                        },
                        new
                        {
                            HospitalID = 2,
                            Address = "Mahmudiye Caddesi , Yılmaz Mahallesi, No:228",
                            CreatedDate = new DateTime(2024, 1, 31, 14, 33, 2, 712, DateTimeKind.Local).AddTicks(2228),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HospitalName = "Medicana",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNum = "323456789",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Entities.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoicePrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("InvoiceID");

                    b.HasIndex("PatientID");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("Entities.Models.Prescription", b =>
                {
                    b.Property<int>("PrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("prescriptions");
                });

            modelBuilder.Entity("Entities.Models.RadiologicalReport", b =>
                {
                    b.Property<int>("RadiologicalReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RadiologicalReportID"));

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("RrDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RrImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RadiologicalReportID");

                    b.HasIndex("PatientID");

                    b.ToTable("radiologicalReports");
                });

            modelBuilder.Entity("Entities.Models.Report", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<int>("DiagnosisID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("ReportDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportID");

                    b.HasIndex("PatientID");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("Entities.Models.Admin", b =>
                {
                    b.HasBaseType("Entities.Models.ApplicationUser");

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Doctor", b =>
                {
                    b.HasBaseType("Entities.Models.ApplicationUser");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Doctor", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Nurse", b =>
                {
                    b.HasBaseType("Entities.Models.ApplicationUser");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("NurseID")
                        .HasColumnType("int");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Nurse", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Patient", b =>
                {
                    b.HasBaseType("Entities.Models.ApplicationUser");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.ToTable("Patient", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Receptionist", b =>
                {
                    b.HasBaseType("Entities.Models.ApplicationUser");

                    b.Property<int>("RecID")
                        .HasColumnType("int");

                    b.ToTable("Receptionist", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Appointment", b =>
                {
                    b.HasOne("Entities.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entities.Models.Department", b =>
                {
                    b.HasOne("Entities.Models.Hospital", "Hospital")
                        .WithMany("Departments")
                        .HasForeignKey("HospitalID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("Entities.Models.Diagnosis", b =>
                {
                    b.HasOne("Entities.Models.Report", "Reports")
                        .WithOne("Diagnosis")
                        .HasForeignKey("Entities.Models.Diagnosis", "DiagnosisID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Doctor", "Doctor")
                        .WithMany("Diagnoses")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("Diagnoses")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Reports");
                });

            modelBuilder.Entity("Entities.Models.Invoice", b =>
                {
                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("Invoices")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entities.Models.Prescription", b =>
                {
                    b.HasOne("Entities.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entities.Models.RadiologicalReport", b =>
                {
                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("RadiologicalReports")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entities.Models.Report", b =>
                {
                    b.HasOne("Entities.Models.Patient", "Patient")
                        .WithMany("Reports")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entities.Models.Admin", b =>
                {
                    b.HasOne("Entities.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Admin")
                        .HasForeignKey("Entities.Models.Admin", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Entities.Models.Doctor", b =>
                {
                    b.HasOne("Entities.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Doctor")
                        .HasForeignKey("Entities.Models.Doctor", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Department", "Departments")
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Entities.Models.Nurse", b =>
                {
                    b.HasOne("Entities.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Nurse")
                        .HasForeignKey("Entities.Models.Nurse", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Department", "Department")
                        .WithMany("Nurses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Entities.Models.Patient", b =>
                {
                    b.HasOne("Entities.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Patient")
                        .HasForeignKey("Entities.Models.Patient", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Entities.Models.Receptionist", b =>
                {
                    b.HasOne("Entities.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Receptionist")
                        .HasForeignKey("Entities.Models.Receptionist", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Entities.Models.ApplicationUser", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");

                    b.Navigation("Patient");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("Entities.Models.Department", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("Entities.Models.Hospital", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Entities.Models.Report", b =>
                {
                    b.Navigation("Diagnosis")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Diagnoses");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Entities.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Diagnoses");

                    b.Navigation("Invoices");

                    b.Navigation("Prescriptions");

                    b.Navigation("RadiologicalReports");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}