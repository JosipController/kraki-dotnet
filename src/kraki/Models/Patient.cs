using System;

namespace kraki.Models
{
    public class Patient : BaseModel 
    {
         
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string Gender {get; set;}
        public string Email {get; set;}
        public DateTime Birthdate {get; set;}
    }
}