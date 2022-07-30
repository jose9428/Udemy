using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public class CursoService
    {
      
        public static List<CursoDt> ListarPorIdCategoria(int idCat)
        {
            UdemyContext db = new UdemyContext();
            return (from cur in db.Curso
                    join cat in db.Categoria
                    on cur.IdCategoria equals cat.IdCategoria
                    where cur.IdCategoria == idCat
                    select new CursoDt()
                    {
                        IdCurso = cur.IdCurso,
                        NomCurso = cur.NomCurso,
                        Descripcion = cur.Descripcion,    
                        ImagenUrl = cur.ImagenUrl,
                        VideoUrl = cur.VideoUrl,
                        FechaPublicacion = cur.FechaPublicacion,  
                        Profesor = cur.Profesor,
                        IdCategoria = cat.IdCategoria,
                        NomCategoria = cat.NomCat
                    }).ToList();
        }

        public static List<CursoDt> ListarFiltroPorCurso(string termino)
        {
            UdemyContext db = new UdemyContext();
            return (from cur in db.Curso
                    join cat in db.Categoria
                    on cur.IdCategoria equals cat.IdCategoria
                    where cur.NomCurso.Contains(termino)
                    select new CursoDt()
                    {
                        IdCurso = cur.IdCurso,
                        NomCurso = cur.NomCurso,
                        Descripcion = cur.Descripcion,
                        ImagenUrl = cur.ImagenUrl,
                        VideoUrl = cur.VideoUrl,
                        FechaPublicacion = cur.FechaPublicacion,
                        Profesor = cur.Profesor,
                        IdCategoria = cat.IdCategoria,
                        NomCategoria = cat.NomCat
                    }).ToList();
        }

        public static CursoDt BuscarPorIdCurso(int idCurso)
        {
            UdemyContext db = new UdemyContext();
            return (from cur in db.Curso
                    join cat in db.Categoria
                    on cur.IdCategoria equals cat.IdCategoria
                    where cur.IdCurso == idCurso
                    select new CursoDt()
                    {
                        IdCurso = cur.IdCurso,
                        NomCurso = cur.NomCurso,
                        Descripcion = cur.Descripcion,
                        ImagenUrl = cur.ImagenUrl,
                        VideoUrl = cur.VideoUrl,
                        FechaPublicacion = cur.FechaPublicacion,
                        Profesor = cur.Profesor,
                        IdCategoria = cat.IdCategoria,
                        NomCategoria = cat.NomCat
                    }).FirstOrDefault();
        }
    }
}
