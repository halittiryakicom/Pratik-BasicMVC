using Microsoft.AspNetCore.Mvc;
using Pratik_BasicMVC.Models;

namespace Pratik_BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        //Burada action oluşturarak içerisinde nesneler türettim ve bunları view()'e gönderdim.
        public IActionResult Index()
        {
            Customer customer = new Customer()
            {
                id = 1,
                FirstName = "Test",
                LastName = "Test",
                Email = "Test@gmail.com",
            };

            Order product1 = new Order()
            {
                id = 1,
                ProductName = "laptop",
                Price = 400,
                Quantity=3
            };

            Order product2 = new Order()
            {
                id = 2,
                ProductName = "Telefon",
                Price = 200,
                Quantity = 1
            };

            Order product3 = new Order()
            {
                id = 3,
                ProductName = "Mouse",
                Price = 10,
                Quantity = 50
            };

            CustomerOrderViewModel viewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = new List<Order>
                {
                    product1,
                    product2,
                    product3
                }
            };

            return View(viewModel);
        }

    }
}
