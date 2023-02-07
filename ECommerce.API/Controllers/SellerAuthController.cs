using ECommerce.BLL.Extension.Token;
using ECommerce.BLL.Interfaces;
using ECommerce.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerAuthController : ControllerBase
    {
        public readonly ISellerService _SellerService;

        public SellerAuthController(ISellerService sellerService)
        {
            _SellerService = sellerService;
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> SellerLogIn(CLoginDto dto)
        {
            var response = await _SellerService.GetAllAsync();
            var sellers = response.Data;
            var seller = sellers.FirstOrDefault(i => i.Email == dto.Email && i.Password == dto.Password);

            if (seller == null)
                return NotFound("Kullanıcı adı veya parola yanlış");
            dto.Id = seller.Id;
            dto.Role = "Seller";
            var token = JwtTokenGenerator.GenerateToken(dto);
            return Created("", token);
        }
    }
}
