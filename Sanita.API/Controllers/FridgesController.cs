using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sanita.API.Models;
using Sanita.API.Models.Enums;

namespace Sanita.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigin")]
    [Route("api/fridges")]
    public class FridgesController : ControllerBase
    {
        /// <summary>
        /// Get All Products with count
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetAllProductList(int userId)
        {
            return "Products list quantity";
        }


        /// <summary>
        /// Get product quantity
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}/{productId}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> GetProductCount(int userId, int productId)
        {
            return "Product quantity";
        }

        /// <summary>
        /// Put product to fridge
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("{userId}/{productId?}/{quantity}/{unit}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType((StatusCodes.Status201Created))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> AddProduct(int userId, decimal quantity, ProductUnit unit, int productId = 0)
        {
            //Tutaj zastanawiam się jeszcze nad podejsciem, czy rozdzielic na post/patch czy zostac przy opcji upsertu
            if (productId != 0)
            {
                return "Product updated";
            }

            return "Product created";
        }

        /// <summary>
        /// Remove product from fridge
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}/{quantity?}/{unit}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType((StatusCodes.Status404NotFound))]
        public async Task<ActionResult<string>> RemoveProduct(int id, ProductUnit unit, decimal quantity = 0)
        {
            return "Product deleted";
        }
    }
}
