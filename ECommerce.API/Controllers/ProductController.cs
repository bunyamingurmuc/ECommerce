using ECommerce.API.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _service;
        public readonly ISellerService _SellerService;

        public ProductController(IProductService service, ISellerService sellerService)
        {
            _service = service;
            _SellerService = sellerService;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetRemovalProduct()
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var seller =await _SellerService.GetByIdAsyncR(userId);
            var response =await _service.GetRemovalProductAsync(seller.Data);
            return this.ResponseStatusWithData(response);
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetLowerStockProducts()
        {
            var response =await _service.GetLowerStockProductsAsync();
            return this.ResponseStatusWithData(response);
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetAllAsy()
        {
            var response = await _service.GetAllAsyncR();
            return this.ResponseStatusWithData(response);
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetByIdAsy(int id)
        {
            var response = await _service.GetByIdAsyncR(id);
            return this.ResponseStatusWithData(response);
        }

        [HttpPost]
        [Authorize(Roles = "Seller")]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> CreateAsy(Product entity)
        {
            var sellerId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var response = await _service.CreateCalculateAsync(entity,sellerId);
            return this.ResponseStatusWithData(response);
        }


        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> UpdateAsy(Product entity)
        {
            var response = await _service.UpdateAsync(entity);
            return this.ResponseStatusWithData(response);
        }

        [HttpDelete]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> DeleteAsy(int id)
        {
            var response = await _service.RemoveAsync(id);
            return this.ResponseStatusWithData(response);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> ImportProductExcel(IFormFile file)
        {
           var result=await _service.ImportExcel(file);
           return this.ResponseStatusWithData(result);
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetHomeProduct()
        {
            var result=await _service.GetHomeProduct();
            return this.ResponseStatusWithData(result);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetRelatedProducts(int productId)
        {
            var result = await _service.GetRelatedProducts(productId);
            return this.ResponseStatusWithData(result);
        }

    }
}
