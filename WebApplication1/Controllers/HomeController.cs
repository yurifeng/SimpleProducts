using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 添加Product
        /// </summary>
        private readonly Product _myProduct = new Product()
        {
            ProductId = 1,
            Name = "Micheal Jackson",
            Description = "He is the best popular music singer in the world.",
            Price = 12000,
            Category = "American",
        };

        /// <summary>
        /// 添加动作
        /// localhost:12306/Home/index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(_myProduct);
        }

        /// <summary>
        /// 添加动作
        /// localhost:12306/Home/NameAndPrice
        /// </summary>
        /// <returns></returns>
        public ActionResult NameAndPrice()
        {
            return View(_myProduct);
        }

        /// <summary>
        /// 添加动作
        /// localhost:12306/Home/DemoExpressions
        /// </summary>
        /// <returns></returns>
        public ActionResult DemoExpressions()
        {
            ViewBag.ProductCount = 0;
            ViewBag.ExpressShip = false;
            ViewBag.ApplyDiscount = true;
            ViewBag.Supplier = null;
            return View(_myProduct);
        }

        /// <summary>
        /// 添加Action
        /// localhost:12306/Home/DemoArray
        /// </summary>
        /// <returns></returns>
        public ActionResult DemoArray()
        {
            Product[] arr =
            {
                new Product{Name="yty",Price=250},
                new Product{Name="livir",Price=270},
                new Product{Name="jsd",Price=180},
                new Product{Name="livir",Price=280}
            };

            return View(arr);
        }
    }
}