using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using trash.Data;
using trash.Models;



namespace trash.Controllers
{ 

    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller

    {
        ApplicationDbContext _context;

        

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            //find the user that is currently logged in.
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); 
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            //check the customer's table (query) to see if that user is in the that table


            //if the user is not in the table, I want to go to what view? CREATE view!!!!
            if (customer==null)
            {
                                         
                return RedirectToAction(nameof(Create));
            }
            //if the user is in the table, I want to return view of the index (passing that customer into the view)
        
            return View(customer);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            customer.IdentityUserId = userId;
            _context.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");

            
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            //var customer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var customerWeWantToEdit = _context.Customers.Where(c => c.CustomerId == id).SingleOrDefault();
            //we want to access the db, the table, and where the customerid is the same as the parameter id

            //query for customer that have this id being passed
            //return that customer in this edit view.
            return View(customerWeWantToEdit);
            
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
    }
}
