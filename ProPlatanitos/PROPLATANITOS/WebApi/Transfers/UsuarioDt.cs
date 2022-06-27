namespace WebApi.Transfers
{
    public class UsuarioDt
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? CodigoPais { get; set; }
        public int? Telefono { get; set; }

    }
}
