using BLL.Abstract;
using DAL.Concrete;
using DAL.DataContext;
using DTO.MySiteDtos;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MyCourseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MySitesController : ControllerBase
    {
        //private readonly MyContext _ctx;
        //private readonly MySiteRepository _mySiteRepository;
        //public MySitesController(MyContext ctx,MySiteRepository mySiteRepository)
        //{
        //    _ctx = ctx;   
        //    _mySiteRepository = mySiteRepository;
        //}
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IMySiteService _mySiteService)
        {
            return Ok(await _mySiteService.GetAsync());
        }
        [Authorize]
        [HttpPost]

        public async Task<IActionResult> Add([FromServices] IMySiteService _mySiteService, [FromBody] MySiteToAddDto dto)
        {
            await _mySiteService.Addasync(dto);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IMySiteService _mySiteService, [FromQuery] int id)
        {
            await _mySiteService.Deleteasync(id);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id, [FromServices] IMySiteService _mySiteService)
        {
            var entity =await _mySiteService.GetByID(id);
            if (entity==null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromServices] IMySiteService _mySiteService, int id, [FromBody] MySiteToUpdateDto dto)
        {
            var site = await _mySiteService.Updateasync(id,dto);
            site.Name = dto.Name;
            return Ok();
        }


    }
}
