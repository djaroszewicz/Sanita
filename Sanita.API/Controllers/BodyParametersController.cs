using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;
using Sanita.API.Models.Enums;
using Sanita.Application.BodyParameters.Commands.CreateBodyParameter;
using Sanita.Application.BodyParameters.Queries.GetBodyParameterDetail;

namespace Sanita.API.Controllers
{
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/body-parameters")]
    public class BodyParametersController : BaseController
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
        public async Task<ActionResult<BodyParameterDetailVm>> GetUserBodyParametersDetails(int userId)
        {
            var vm = await Mediator.Send(new GetBodyParameterDetailQuery() { UserId = userId });
            return vm;
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
        /// Create user body parameter
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("creat")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> CreateBodyParameter(CreateBodyParameterCommand command)
        {
            var result = await Mediator.Send(command);

            return Ok(result);
        }
    }
}
