using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Categorium
    {

        public static ICollection<CategoriumDt> ListarCategoria()
        {
            ICollection<CategoriumDt> lista = new List<CategoriumDt>();
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            foreach (Categorium categorium in db.Categoria.ToList())
            {
                lista.Add(new CategoriumDt()
                {
                    IdCategoria = categorium.IdCategoria,
                    Nombre = categorium.Nombre,
                    Descripcion = categorium.Descripcion,
                    Activo = categorium.Activo,
                });

            }
            return lista;

        }

        public static CategoriumDt ObtenerCategoria(int id)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            var obj = db.Categoria.Select(b =>
            new CategoriumDt()
            {
                IdCategoria = b.IdCategoria,
                Nombre = b.Nombre,
                Descripcion = b.Descripcion,
                Activo = b.Activo,


            }).SingleOrDefault(b => b.IdCategoria == id);
            if (obj == null) obj = new CategoriumDt() { IdCategoria = 0, Nombre = "" };
            return obj;

        }

    }
}