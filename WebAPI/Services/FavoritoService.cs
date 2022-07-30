using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public class FavoritoService
    {
        public static bool seleccionFavorito(int idCurso, int idEstudiante , bool check)
        {
            UdemyContext db = new UdemyContext();
            bool estado = false;

            int existeFav = db.Favoritos.
                Where(x => x.IdCurso == idCurso && x.IdEst == idEstudiante).Count();
            Favoritos obj = null;
            if (existeFav == 0)
            {
                if (check)
                {
                    obj = new Favoritos()
                    {
                        IdCurso = idCurso,
                        IdEst = idEstudiante
                    };

                    db.Favoritos.Add(obj);

                    if (db.SaveChanges() > 0)
                    {
                        estado = true;
                    }
                } 
            }
            else
            {
                if (!check)
                {
                    obj = db.Favoritos.Where(x => x.IdCurso == idCurso && x.IdEst == idEstudiante).First();
                    db.Favoritos.Remove(obj);

                    if (db.SaveChanges() > 0)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }

        public static List<FavoritoDt> ListarMisfavoritos(int idEst)
        {
            UdemyContext db = new UdemyContext();
            return (from cur in db.Curso
                    join f in db.Favoritos
                    on cur.IdCurso equals f.IdCurso
                    where f.IdEst == idEst
                    select new FavoritoDt()
                    {
                        curso = new CursoDt()
                        {
                            IdCurso = cur.IdCurso,
                            NomCurso = cur.NomCurso,
                            Descripcion = cur.Descripcion,
                            ImagenUrl = cur.ImagenUrl,
                            VideoUrl = cur.VideoUrl,
                            FechaPublicacion = cur.FechaPublicacion,
                            Profesor = cur.Profesor,
                        } ,
                        IdEst = f.IdEst,
                        IdFavorito = f.IdFavorito

                    }).ToList();
        }

    }
}
