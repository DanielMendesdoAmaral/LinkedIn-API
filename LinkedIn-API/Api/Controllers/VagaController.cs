using Domain.Handlers.Queries.VagaHandlers;
using Domain.Queries.VagaQueries.Requests;
using Microsoft.AspNetCore.Mvc;
using Shared.Queries;

namespace Api.Controllers
{
    [Route("api/v1/vagas")]
    [ApiController]
    public class VagaController : Controller
    {
        [HttpGet]
        public ObjectResult Get(
            [FromServices] ListarVagasHandler handler
        )
        {
            var query = new ListarVagasRequest();

            return QueryResult( (GenericQueryResult) handler.Handle(query));
        }
    }
}
