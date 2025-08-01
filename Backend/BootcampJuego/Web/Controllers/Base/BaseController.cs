using Business.Interfaces.Repository;
using Entity.DTOs.Base;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TDto,TSelect,TService> : ControllerBase where TService : IBusinessGeneric<TDto,TSelect>
    {
        protected readonly TService _service;
        public BaseController(TService service)
        {
            _service = service;
            

        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var result = await _service.GetAllAsync();
                return Ok(result);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _service.GetByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TDto dto)
        {
            try
            {
                var result = await _service.CreateAsync(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put([FromBody] TDto dto,int id)
        {
            try
            {
                
                var result = await _service.UpdateAsync(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                var result = await _service.DeleteAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
