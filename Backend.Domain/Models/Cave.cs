using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Models
{
    public class Cave : BaseModel
    {
        public List<Bouteille> Bouteilles { get; set; } = new List<Bouteille>();
    }
}
