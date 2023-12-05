using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;

namespace Sanita.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/exercises")]
    public class ExercisesController : ControllerBase
    {
        /// <summary>
        /// Get exercises List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetExercisesList()
        {
            return "Exercises List";
        }

        /// <summary>
        /// Get exercise
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{exerciseId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetExercise(int exerciseId)
        {
            return "Exercise";
        }

        /// <summary>
        /// Upsert exercise
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("{exerciseId?}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> UpsertExercise(int exerciseId = 0)
        {
            //tu w parametrze pojdzie pewnie lista cwiczen, ale nie ma jeszcze modelu wiec daje poki co stringa
            if (exerciseId != 0)
            {
                return "Exercise updated";
            }
            return "Exercise created";
        }

        /// <summary>
        /// Remove exercise
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("{exerciseId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> RemoveExercise(int exerciseId)
        {
            return "Exercise deleted";
        }
    }
}
