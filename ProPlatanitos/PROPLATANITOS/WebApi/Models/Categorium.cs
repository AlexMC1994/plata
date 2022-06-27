using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }
    }
}
