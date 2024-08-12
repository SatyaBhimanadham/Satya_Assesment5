using Assesment5.Entity;
using Assesment5.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assesment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOrderController : Controller
    {
        private readonly PurchaseOrderRepository repository;

        public PurchaseOrderController(PurchaseOrderRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet, Route("GetItems")]
        public IActionResult GetAllOrders()
        {
            return StatusCode(200,repository.GetAllOrders());
        }
        [HttpGet, Route("GetProductById/{id}")]
        public IActionResult Get([FromRoute] int ItemId)
        {
            var item = repository.GetOrder(ItemId);
            if (item != null)
            {
                return StatusCode(200, item);
            }
            else
            {
                return StatusCode(404, "Inavlid Id");
            }
        }
        

        [HttpPost, Route("AddItem")]
        public IActionResult AddItem([FromBody] Item item)
        {
            repository.AddOrder(item);
            return Ok(item);
        }
        [HttpDelete, Route("DeleteProduct")]
        public IActionResult Delete([FromQuery] int id)
        {
            repository.Delete(id);
            return Ok();
        }

    }
}
