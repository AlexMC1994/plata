using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Codigo
    {
        public static CodigoDt ObtenerCodigoId(int id) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Codigop listarCod = db.Codigops.Find(id);
            CodigoDt codigodt = new CodigoDt();
            codigodt.IdCodigop = listarCod.IdCodigop;
            codigodt.Codigopais = listarCod.Codigopais;
            codigodt.Descripcion = listarCod.Descripcion;
            return codigodt;
        }

        public static ICollection<CodigoDt> ListaCodigo()
        {
            ICollection<CodigoDt> lista = new List<CodigoDt>();
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            foreach (Codigop codigo in db.Codigops.ToList())
            {
                lista.Add(new CodigoDt()
                {
                   IdCodigop = codigo.IdCodigop,
                   Codigopais = codigo.Codigopais,
                   Descripcion = codigo.Descripcion

            });

            }
            return lista;

        }

    }
}