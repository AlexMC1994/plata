using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Marca
    {
        public int IdMarca { get; set; }
        public int? IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Activo { get; set; }
    }
}
