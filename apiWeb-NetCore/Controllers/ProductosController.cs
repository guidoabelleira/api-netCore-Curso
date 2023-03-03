using apiWeb_NetCore.Datos;
using apiWeb_NetCore.Modelo;
using Microsoft.AspNetCore.Mvc;
namespace apiWeb_NetCore.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController:ControllerBase
    {
        [HttpGet]
        public async Task <ActionResult<List<Mproductos>>> Get()
        {
            var funcion = new Dproductos(); 
            var lista = await funcion.Mostrarproductos();
            return lista;
        }
        [HttpPost]
        public async Task Post([FromBody] Mproductos parametros)
        {
            var funcion = new Dproductos();
            await funcion.InsertarProductos(parametros);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Mproductos parametros)
        {
            var funcion = new Dproductos();
            parametros.id = id;
            await funcion.EditarProductos(parametros);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var funcion = new Dproductos();
            var parametros = new Mproductos();
            parametros.id = id;
            await funcion.EliminarProducto(parametros);
            return NoContent();
        }
    }
}
