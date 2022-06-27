using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        [HttpGet]
        [Route("Obtener")]
        public DocumentoDt obtener(int id)
        {
            return Documento.Obtener(id);
        }

        [HttpGet]
        [Route("ListarCodigo")]
        public CodigoDt listarCodigo(int id)
        {
            return Codigo.ListarCodigo(id);
        }

        [HttpGet]
        [Route("ObtenerUsuario")]
        public UsuarioDt obtenerusuario(int id)
        {
            return Usuario.ObtenerUsuario(id);
        }

        [HttpGet]
        [Route("Registro")]
        public UsuarioDt registro(int id, ICollection<int> listausuarios)
        {
           return Usuario.Registro( id, listausuarios);
       }

    }
}
