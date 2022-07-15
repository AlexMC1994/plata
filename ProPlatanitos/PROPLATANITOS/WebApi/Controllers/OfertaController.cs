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
    public class OfertaController : ControllerBase
    {

        [HttpGet]
        [Route("ListarCategoria")]
        public ICollection<CategoriumDt> ListarCategoria()
        {
            return Categorium.ListarCategoria();
        }


        [HttpGet]
        [Route("ObtenOferta")]
        public OfertumDt ObtenOferta(int id)
        {
            return Ofertum.ObtenOferta(id);
        }

        [HttpGet]
        [Route("ListaOferta")]
        public ICollection<OfertumDt> ListaOferta()
        {
            return Ofertum.ListaOferta();
        }


        [HttpPost]
        [Route("AgregarOferta")]
        public OfertumDt AgregarOferta(OfertumDt ofertumDt)
        {
            return Ofertum.AgregarOferta(ofertumDt);
        }


        [HttpPut]
        [Route("ActualizaOferta")]
       public OfertumDt ActualizaOferta(int id, OfertumDt ofertumDt)
       {
           return Ofertum.ActualizaOferta(id, ofertumDt);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public Boolean Eliminar(int IdOferta)
        {
            if (IdOferta > 0)
                return Ofertum.Eliminar(IdOferta);
            else
                return false ;
        }
    }
}
