using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;
using Sanita.API.Models.Enums;

namespace Sanita.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/body-parameters")]
    public class BodyParametersController : ControllerBase
    {
        /// <summary>
        /// Get user body parameters List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetUserBodyParameters(int userId)
        {
            return "weight: 5, height: 5, abdominal-circumference: 5, thigh-circumference: 5";
        }

        /// <summary>
        /// Get user body parameter
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}/{parameterType}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetUserBodyParameter(int userId, BodyParameters parameterType)
        {
            return "parameter-name: 5";
        }

        /// <summary>
        /// Set user body parameter
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("{userId}/{parameterType}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> SetBodyParameter(int userId, BodyParameters parameterType)
        {
            return "parameter-name: 5";
        }
    }
}
