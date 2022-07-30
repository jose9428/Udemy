using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Curso = new HashSet<Curso>();
        }

        public int IdCategoria { get; set; }
        public string NomCat { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
