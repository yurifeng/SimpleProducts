using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Product _myProduct = new Product()
        {
            ProductId = 1,
            Name = "Micheal Jackson",
            Description = "He is the best popular music singer in the world.",
            Price = 12000,
            Category = "American",
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(_myProduct);
        }
    }
}