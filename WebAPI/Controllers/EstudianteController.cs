using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        [HttpGet]
        [Route("login")]
        public IActionResult Autentificar(string correo , string password)
        {
            EstudianteDt obj = EstudianteService.Autentificar(correo,password);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpPost]
        [Route("registro")]
        public string Registro(Estudiante obj)
        {
            return EstudianteService.Registro(obj);
        }
    }
}
