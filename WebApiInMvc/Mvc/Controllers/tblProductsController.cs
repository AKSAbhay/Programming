using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class tblProductsController : Controller
    {
        // GET: tblProducts
        public ActionResult Index()
        {
            IEnumerable<mvcProductModel> productList;
            HttpResponseMessage respone = GlobalVariables.WebApiClient.GetAsync("tblProducts").Result;
            productList = respone.Content.ReadAsAsync<IEnumerable<mvcProductModel>>().Result;
            return View(productList);
        }
    }
}