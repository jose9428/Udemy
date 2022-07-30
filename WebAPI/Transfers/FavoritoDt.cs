namespace WebAPI.Transfers
{
    public class FavoritoDt
    {
        public int IdFavorito { get; set; }
        public int? IdCurso { get; set; }
        public int? IdEst { get; set; }
        public CursoDt curso { get; set; }
    }
}
