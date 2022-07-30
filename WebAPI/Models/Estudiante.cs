using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdEst { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasennia { get; set; }

        public virtual ICollection<Favoritos> Favoritos { get; set; }
    }
}
