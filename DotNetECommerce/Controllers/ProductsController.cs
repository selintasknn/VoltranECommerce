using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DotNetECommerce.Models;
using DotNetECommerce.ViewModels;

namespace DotNetECommerce.Controllers
{
    public class ProductsController : Controller
    {
        private ECommerceDBContext db = new ECommerceDBContext();

        // GET: Products
        public ActionResult Index(string search_text)
        {
            var categories = db.Category.ToList();
            var products = db.Product.ToList();

            if (Request.QueryString["cat"] != null)
            {
                if (int.Parse(Request.QueryString["cat"]) != 0)
                {
                    var cat = int.Parse(Request.QueryString["cat"]);
                    products = db.Product.Where(c => c.Category.Id.Equals(cat)).ToList();
                }
            }

            if (search_text != null)
            {
                products = db.Product.Where(c => c.Name.Contains(search_text)).ToList();
            }
            
            var viewModel = new CategoryProductViewModel
            {
                Categories = categories,
                Products = products
            };

            return View(viewModel);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult Cart()
        {
            return View(db.Cart.ToList());
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            Cart item = db.Cart.Where(c => c.Product.Id == id).FirstOrDefault();
            if (item == null)
            {
                Product product = db.Product.Find(id);
                Cart newItem = new Cart { Product = product, Quantity = quantity };
                db.Cart.Add(newItem);
            }
            else
            {
                item.Quantity += quantity;
            }
            db.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpPost]
        public ActionResult UpdateCart(int id, int quantity)
        {
            Cart item = db.Cart.Find(id);
            item.Quantity = quantity;
            db.SaveChanges();
            return RedirectToAction("Cart");
        }

        public ActionResult RemoveFromCart(int id)
        {
            Cart item = db.Cart.Find(id);
            db.Cart.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Cart");
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
