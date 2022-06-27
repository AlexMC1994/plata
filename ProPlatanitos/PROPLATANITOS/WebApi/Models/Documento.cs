using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Documento
    {
        public int IdDocumento { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Descripcion { get; set; }
    }
}
