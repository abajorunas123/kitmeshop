using Microsoft.AspNetCore.Mvc;

namespace KitmEshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EshopContext _db;
        public ProductsController(EshopContext db)
        {
            _db = db;           
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Products);
        }
    }
}
