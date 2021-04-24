using Api.Hubs.Clients;
using Domain.Handlers.Queries.UsuarioHandlers;
using Domain.Queries.UsuarioQueries.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shared.Queries;
using System.Threading.Tasks;

namespace Api.Hubs
{
    public class UsuarioHub : Hub<IUsuarioClient>
    {
        public async Task Get([FromServices] ListarUsuariosHandler handler)
        {
            var query = new ListarUsuariosRequest();

            var result = (GenericQueryResult)handler.Handle(query);

            await Clients.All.ReceberDados(result);
        }
    }
}
