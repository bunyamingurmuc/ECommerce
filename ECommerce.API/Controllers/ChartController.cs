using ECommerce.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        public readonly ISellerService _service;

        public ChartController(ISellerService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> SalesThisMonthForChart(int id)
        {
            var data=await _service.GetByIdAsyncR(id);
            var seller = data.Data;
            var currentMonth = DateTime.Now.Month;
            var orders = seller.Orders.Where(i => i.CreatedDate.Month == currentMonth).ToList();
            var values = orders.OrderBy(x => x.CreatedDate).GroupBy(c => c.CreatedDate.Day)
                .Select(z => new { Toplam = z.Sum(x => x.TotalPrice) }).ToList();
            return Ok(values);

        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> DiscountSalesThisMonthForChart(int id)
        {
            var data = await _service.GetByIdAsyncR(id);
            var seller = data.Data;
            var currentMonth = DateTime.Now.Month;
            var orders = seller.Orders.Where(i => i.CreatedDate.Month == currentMonth).Where(i => i.Discount != 0).OrderBy( i=> i.CreatedDate).ToList();
            var values = orders
                .GroupBy(c => c.CreatedDate.Day)
                .Select(
                    z => new
                    {
                        Toplam = z.Sum(x => x.TotalPrice
                        )
                    })
                .ToList();
            return Ok(values);


        }

    }
}
