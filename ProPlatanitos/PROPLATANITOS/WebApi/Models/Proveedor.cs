using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Proveedor
    {
        public int IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public int? Ruc { get; set; }
        public string? RepresentanteLegal { get; set; }
        public string? Dirección { get; set; }
        public string? Ciudad { get; set; }
        public int? Telefono { get; set; }
        public string? Correocontacto { get; set; }
        public string? TipoServicio { get; set; }
        public bool? Activo { get; set; }
    }
}
