using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Ofertum
    {
        public static OfertumDt ObtenerOferta(int id)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Ofertum ofertum = db.Oferta.Find(id);
            OfertumDt ofertumdt = new OfertumDt();
            ofertumdt.IdOferta = ofertumdt.IdOferta;
            ofertumdt.NomOferta = ofertumdt.NomOferta;
            ofertumdt.IdCategoria = ofertumdt.IdCategoria;
            ofertumdt.NomCategoria = ofertumdt.NomCategoria;
            ofertumdt.IdProducto = ofertumdt.IdProducto;
            ofertumdt.NomProducto = ofertumdt.NomProducto;
            ofertumdt.Descuento = ofertumdt.Descuento;

            return ofertumdt;
        }


        public static OfertumDt ActualizaOferta(int id, ICollection<int> listaoferta) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Ofertum ofertum = db.Oferta.Find(id);
            foreach (int i in listaoferta)
            {
                int cant = db.Oferta.Where(a => a.IdOferta == id && a.Ofertums.Count(b => b.IdOferta == i) > 0).Count();
                if (cant != 0)
                {

                    Ofertum ofertu = db.Oferta.Find(i);
                    db.Entry(ofertu).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
            return ObtenerOferta(id);
        }




    }
}