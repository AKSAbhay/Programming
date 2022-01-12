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
            //PartialView();
        }
        public ActionResult AddorEdit(int id=0)
        {
            if(id==0)
            return View(new mvcProductModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("tblProducts/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcProductModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddorEdit(mvcProductModel product)
        {
            if(product.productId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("tblProducts", product).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("tblProducts/"+product.productId,product).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("tblProducts/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}