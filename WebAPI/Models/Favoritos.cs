using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Favoritos
    {
        public int IdFavorito { get; set; }
        public int? IdCurso { get; set; }
        public int? IdEst { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Estudiante IdEstNavigation { get; set; }
    }
}
