using Assesment5.Entity;
using Assesment5.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assesment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly ItemRepository _repository;

        public ItemController(ItemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("GetItems")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repository.GetAllItem());
        }
        [HttpGet, Route("GetProductById/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await _repository.GetItemByIdAsync(id);
            if (item != null)
            {
                return StatusCode(200, item);
            }
            else
            {
                return StatusCode(404, "Inavlid Id");
            }
        }
        [HttpGet, Route("GetProductByName/{name}")]
        public async Task<IActionResult> GetByName([FromRoute] string name)
        {
            var item = await _repository.GetItemByNameAsync(name);
            if (item != null)
            {
                return Ok(item);
            }
            else
            {
                return NotFound("Invalid Name");
            }
        }

        [HttpPost, Route("AddItem")]
        public async Task<IActionResult> Add([FromBody] Item item)
        {
            await _repository.AddItem(item);
            return Ok(item);
        }
        [HttpDelete, Route("DeleteProduct")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            await _repository.DeleteById(id);
            return Ok();
        }
    }
}
