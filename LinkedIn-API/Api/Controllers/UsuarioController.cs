using Domain.Handlers.Queries.UsuarioHandlers;
using Domain.Queries.UsuarioQueries.Requests;
using Microsoft.AspNetCore.Mvc;
using Shared.Queries;

namespace Api.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ObjectResult Get(
            [FromServices] ListarUsuariosHandler handler
        )
        {
            var query = new ListarUsuariosRequest();

            return QueryResult( (GenericQueryResult) handler.Handle(query));
        }
    }
}
