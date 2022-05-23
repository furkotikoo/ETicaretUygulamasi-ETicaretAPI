using ETicaretAPI.Aplication.Abstractions;
using ETicaretAPI.Aplication.Repostories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepostory _productReadRepostory;
        private readonly IProductWriteRepostory _productWriteRepostory;

        public ProductsController(IProductReadRepostory productReadRepostory, IProductWriteRepostory productWriteRepostory)
        {
            _productReadRepostory = productReadRepostory;
            _productWriteRepostory = productWriteRepostory;
        }

        [HttpGet]
        public async Task Get()
        {
            Product p = await _productReadRepostory.GetByIdAsync("36852d56-c53b-458b-8cb8-3adc238c05f4");
            p.Name = "Mehmet";
            _productWriteRepostory.SaveAsync();
        }
     
    }
}
