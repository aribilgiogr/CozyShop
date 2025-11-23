using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Origin : BaseEntity
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Farm { get; set; }
        public string Altitude { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<CoffeeBean> Beans { get; set; }
    }
}
