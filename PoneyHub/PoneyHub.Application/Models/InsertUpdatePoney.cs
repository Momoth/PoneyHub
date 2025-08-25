namespace PoneyHub.Application.Models
{
    public class InsertUpdatePoney
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Coefficient { get; set; }
        public int? CategorieId { get; set; }
    }
}