using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
