namespace MvcBinding.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using MvcBinding.Models;
    using System.Net;
    using System.Web.Security;

    //using MvcBinding.Models;
    [Authorize]
    public class ProductsController : Controller
    {
        ProductsContext _context = new ProductsContext();
        DataSource db = new DataSource();
        [AllowAnonymous]
        public ViewResult Index()
        {
            return View(_context.productsTable.ToList());
        }

        //[Authorize(Users = "Abhay")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product Id is Required!");
            }
            Product product = _context.productsTable.Find(id);
            if(product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product Not Found!");
            }
            return View(product);
        }
        //[Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection frmCollection)
        {
            Product product = new Product();
            product.Name = frmCollection["Name"];
            product.Price = Convert.ToDecimal(frmCollection["Price"]);
            _context.productsTable.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product Id is Required !");
            }
            Product product = _context.productsTable.Find(id);
            if(product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product Not Found !");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Product product = _context.productsTable.Find(id);
            UpdateModel(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product Id is required !");
            }
            Product product = _context.productsTable.Find(id);
            if(product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound,"Product Not Found !");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Product product = _context.productsTable.Find(id);
            _context.productsTable.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}