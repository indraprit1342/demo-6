using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class HomeController : Controller
    {
        // Product list
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Category = "Electronics",
                Price = 55000,
                Quantity = 10,
                Description = "High performance laptop for students and professionals."
            },

            new Product
            {
                ProductId = 2,
                ProductName = "Smartphone",
                Category = "Electronics",
                Price = 25000,
                Quantity = 20,
                Description = "Latest Android smartphone with modern features."
            },

            new Product
            {
                ProductId = 3,
                ProductName = "Headphones",
                Category = "Accessories",
                Price = 2500,
                Quantity = 30,
                Description = "Wireless Bluetooth headphones with clear sound."
            },

            new Product
            {
                ProductId = 4,
                ProductName = "Keyboard",
                Category = "Accessories",
                Price = 1500,
                Quantity = 15,
                Description = "Comfortable USB keyboard for everyday use."
            },

            new Product
            {
                ProductId = 5,
                ProductName = "Mouse",
                Category = "Accessories",
                Price = 800,
                Quantity = 25,
                Description = "Wireless mouse with smooth and accurate tracking."
            },

            new Product
            {
                ProductId = 6,
                ProductName = "Tablet",
                Category = "Electronics",
                Price = 18000,
                Quantity = 12,
                Description = "Lightweight tablet suitable for study and entertainment."
            }
        };

        // Product Catalog
        public ActionResult Index()
        {
            return View(products);
        }

        // Product Details
        public ActionResult Details(int? id)
        {
            // If no ID is provided, go back to Product Catalog
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            // Find product by ID
            var product = products.FirstOrDefault(p => p.ProductId == id.Value);

            // If product does not exist
            if (product == null)
            {
                return HttpNotFound();
            }

            // Send product to Details view
            return View(product);
        }
    }
}
