using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        [HttpGet]
        [Route("listaPorIdCat")]
        public List<CursoDt> ListarPorIdCategoria(int idCat)
        {
            return CursoService.ListarPorIdCategoria(idCat);
        }

        [HttpGet]
        [Route("listaFiltro")]
        public List<CursoDt> ListarFiltroPorCurso(string s)
        {
            return CursoService.ListarFiltroPorCurso(s);
        }

        [HttpGet]
        [Route("buscarPorId")]
        public CursoDt BuscarId(int idCurso)
        {
            return CursoService.BuscarPorIdCurso(idCurso);
        }

    }
}
