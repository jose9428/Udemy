using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        [Route("listaTodos")]
        public List<CategoriaDt> listaTodos()
        {
            return CategoriaService.ListarTodos();
        }
    }
}
