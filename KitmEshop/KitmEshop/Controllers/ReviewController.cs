using KitmEshop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace KitmEshop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly EshopContext _db;

        public ReviewController(EshopContext db)
        {
            _db = db;
        }

        public IActionResult Add(Guid id)
        {
            var review = new Review();
            review.Product = _db.Products.FirstOrDefault(p => p.Id == id);
            
            return View(review);
        }

        [HttpPost]
        public IActionResult Add(Review model)
        {
            // save to DB
            return View();
        }
    }
}
