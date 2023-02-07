using System.Security.Claims;
using ECommerce.API.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Seller")]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _service;

        public SellerController(ISellerService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> SalesThisMonths(int id)
        {
            var response = await _service.SalesThisMonthsAsync(id);
            return this.ResponseStatusWithData(response);
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> NewCustomerThisMonth(int id)
        {
            var response =await _service.NewCustomerThisMonthAsync(id);
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
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> CreateAsy(Seller entity)
        {
            var response = await _service.CreateAsync(entity);
            return this.ResponseStatusWithData(response);

        }

        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> UpdateAsy(Seller entity)
        {
            var response = await _service.UpdateAsync(entity);
            return this.ResponseStatusWithData(response);
        }

        [HttpDelete]
        [Route("/[controller]/[action]/")]
        public async Task<ActionResult> DeleteAsy(int id)
        {
            var response = await _service.RemoveAsync(id);
            return this.ResponseStatusWithData(response);
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetUserProducts()
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var response = await _service.GetByIdAsyncR(userId);
            return this.ResponseStatusWithData(response);
        }


    }
}
