using Ders43_Core_Northwind_Select.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ders43_Core_Northwind_Select.Controllers
{
    public class HomeController : Controller
    {
      NorthwindContext context= new NorthwindContext();
        public IActionResult Index()
        {
            //FORMÜL
            //string isim="özgür
            //değişken tipi(string),değişkenin adı(isim)=değeri(özgür)
            List<Product>products= context.Products.ToList();
            return View(products);
        }

        public IActionResult Index2() 
        {
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }


        public IActionResult Hakkimizda() 
        {
            return View();
        }

        public IActionResult Iletisim() 
        {
            List<Product> products = context.Products.ToList();
            return View(products);
            
        }
       
        [HttpGet]

        public IActionResult DiscountedPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DiscountedPage(Product product)
        {
             return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}