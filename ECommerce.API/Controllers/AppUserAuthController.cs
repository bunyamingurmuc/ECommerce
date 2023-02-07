using ECommerce.API.Extension;
using ECommerce.BLL.Extension.Token;
using ECommerce.BLL.Interfaces;
using ECommerce.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserAuthController : ControllerBase
    {

        public readonly IAppUserService _appUserService;

        public AppUserAuthController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> CreateAccount(CCreateAccountDto dto)
        {
            var response = await _appUserService.CreateUser(dto);
            return this.ResponseStatusWithData(response);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> AppUserLogIn(CLoginDto dto)
        {
            var response = await _appUserService.GetAllAsync();
            var appusers = response.Data;
            var user = appusers.FirstOrDefault(i => i.Email == dto.Email && i.Password == dto.Password);

            if (user == null)
                return NotFound("Kullanıcı adı veya parola yanlış");
            dto.Id=user.Id;

            dto.Role = "AppUser";

            var token = JwtTokenGenerator.GenerateToken(dto);
            return Created("", token);
        }
    }
}
