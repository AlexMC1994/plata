using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    [EnableCors("WEBVUE")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerDocId")]
        public DocumentoDt ObtenerDocId(int id)
        {
            return Documento.ObtenerDocId(id);
        }

        [HttpGet]
        [Route("ListaDoc")]
        public ICollection<DocumentoDt> ListaDoc()
        {
            return Documento.ListaDoc();
        }


        [HttpGet]
        [Route("ObtenerCodigoId")]
        public CodigoDt ObtenerCodigoId(int id)
        {
            return Codigo.ObtenerCodigoId(id);
        }

        [HttpGet]
        [Route("ListaCodigo")]
        public ICollection<CodigoDt> ListaCodigo()
        {
            return Codigo.ListaCodigo();
        }


        [HttpGet]
        [Route("ObtenerUsuarioId")]
        public UsuarioDt ObtenerUsuarioId(int id)
        {
            return Usuario.ObtenerUsuarioId(id);
        }

        [HttpGet]
        [Route("ListaUsuario")]
        public ICollection<UsuarioDt> ListaUsuario()
        {
            return Usuario.ListaUsuario();
        }

        [HttpPost]
        [Route("Registro")]
        public UsuarioDt registro(UsuarioDt usuarioDt)
        {
           return Usuario.Registro(usuarioDt);
       }

    }
}
