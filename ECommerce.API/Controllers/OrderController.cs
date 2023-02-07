using System.Security.Claims;
using ECommerce.API.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.Common.Enums;
using ECommerce.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IOrderService _service;
        public readonly ISellerService _sellerService;
        public readonly ICardService _cardService;
        public readonly IAppUserService _appUserService;


        public OrderController(IOrderService service, ICardService cardService, IAppUserService appUserService, ISellerService sellerService)
        {
            _service = service;
            _cardService = cardService;
            _appUserService = appUserService;
            _sellerService = sellerService;
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetCurrentMountSellerOrderQuantity(int id)
        {
            var response = await _sellerService.GetByIdAsyncR(id);
            var seller = response.Data;
            
            var data = _service.GetCurrentMountSellerOrderQuantity(seller);
            return this.ResponseStatusWithData(data);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetCompereMountOrderRate(int id)
        {
            var response = await _sellerService.GetByIdAsyncR(id);
            var seller = response.Data;

            var data = _service.GetCompereMountOrderRate(seller);
            return this.ResponseStatusWithData(data);
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
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> CreateAsy(Order entity)
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var response = await _service.CreateOrder(entity, userId);
            return this.ResponseStatusWithData(response);

        }

        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> UpdateAsy(Order entity)
        {
            var response = await _service.UpdateOrder(entity);
            return this.ResponseStatusWithData(response);
        }

        [HttpDelete]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> DeleteAsy(int id)
        {
            var response = await _service.RemoveAsync(id);
            return this.ResponseStatusWithData(response);
        }
    }
}
