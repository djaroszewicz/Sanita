using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;

namespace Sanita.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/trainings")]
    public class TrainingsController : ControllerBase
    {
        /// <summary>
        /// Get trainings List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetTrainingsList()
        {
            return "Trainings List";
        }

        /// <summary>
        /// Get training
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{trainingId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetTraining(int trainingId)
        {
            return "Training";
        }

        /// <summary>
        /// Upsert training
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("{trainingId?}/{exerciseList}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> UpsertTraining(string exerciseList, int trainingId = 0)
        {
            //tu w parametrze pojdzie pewnie lista cwiczen, ale nie ma jeszcze modelu wiec daje poki co stringa
            if (trainingId != 0)
            {
                return "Trainig updated";
            }
            return "Training created";
        }

        /// <summary>
        /// Remove training
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("{trainingId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> RemoveTraining(int trainingId)
        {
            return "Training deleted";
        }
    }
}
