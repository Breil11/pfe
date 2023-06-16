namespace APIExposant.Models
{
    public class Visiteur
    {
        public int IdVisiteur { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string? ZipCode { get; set; }
        public string? City { get; set; }

        public string? Interest { get; set; }
    }
}
