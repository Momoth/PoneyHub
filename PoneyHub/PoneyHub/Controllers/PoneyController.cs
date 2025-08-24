using Microsoft.AspNetCore.Mvc;

using PoneyHub.Application.Models;
using PoneyHub.Application.Services;

namespace PoneyHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoneyController : ControllerBase
    {
        private readonly IPoneyService poneyService;

        public PoneyController(IPoneyService poneyService)
        {
            this.poneyService = poneyService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(InsertUpdatePoney insertUpdatePoney)
        {
            var id = await poneyService.InsertAsync(insertUpdatePoney);

            return Created(string.Empty, new { id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, InsertUpdatePoney insertUpdatePoney)
        {
            await poneyService.UpdateAsync(id, insertUpdatePoney);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await poneyService.DeleteAsync(id);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var poney = await poneyService.GetAsync(id);

            if (poney == null)
            {
                return NotFound();
            }

            return Ok(poney);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int? skip, int? take)
        {
            if (skip.HasValue && take.HasValue)
            {
                return Ok(await poneyService.GetAllAsync(skip.Value, take.Value));
            }

            return Ok(await poneyService.GetAllAsync());
        }
    }
}