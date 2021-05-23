using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pagination.Data;
using Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Controllers
{
    public class ProductController : Controller
    {
        private readonly PaginationContext _context;
        public ProductController(PaginationContext context)
        {
            _context = context;
        }
        /*public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }*/

        [HttpGet]
        //[Search]
        public async Task<IActionResult> Index(string NameSearch)
        {
            ViewData["Getproductdetails"] = NameSearch;
            var productquery = from p in _context.Products select p;
            if (!String.IsNullOrEmpty(NameSearch))
            {
                productquery = productquery.Where(p => p.Name.Contains(NameSearch) || p.Description.Contains(NameSearch));
            }
            return View(await productquery.AsNoTracking().ToListAsync());
        }
        //[~Search]

        
        [HttpGet]
        public IActionResult Create()
        {
            Product prod = new Product();
            return View(prod);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}