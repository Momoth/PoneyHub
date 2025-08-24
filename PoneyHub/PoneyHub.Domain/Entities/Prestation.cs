namespace PoneyHub.Domain.Entities
{
    public class Prestation
    {
        public int Id { get; set; }
        public DateTime DateHeureDebut { get; set; }
        public DateTime DateHeureFin { get; set; }
        public decimal MontantFacture { get; set; }
        public Poney Poney { get; set; }
        public int PoneyId { get; set; }
    }
}