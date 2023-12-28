using MyErp.Business.Interfaces;
using static MyErp.DAL.Models.Models;
using static MyErp.DAL.Program;

namespace MyErp.Business
{
    public class Program
    {
        public class OrderRepository : IRepository<Order>
        {
            public void Create(Order entity)
            {
                ErpDB.Orders.Add(entity);
            }

            public IEnumerable<Order> GetAll()
            {
                return ErpDB.Orders;
            }
        }

        public class CustomerRepository : IRepository<Customer>
        {
            public void Create(Customer entity)
            {
                ErpDB.Customers.Add(entity);
            }

            public IEnumerable<Customer> GetAll()
            {
                return ErpDB.Customers;
            }
        }
    }
}
