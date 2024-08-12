using Assesment5.Entity;
using Assesment5.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assesment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierContoller : Controller
    {
        private readonly SupplierRepository repository;

        public SupplierContoller(SupplierRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await repository.GetAllSupplier());
        }
        [HttpGet, Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await repository.GetById(id));
        }
        [HttpPut, Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] Supplier supplier)
        {
            await repository.Update(supplier);
            return Ok(supplier);
        }
        [HttpPost, Route("AddSupplier")]
        public async Task<IActionResult> Add(Supplier supplier)
        {
            await repository.Add(supplier);
            return Ok(supplier);
        }
        [HttpDelete, Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await repository.DeleteById(id);
            return Ok();
        }

    }
}
