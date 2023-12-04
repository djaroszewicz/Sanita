using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;

namespace Sanita.API.Controllers
{
    [Route("api/hc")]
    public class HealthChecksController : ControllerBase
    {

        /// <summary>
        /// Check API health
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
