using Shared.Queries;
using System.Threading.Tasks;

namespace Api.Hubs.Clients
{
    public interface IUsuarioClient
    {
        Task ReceberDados(GenericQueryResult queryResult);
    }
}
