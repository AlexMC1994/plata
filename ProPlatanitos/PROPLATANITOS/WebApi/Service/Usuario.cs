using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Usuario
    {
        public static UsuarioDt ObtenerUsuarioId(int id)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Usuario usuario = db.Usuarios.Find(id);
            UsuarioDt usuariodt = new UsuarioDt();
            usuariodt.IdUsuario = usuario.IdUsuario;
            usuariodt.Nombre = usuario.Nombre;
            usuariodt.Apellido = usuario.Apellido;
            usuariodt.Correo = usuario.Correo;
            usuariodt.Clave = usuario.Clave;
            usuariodt.TipoDocumento = usuario.TipoDocumento;
            usuariodt.NumeroDocumento = usuario.NumeroDocumento;
            usuariodt.CodigoPais = usuario.CodigoPais;
            usuariodt.Telefono = usuario.Telefono;
            return usuariodt;
        }

        public static UsuarioDt Obten(int id)
        {
            SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            var obj = db.Usuarios.Select(b =>
            new UsuarioDt()
            {
                IdUsuario = b.IdUsuario,
                Nombre = b.Nombre,
                Apellido = b.Apellido,
                Correo = b.Correo,
                Clave = b.Clave,
                TipoDocumento = b.TipoDocumento,
                NumeroDocumento = b.NumeroDocumento,
                CodigoPais = b.CodigoPais,
                Telefono = b.Telefono
            }).SingleOrDefault(b => b.IdUsuario == id);
            if(obj == null) obj = new UsuarioDt() { IdUsuario = 0, Nombre= ""};
            return obj;

        }


        public static UsuarioDt Registro(UsuarioDt usuarioDt)
        {
           SOAPLATANITOSContext db = new SOAPLATANITOSContext();
           Usuario usuario = new Usuario()
           {
            Nombre = usuarioDt.Nombre,
            Apellido = usuarioDt.Apellido,
            Correo = usuarioDt.Correo,
            Clave = usuarioDt.Clave,
            TipoDocumento = usuarioDt.TipoDocumento,
            NumeroDocumento = usuarioDt.NumeroDocumento,
            CodigoPais = usuarioDt.CodigoPais,
            Telefono = usuarioDt.Telefono
        };

             db.Usuarios.Add(usuario);
             db.SaveChanges();

            return Usuario.Obten(usuario.IdUsuario);  // opcion return usuarioDt
        }
    }
}