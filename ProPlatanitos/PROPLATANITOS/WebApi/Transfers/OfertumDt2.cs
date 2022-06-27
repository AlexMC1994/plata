namespace WebApi.Transfers
{
    public class OfertumDt2
    {
        public int IdOferta { get; set; }
        public string? NomOferta { get; set; }

        public ICollection<OfertumDt> OfertumDt { get; set; }


    }
}
