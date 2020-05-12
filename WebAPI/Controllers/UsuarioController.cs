using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [AllowAnonymous]
    public class UsuarioController : MiControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta parametros)
        {
            return await Mediador.Send(parametros);
        }

        [HttpPost("registrar")]
        public async Task<ActionResult<UsuarioData>> Registrar(Registrar.Ejecuta parametros)
        {
            return await Mediador.Send(parametros);
        }

        [HttpGet]
        public async Task<ActionResult<UsuarioData>> DevolverUsuario()
        {
            return await Mediador.Send(new UsuarioActual.Ejecutar());
        }

        [HttpPut]
        public async Task<ActionResult<UsuarioData>> Actualizar(UsuarioActualizar.Ejecuta parametros)
        {
            return await Mediador.Send(parametros);
        }
    }
}