namespace PoneyHub.Domain.Entities
{
    public class Poney
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Coefficient { get; set; }
    }
}