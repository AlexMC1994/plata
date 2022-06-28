using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    [EnableCors("api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {


        [HttpGet]
        [Route("BuscaOfertaID")]
        public OfertumDt BuscaOfertaID(int id)
        {
            return Ofertum.BuscaOfertaID( id);
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


        [HttpPost]
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
