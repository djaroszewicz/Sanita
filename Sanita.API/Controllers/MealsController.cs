using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models.Enums;
using Sanita.API.Models;

namespace Sanita.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/meals")]
    public class MealsController : ControllerBase
    {
        /// <summary>
        /// Get meals List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetMealsList()
        {
            return "Meals List";
        }

        /// <summary>
        /// Get random meal
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-random")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetRandomMeal()
        {
            return "Random meal";
        }

        /// <summary>
        /// Upsert meal
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("{mealId?}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> UpsertMeal(int mealId = 0)
        {
            if (mealId != 0)
            {
                return "Meal updated";
            }
            return "Meal created";
        }

        /// <summary>
        /// Remove meal
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("{mealId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> RemoveMeal(int mealId)
        {
            return "Meal deleted";
        }
    }
}
