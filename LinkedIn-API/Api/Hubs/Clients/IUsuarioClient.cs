using Shared.Commands;
using System.Threading.Tasks;

namespace Api.Hubs.Clients
{
    public interface IUsuarioClient
    {
        Task ReceberLocalizacao(GenericCommandResult commandResult);
    }
}
