using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Documento
    {
        public static DocumentoDt ObtenerDocId(int id) {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Documento documento = db.Documentos.Find(id);
            DocumentoDt documentodt = new DocumentoDt();
            documentodt.IdDocumento = documento.IdDocumento;
            documentodt.TipoDocumento = documento.TipoDocumento;
            documentodt.Descripcion = documento.Descripcion;
            return documentodt;
        }


        public static ICollection<DocumentoDt> ListaDoc()
        {
            ICollection<DocumentoDt> lista = new List<DocumentoDt>();
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            foreach (Documento documento in db.Documentos.ToList())
            {
                lista.Add(new DocumentoDt()
                {
                    IdDocumento = documento.IdDocumento,
                    TipoDocumento = documento.TipoDocumento,
                    Descripcion = documento.Descripcion

                });

            }
            return lista;

        }




    }
}