﻿using System.Linq;
using CodeFirstApp.Data;
using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;

        public CustomersController(AppDbContext context)
        {
            this._db = context;
        }
        
        // GET
        public IActionResult Index()
        {
            /*
            var Customers = _db.Customers.ToList();

            @ViewData["Customers"] = Customers;
            */
            return View();
        }
    }
}