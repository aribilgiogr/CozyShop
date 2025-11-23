using Core.Abstracts.Bases;
using Core.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class CoffeeBean
    {
        // Başka bir tabloyu anahtar olarak kullanabiliriz: one-2-one bağlantı.
        [Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int? OriginId { get; set; }
        public virtual Origin Origin { get; set; }

        public RoastLevel? RoastLevel { get; set; }
        public ProcessMethod? ProcessMethod { get; set; }
        public string Variety { get; set; }
        public string HarvestYear { get; set; }
        public int? Acidity { get; set; }
        public int? Body { get; set; }
        public int? Sweetness { get; set; }
        public string FlavorNotes { get; set; }
        public string CuppingScore { get; set; }

    }
}
