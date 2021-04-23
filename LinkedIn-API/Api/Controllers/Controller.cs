using Microsoft.AspNetCore.Mvc;
using Shared.Queries;

namespace Api.Controllers
{
    public class Controller : ControllerBase
    {
        public ObjectResult QueryResult(GenericQueryResult result)
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
