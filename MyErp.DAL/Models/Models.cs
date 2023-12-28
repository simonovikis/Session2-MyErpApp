using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyErp.DAL.Models
{
    public class Models
    {
        public class Order
        {
            public int OrderId { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
