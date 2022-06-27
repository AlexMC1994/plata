using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Codigo
    {
        public static CodigoDt ListarCodigo(int id) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Codigop listarCod = db.Codigops.Find(id);
            CodigoDt codigodt = new CodigoDt();
            codigodt.IdCodigop = listarCod.IdCodigop;
            codigodt.Codigopais = listarCod.Codigopais;
            codigodt.Descripcion = listarCod.Descripcion;
            return codigodt;
        }

    }
}