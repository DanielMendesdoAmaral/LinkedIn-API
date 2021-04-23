using Domain.Queries.VagaQueries.Requests;
using Domain.Queries.VagaQueries.Results;
using Domain.Repositories;
using Shared.Handlers;
using Shared.Queries;
using System;
using System.Linq;

namespace Domain.Handlers.Queries.VagaHandlers
{
    public class ListarVagasHandler : IHandlerQuery<ListarVagasRequest>
    {
        private IVagaRepository _vagaRepository { get; }

        public ListarVagasHandler(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public IQueryResult Handle(ListarVagasRequest query)
        {
            try
            {
                var result = _vagaRepository
                             .Listar()
                             .Select(v => new ListarVagasResult(v.Id, v.DataCriacao, v.Titulo, v.Salario, v.Descricao));

                return new GenericQueryResult(200, null, result);
            }
            catch (Exception ex)
            {
                return new GenericQueryResult(500, ex.Message, ex);
            }
        }
    }
}
