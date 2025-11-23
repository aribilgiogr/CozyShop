using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<CartItem> Items { get; set; } = new HashSet<CartItem>();
    }
}
