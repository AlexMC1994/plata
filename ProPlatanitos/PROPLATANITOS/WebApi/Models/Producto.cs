using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdCategoria { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
    }
}
