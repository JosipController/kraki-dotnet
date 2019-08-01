using System.ComponentModel.DataAnnotations;

namespace kraki.Models
{
    public class City : BaseModel
    {
        

        [Required(ErrorMessage="Obavezno polje")]
        [StringLength(30,ErrorMessage="Ime ne smije imati više od 30 znakova")]

        public string Name {get; set;}

        [Required(ErrorMessage="Obavezno polje")]
        
        public string Zip {get; set;}
        
    }
}