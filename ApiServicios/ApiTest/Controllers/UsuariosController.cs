using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Dto;
using ApiTest.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IServicioUsuarios _IServicioUsuarios;

        public UsuariosController(IServicioUsuarios _IServicioUsuarios)
        {
            this._IServicioUsuarios = _IServicioUsuarios;
        }

        [HttpGet("usuario")]
        public async Task<IActionResult> ObtenerUsuario()
        {
            try
            {
                var Result = await _IServicioUsuarios.ObtenerUsuario();
                return Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = "Error obteniendo Usuario", MensajeError = ex.Message });
            }
            
        }

        [HttpGet("lista-usuario")]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            try
            {
                var Result = await _IServicioUsuarios.ObtenerUsuariosFecha();
                return Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = "Error obteniendo Usuario", MensajeError = ex.Message });
            }
        }

        [HttpPost("actualizar-usuario")]
        public async Task<IActionResult> Actualizar([FromBody] DtoUsuarios Usuario)
        {
            try
            {
                var Result = await _IServicioUsuarios.Actualizar(Usuario.Id, Usuario.Nombre);
                return Ok(Usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = "Error obteniendo Usuario", MensajeError = ex.Message });
            }
        }

    }
}
