using Backend.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Models
{
    public class Bouteille : BaseModel
    {
        public string Nom { get; set; } = String.Empty;
        public Couleur Couleur { get; set; } = Couleur.Blanc;
        public Pays Pays { get; set; } = Pays.Italie;
        public DateTime? DateAchat { get; set; } = null;
        public DateTime AnneeMaxPourLaBoire { get; set; } = DateTime.Now;

        public Cave Cave { get; set; } = null!;
    }
}
