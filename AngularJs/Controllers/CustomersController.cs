using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngularJs.Models;

namespace AngularJs.Controllers
{
    public class CustomersController : Controller
    {
        private MovieStoreEntities db = new MovieStoreEntities();
      
        // GET: Customers
        public ActionResult CustomerForm()
        {

            var listOfCustomers = db.Customers.ToList();

            return View(listOfCustomers);
        }
        public ActionResult Edit(int? customerId)
        {

            if (customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.SingleOrDefault(m => m.CustomerId == customerId);;
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,Name,BirthDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CustomerForm");
            }
            return View(customer);
        }

    }
}