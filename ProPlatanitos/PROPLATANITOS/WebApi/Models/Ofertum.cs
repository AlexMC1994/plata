using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Ofertum
    {
        public int IdOferta { get; set; }
        public string? NomOferta { get; set; }
        public int? IdCategoria { get; set; }
        public string? NomCategoria { get; set; }
        public int? IdProducto { get; set; }
        public string? NomProducto { get; set; }
        public decimal? Descuento { get; set; }
        public string? Activo { get; set; }
    }
}
