using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
    public class Order
    {
        public int OrderId { get; set; }        
        public Customer Customer { get; set; }
        public List<OrderDetails> Details { get; set; }
        public bool Paid { get; set; }
    }
}
