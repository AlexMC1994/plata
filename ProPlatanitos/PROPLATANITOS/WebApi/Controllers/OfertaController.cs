using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        [HttpGet]
        [Route("ActualizaOferta")]
       public OfertumDt ActualizaOferta(int id, ICollection<int> listaoferta)
       {
           return Ofertum.ActualizaOferta(id, listaoferta);
        }

    }
}
