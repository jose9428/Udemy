using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public class CategoriaService
    {
        public static List<CategoriaDt> ListarTodos()
        {
            UdemyContext db = new UdemyContext();
            return (from c in db.Categoria
                   select new CategoriaDt(){
                       IdCategoria = c.IdCategoria,
                       NomCat = c.NomCat
                   }).ToList();
        }


    }
}
