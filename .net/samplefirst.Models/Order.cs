using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplefirst.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public String OrderStatus { get; set; }
        public String PaymentStatus { get; set; }
    }
}
