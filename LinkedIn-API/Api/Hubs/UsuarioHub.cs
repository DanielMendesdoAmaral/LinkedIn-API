using Api.Hubs.Clients;
using Domain.Handlers.Queries.UsuarioHandlers;
using Domain.Queries.UsuarioQueries.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shared.Queries;
using System.Threading.Tasks;

namespace Api.Hubs
{
    //Um Hub define métodos que serão chamados por clientes conectados ao servidor. 
    public class UsuarioHub : Hub<IUsuarioClient>
    {
        //O método Get será chamado por um cliente.
        public async Task Get()
        {
            
            var query = new ListarUsuariosRequest();

            //var result = (GenericQueryResult) handler.Handle(query);

            //O método ReceberDados será enviado a todos os clientes a partir da chamada do Get por um ou mais clientes.
            //await Clients.All.ReceberDados(result);
        }
    }
}
