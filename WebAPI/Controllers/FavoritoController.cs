using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritoController : ControllerBase
    {
        [HttpGet]
        [Route("seleccion")]
        public bool SeleccionFavoritoEstado(int idCurso, int idEst , bool check)
        {
            return FavoritoService.seleccionFavorito(idCurso , idEst, check);
        }

        [HttpGet]
        [Route("misFavoritos")]
        public List<FavoritoDt> ListarMisFavoritos(int idEst)
        {
            return FavoritoService.ListarMisfavoritos(idEst);
        }
    }
}
