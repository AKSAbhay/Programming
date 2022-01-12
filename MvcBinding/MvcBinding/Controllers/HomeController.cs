using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcBinding.Models;

namespace MvcBinding.Controllers
{
    public class HomeController : Controller
    {
        ProductsContext _context = new ProductsContext();
        public ViewResult Register()
        {
            return View();
        }
        // GET: Home
        public ViewResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password,string role, string ReturnUrl)
        {
            if (IsValid(UserName, Password,role) == true)
            {
                FormsAuthentication.SetAuthCookie(UserName, false);
                Session["username"] = UserName.ToString();
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Products");
                }
            }
            else
            {
                return View();
            }

        }
        public bool IsValid(string UserName, string Password, string role)
        {
            return _context.Users.use
             /* UserName == "Abhay" && Password == "1234";*/
            //var credentials = db.Users.Where(x => x.UserName == u.UserName && x.Password == u.Password);
            //return u.UserName == credentials.UserName && u.Password == credentials.password;
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["username"] = null;
            return RedirectToAction("Login","Home");
        }
    }
}