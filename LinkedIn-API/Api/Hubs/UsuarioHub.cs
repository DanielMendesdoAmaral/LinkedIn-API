using Api.Hubs.Clients;
using Domain.Commands.UsuarioCommands.Requests;
using Domain.Handlers.Commands.UsuarioHandlers;
using Microsoft.AspNetCore.SignalR;
using Shared.Commands;
using System.Threading.Tasks;

namespace Api.Hubs
{
    //Um Hub define métodos que serão chamados por clientes conectados ao servidor. 
    public class UsuarioHub : Hub<IUsuarioClient>
    {
        private readonly MudarLocalizacaoHandler _mudarLocalizacaoHandler;

        public UsuarioHub(MudarLocalizacaoHandler mudarLocalizacaoHandler)
        {
            _mudarLocalizacaoHandler = mudarLocalizacaoHandler;
        }

        //O método MudarLocalizacao será chamado por um cliente.
        public async Task MudarLocalizacao(MudarLocalizacaoRequest command)
        {
            var result = (GenericCommandResult) _mudarLocalizacaoHandler.Handle(command);

            //O método ReceberLocalizacao será enviado a todos os clientes a partir da chamada do Get por um ou mais clientes.
            await Clients.All.ReceberLocalizacao(result);
        }
    }
}
