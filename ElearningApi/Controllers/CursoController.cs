using ElearningApi.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElearningApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICurso _cursoService;
        public CursoController(ICurso cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var respose = await _cursoService.ObtenerCursos();
                return Ok(respose);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);                
            }
        }
    }
}
