using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safra.Application.Interfaces;
using Safra.Application.ViewModels.SimulacaoCredito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Safra.Api.Controllers.V1
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class SimulacaoCreditoController : ControllerBase
    {
        private ISimulacaoCreditoAppServices _service;
        public SimulacaoCreditoController(ISimulacaoCreditoAppServices service)
        {
            _service = service;
        }

        /// <summary>
        /// Simulação de Crédito
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Get([FromQuery] SimulacaoCreditoViewModelPost model)
        {            

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.SimularCredito(model).ConfigureAwait(true));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
    }
}
