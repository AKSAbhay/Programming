using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiInMvc.Models;

namespace WebApiInMvc.Controllers
{
    public class tblProductsController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/tblProducts
        public IQueryable<tblProduct> GettblProducts()
        {
            return db.Products;
        }

        // GET: api/tblProducts/5
        [ResponseType(typeof(tblProduct))]
        public IHttpActionResult GettblProduct(int id)
        {
            tblProduct tblProduct = db.Products.Find(id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return Ok(tblProduct);
        }

        // PUT: api/tblProducts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblProduct(int id, tblProduct tblProduct)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != tblProduct.productId)
            {
                return BadRequest();
            }

            db.Entry(tblProduct).State = (System.Data.Entity.EntityState)EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tblProducts
        [ResponseType(typeof(tblProduct))]
        public IHttpActionResult PosttblProduct(tblProduct tblProduct)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.Products.Add(tblProduct);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblProduct.productId }, tblProduct);
        }

        // DELETE: api/tblProducts/5
        [ResponseType(typeof(tblProduct))]
        public IHttpActionResult DeletetblProduct(int id)
        {
            tblProduct tblProduct = db.Products.Find(id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            db.Products.Remove(tblProduct);
            db.SaveChanges();

            return Ok(tblProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblProductExists(int id)
        {
            return db.Products.Count(e => e.productId == id) > 0;
        }
    }
}