using System;
using Microsoft.EntityFrameworkCore;
using kraki.Models;

namespace kraki.Extensions
{
    public static class Seeds
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Appointments(modelBuilder);
            Cities(modelBuilder);
            Doctors(modelBuilder);
            Examinations(modelBuilder);
            Hospitals(modelBuilder);
            Patients(modelBuilder);
        
        }

        private static void Patients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient()
                {
                    Id=5,
                   FirstName="Ivko",
                   LastName="Ivić",
                   PhoneNumber="098834832",
                   Gender="Male",
                   Email="doktorko@vvg.hr",
                   Birthdate=DateTime.Parse("1999-04-23")
                }
                
            );
        }

        public static void Hospitals(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Hospital>().HasData(
                new Hospital()
                {
                   Id=7,
                   Name="Medvescak",
                   PhoneNumber="01622832",
                   Email="medvescak999@gmail.com",
                   CityId=1 } );
        }
        

        public static void Appointments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment()
                {
                    Id=5,
                    date = DateTime.Parse("2020-04-23"),
                    ExaminationId=3,
                    DoctorId=2,
                    HospitalId=5,
                    PatientId=2
                }
                
            );
        }

        public static void Cities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id=8,
                    Name="Karlovac",
                    Zip= "47000"
                }
            
               
            );
        }

        public static void Doctors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor()
                {
                    Id=9,
                   FirstName="Ivan",
                   LastName="Ivić",
                   PhoneNumber="09883832",
                   Email="doktorko@vvg.hr" }
                
            );
                }
        public static void Examinations(ModelBuilder modelBuilder)
       {
        modelBuilder.Entity<Examination>().HasData(
            new Examination()
            {
                Id=8,
                Type="Routine checkup"}
        );
            }
       }}
    

         
            
       

            
        
