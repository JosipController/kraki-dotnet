using System;
using System.ComponentModel.DataAnnotations;

namespace kraki.Models
{
    public class Appointment : BaseModel
    {
        
      public DateTime date {get; set;}
       
       
       [Required(ErrorMessage="Obavezno polje")]
       public int ExaminationId {get; set;}
       
       public Examination Examination {get; set;}
       [Required(ErrorMessage="Obavezno polje")]
       public int DoctorId {get; set;}
       
       public Doctor Doctor {get; set;}
       [Required(ErrorMessage="Obavezno polje")]
       public int HospitalId {get; set;}
       
       public Hospital Hospital {get; set;}
       [Required(ErrorMessage="Obavezno polje")]
       public int PatientId {get; set;}
       
       public Patient Patient {get; set;}


        
    }
}