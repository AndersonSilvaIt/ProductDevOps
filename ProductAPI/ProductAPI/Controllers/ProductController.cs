using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GetMockProducts());
        }

        private List<ProductViewModel> GetMockProducts()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel { Id =  1, Name = "Notebook Gamer X100",  Price = 3599.90m, Stock =  15 },
                new ProductViewModel { Id =  2, Name = "Smartphone Ultra S20", Price = 2499.50m, Stock =  30 },
                new ProductViewModel { Id =  3, Name = "Teclado Mecânico RGB",   Price =   299.99m, Stock = 100 },
                new ProductViewModel { Id =  4, Name = "Mouse Sem Fio Pro",     Price =   149.75m, Stock =  60 },
                new ProductViewModel { Id =  5, Name = "Monitor 27\" 4K",        Price = 1899.00m, Stock =  20 },
                new ProductViewModel { Id =  6, Name = "Headset Gamer V2",      Price =   349.20m, Stock =  45 },
                new ProductViewModel { Id =  7, Name = "SSD NVMe 1TB",          Price =   599.90m, Stock =  80 },
                new ProductViewModel { Id =  8, Name = "Câmera Web HD",          Price =   129.99m, Stock = 120 },
                new ProductViewModel { Id =  9, Name = "Fonte 650W 80+ Gold",    Price =   459.00m, Stock =  25 },
                new ProductViewModel { Id = 10, Name = "Gabinete Mid-Tower",     Price =   299.00m, Stock =  40 }
            };
        }
    }
}
