using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Ofertum
    {
        public static OfertumDt BuscaOfertaID(int id)
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

        public static OfertumDt ObtenOferta(int id)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            var obj = db.Oferta.Select(b =>
            new OfertumDt()
            {
            IdOferta = b.IdOferta,
            NomOferta = b.NomOferta,
            IdCategoria = b.IdCategoria,
            NomCategoria = b.NomCategoria,
            IdProducto = b.IdProducto,
            NomProducto = b.NomProducto,
            Descuento = b.Descuento
        }).SingleOrDefault(b => b.IdOferta == id);
            if (obj == null) obj = new OfertumDt() { IdOferta = 0, NomOferta = "" };
            return obj;

        }


        public static ICollection<OfertumDt> ListaOferta()
        {
            ICollection<OfertumDt> lista = new List<OfertumDt>();
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            foreach (Ofertum oferta in db.Oferta.ToList())
            {
                lista.Add(new OfertumDt()
                {
                    IdOferta = oferta.IdOferta,
                    IdCategoria = oferta.IdCategoria,
                    NomOferta = oferta.NomOferta,
                    NomCategoria = oferta.NomCategoria,
                    IdProducto = oferta.IdProducto,
                    NomProducto = oferta.NomProducto,
                    Descuento = oferta.Descuento

                 });

            }
            return lista;

        }



        public static OfertumDt AgregarOferta(OfertumDt ofertumDt)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Ofertum ofertum = new Ofertum()
            {
                NomOferta = ofertumDt.NomOferta,
                NomCategoria = ofertumDt.NomCategoria,
                NomProducto = ofertumDt.NomProducto,
                Descuento = ofertumDt.Descuento
            };

            db.Oferta.Add(ofertum);
            db.SaveChanges();
            return Ofertum.ObtenOferta(ofertum.IdOferta);

        }

        public static OfertumDt ActualizaOferta(int id, OfertumDt ofertumDt) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Ofertum ofertum = db.Oferta.Find(id);
            ofertum.NomOferta = ofertumDt.NomOferta;
            ofertum.IdCategoria = ofertumDt.IdCategoria;
            ofertum.NomCategoria = ofertumDt.NomCategoria;
            ofertum.IdProducto = ofertumDt.IdProducto;
            ofertum.NomProducto = ofertumDt.NomProducto;
            ofertum.Descuento = ofertumDt.Descuento;
            db.Entry(ofertum).State = EntityState.Modified;
            db.SaveChanges();
            return Ofertum.ObtenOferta(ofertum.IdOferta);
        }

        public static Boolean Eliminar(int IdOferta)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Ofertum ofertum = db.Oferta.Find(IdOferta);
            db.Oferta.Remove(ofertum);
            db.SaveChanges();
            return true;
        }

    }
}