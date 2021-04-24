using Domain.Queries.UsuarioQueries.Requests;
using Domain.Queries.UsuarioQueries.Results;
using Domain.Repositories;
using Shared.Handlers;
using Shared.Queries;
using System;
using System.Linq;

namespace Domain.Handlers.Queries.UsuarioHandlers
{
    public class ListarUsuariosHandler : IHandlerQuery<ListarUsuariosRequest>
    {
        private IUsuarioRepository _usuarioRepository { get; }

        public ListarUsuariosHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IQueryResult Handle(ListarUsuariosRequest query)
        {
            try
            {
                var result = _usuarioRepository
                             .Listar()
                             .Select(u => new ListarUsuariosResult(u.Id, u.DataCriacao, u.Nome, u.Email, u.Geolocalização, u.QtdEntregas));

                return new GenericQueryResult(200, null, result);
            }
            catch (Exception ex)
            {
                return new GenericQueryResult(500, ex.Message, ex);
            }
        }
    }
}
