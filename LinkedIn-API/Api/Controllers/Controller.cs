using Microsoft.AspNetCore.Mvc;
using Shared.Commands;
using Shared.Queries;

namespace Api.Controllers
{
    public class Controller : ControllerBase
    {
        public ObjectResult Result(GenericQueryResult result)
        {
            return result.StatusCode switch
            {
                200 => Ok(result),
                404 => NotFound(result),
                500 => StatusCode(500, result),
                _ => null
            };
        }

        public ObjectResult Result(GenericCommandResult result)
        {
            return result.StatusCode switch
            {
                200 => Ok(result),
                404 => NotFound(result),
                500 => StatusCode(500, result),
                _ => null
            };
        }
    }
}
