namespace PoneyHub.Application.Models
{
    public class GetPoney
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Coefficient { get; set; }
        public string? Categorie { get; set; }
        public List<GetPrestation> Prestations { get; set; }
    }
}