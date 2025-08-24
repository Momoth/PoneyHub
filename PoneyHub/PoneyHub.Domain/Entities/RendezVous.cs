using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoneyHub.Domain.Entities
{
    public class RendezVous
    {
        public int Id { get; set; }
        public DateTime DateHeureDebut { get; set; }
        public DateTime DateHeureFin { get; set; }
        public decimal MontantFacture { get; set; }
    }
}