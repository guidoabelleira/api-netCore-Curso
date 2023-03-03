using Microsoft.AspNetCore.Mvc;

namespace apiWeb_NetCore.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            // codigo...

            return new
            {
                nombre = "Guido",
                edad = "29"
            };
        }

        //[HttpPost]
        //[Route("guardar")]
        //public dynamic guardarCliente()
        //{

        //}
    }
}
