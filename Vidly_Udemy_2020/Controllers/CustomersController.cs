﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Udemy_2020.Models;

namespace Vidly_Udemy_2020.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View( customers );
        }

        public ActionResult Details( int id )
        {
            var customer = GetCustomers().SingleOrDefault( c => c.Id == id );

            if ( customer == null )
                return HttpNotFound();

            return View( customer );
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Rebbeca Fold" }
            };

            return customers;
        }
    }
}