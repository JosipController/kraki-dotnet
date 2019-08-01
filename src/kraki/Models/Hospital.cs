namespace kraki.Models
{
    public class Hospital : BaseModel
    {
         
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public int CityId {get; set;}
        public City City {get; set;} }

    }
