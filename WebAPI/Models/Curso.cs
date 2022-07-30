using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Curso
    {
        public Curso()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdCurso { get; set; }
        public int? IdCategoria { get; set; }
        public string NomCurso { get; set; }
        public string Descripcion { get; set; }
        public string Profesor { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string VideoUrl { get; set; }
        public string ImagenUrl { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Favoritos> Favoritos { get; set; }
    }
}
