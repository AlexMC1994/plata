using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Categoriasecundarium
    {
        public int IdSubCategoria { get; set; }
        public int? IdCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Activo { get; set; }
    }
}
