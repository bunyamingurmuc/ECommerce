using ECommerce.API.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public ActionResult GetAll()
        {
            var response = _service.GetAll();
            return this.ResponseStatusWithData(response);
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public ActionResult GetById(int id)
        {
            var response = _service.GetById(id);
            return this.ResponseStatusWithData(response);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Create(Review entity)
        {
            var response = _service.Create(entity);
            return this.ResponseStatusWithData(response);

        }

        [HttpPut]
        [Route("/[controller]/[action]")]
        public ActionResult Update(Review entity)
        {
            var response = _service.Update(entity);
            return this.ResponseStatusWithData(response);
        }

        [HttpDelete]
        [Route("/[controller]/[action]")]
        public ActionResult Delete(int id)
        {
            var response = _service.Remove(id);
            return this.ResponseStatusWithData(response);
        }

        //------------ASYNCRON ENTPOINTS----------

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetAllAsycn()
        {
            var response = await _service.GetAllAsync();
            return this.ResponseStatusWithData(response);
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> GetByIdAsycn(int id)
        {
            var response = await _service.GetByIdAsync(id);
            return this.ResponseStatusWithData(response);
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> CreateAsycn(Review entity)
        {
            var response = await _service.CreateAsync(entity);
            return this.ResponseStatusWithData(response);

        }

        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> UpdateAsycn(Review entity)
        {
            var response = await _service.UpdateAsync(entity);
            return this.ResponseStatusWithData(response);
        }

        [HttpDelete]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult> DeleteAsycn(int id)
        {
            var response = await _service.RemoveAsync(id);
            return this.ResponseStatusWithData(response);
        }
    }
}
