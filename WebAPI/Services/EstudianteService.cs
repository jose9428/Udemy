using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public class EstudianteService
    {
        public static EstudianteDt Autentificar(string correo, string password)
        {
            UdemyContext db = new UdemyContext();
            return (from e in db.Estudiante
                   where e.Correo == correo && e.Contrasennia == password   
                   select new EstudianteDt()
                   {
                       IdEst = e.IdEst,
                       Nombres = e.Nombres,
                       Apellidos = e.Apellidos,
                       Correo = e.Correo,
                       Telefono = e.Telefono
                   }).FirstOrDefault();
        }

        public static string Registro(Estudiante obj)
        {
            UdemyContext db = new UdemyContext();
            string msg = "";
            int existeCorreo = db.Estudiante.
            Where(x => x.Correo == obj.Correo).Count();

            if (existeCorreo == 0)
            {
                db.Estudiante.Add(obj);
                if (db.SaveChanges() > 0)
                {
                    msg = "OK";
                }
                else
                {
                    msg = "No se pudieron guardar datos";
                }
            }
            else
            {
                msg = "El correo " + obj.Correo + " no se encuentra disponible";
            }
            return msg;
        }
    }
}
