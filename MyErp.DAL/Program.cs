using static MyErp.DAL.Models.Models;

namespace MyErp.DAL
{
    public class Program
    {
        public static class ErpDB
        {
            public static List<Order> Orders { get; private set; }
            public static List<Customer> Customers { get; private set; }

            static ErpDB()
            {
                Orders = new List<Order>();
                Customers = new List<Customer>();
            }
        }
    }
}
