using WebApi.Transfers;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class Usuario
    {
        public static UsuarioDt ObtenerUsuario(int id) {
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

        public static UsuarioDt Registro(int id, ICollection<int> listausuario)
        {
           SOAPLATANITOSContext db = new SOAPLATANITOSContext();
            Usuario usuarios = db.Usuarios.Find(id);
            //UsuarioDt usuarioI = new UsuarioDt();
            //usuarioI.IdUsuario = IdUsuario;
            //usuarioI.Nombre = Nombre;
            //usuarioI.Apellido = Apellido;
            //usuarioI.Correo = Correo;
            //usuarioI.Clave = Clave;
            //usuarioI.TipoDocumento = TipoDocumento;
            //usuarioI.NumeroDocumento = NumeroDocumento;
            //usuarioI.CodigoPais = CodigoPais;
            //usuarioI.Telefono = Telefono;

            //usuario.Usuarios.Add(usuarioI);
            //db.SaveChanges();

            //return ObtenerUsuario(usuarioI);

            foreach (int i in listausuario)
            {
                int cant = db.Usuarios.Where(a => a.IdUsuario == id && a.Usuarios.Count(b => b.IdUsuario == i)>0).Count();
                if (cant != 0)
                {
                    Usuario usuario = db.Usuarios.Find(i);

                    //usuario.Nombre = db.Usuarios.Find(i);
                    //usuario.Apellido = Apellido;
                    //usuario.Correo = Correo;
                    //usuario.Clave = Clave;
                    //usuario.TipoDocumento = TipoDocumento;
                    //usuario.NumeroDocumento = NumeroDocumento;
                    //usuario.CodigoPais = CodigoPais;
                    //usuario.Telefono = Telefono;

                    usuario.Usuarios.Add(usuario);
                    db.SaveChanges();
                }
            }
            return ObtenerUsuario(id);
        }
    }
}