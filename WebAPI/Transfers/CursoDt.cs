namespace WebAPI.Transfers
{
    public class CursoDt
    {
        public int IdCurso { get; set; }
        public int? IdCategoria { get; set; }
        public string NomCategoria { get; set; }
        public string NomCurso { get; set; }
        public string Descripcion { get; set; }
        public string Profesor { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string VideoUrl { get; set; }
        public string ImagenUrl { get; set; }
    }
}
