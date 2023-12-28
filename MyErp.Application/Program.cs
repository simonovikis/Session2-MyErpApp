using static MyErp.Business.Program;
using static MyErp.DAL.Models.Models;

namespace MyErp.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderRepository orderRepository = new OrderRepository();
            CustomerRepository customerRepository = new CustomerRepository();

            // Creating and saving 5 new orders
            for (int i = 1; i <= 5; i++)
            {
                Order newOrder = new Order
                {
                    OrderId = i,
                    OrderDate = DateTime.Now.AddDays(i),
                    TotalAmount = i * 100 // Sample total amount
                    // You can set other properties as needed
                };
                orderRepository.Create(newOrder);
            }

            // Creating and saving 5 new customers
            for (int i = 1; i <= 5; i++)
            {
                Customer newCustomer = new Customer
                {
                    CustomerId = i,
                    Name = $"Customer {i}",
                    Email = $"customer{i}@example.com"
                    // You can set other properties as needed
                };
                customerRepository.Create(newCustomer);
            }

            // Retrieve all orders and customers
            var allOrders = orderRepository.GetAll();
            var allCustomers = customerRepository.GetAll();

            // Printing the first order and first customer
            var printService = new PrintService.PrintService();
            if (allOrders.Count() > 0)
            {
                var firstOrder = allOrders.First();
                printService.Print(firstOrder);
            }

            if (allCustomers.Count() > 0)
            {
                var firstCustomer = allCustomers.First();
                printService.Print(firstCustomer);
            }
        }
    }
}
