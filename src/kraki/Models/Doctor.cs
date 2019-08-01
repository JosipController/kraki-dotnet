using System.ComponentModel.DataAnnotations;

namespace kraki.Models
{
    public class Doctor : BaseModel
    {
         
         
        [Required(ErrorMessage="Obavezno polje")]
        [StringLength(30,ErrorMessage="Ime ne smije imati više od 30 znakova")]
        public string FirstName {get; set;}
        [Required(ErrorMessage="Obavezno polje")]
        [StringLength(30,ErrorMessage="Prezime ne smije imati više od 30 znakova")]


        public string LastName {get; set;}
        [Required(ErrorMessage="Obavezno polje")]
        [StringLength(13,ErrorMessage="Telefonski broj ne može imati više od 13 znakova")]

    

        public string PhoneNumber {get; set;}
        [Required(ErrorMessage="Obavezno polje")]
        [StringLength(25,ErrorMessage="Email ne može imati više od 25 znakova")]
        
        public string Email {get; set;} }
    }
