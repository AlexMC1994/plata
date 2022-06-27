using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Documento
    {
        public static DocumentoDt Obtener(int id) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Documento documento = db.Documentos.Find(id);
            DocumentoDt documentodt = new DocumentoDt();
            documentodt.IdDocumento = documento.IdDocumento;
            documentodt.TipoDocumento = documento.TipoDocumento;
            documentodt.Descripcion = documento.Descripcion;
            return documentodt;
        }

    }
}