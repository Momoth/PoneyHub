namespace PoneyHub.Application.Models
{
    public class GetPrestation
    {
        public int Id { get; set; }
        public DateTime DateHeureDebut { get; set; }
        public DateTime DateHeureFin { get; set; }
        public decimal MontantFacture { get; set; }
    }
}