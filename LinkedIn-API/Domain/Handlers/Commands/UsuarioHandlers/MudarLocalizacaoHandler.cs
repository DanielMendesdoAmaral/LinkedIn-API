using Domain.Commands.UsuarioCommands.Requests;
using Domain.Repositories;
using Shared.Commands;
using System;
using static Shared.Handlers.IHandlerCommand;

namespace Domain.Handlers.Commands.UsuarioHandlers
{
    public class MudarLocalizacaoHandler : IHandlerCommand<MudarLocalizacaoRequest>
    {
        private readonly IUsuarioRepository _repository;

        public MudarLocalizacaoHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(MudarLocalizacaoRequest command)
        {
            try
            {
                var usuario = _repository.Buscar(command.Id);
                usuario.MudarGeolocalizacao(command.Latitude, command.Longitude);
                //_repository.Alterar(usuario); Talvez para isso não precise bater no banco...
                return new GenericCommandResult(200, null, usuario);
            }
            catch (Exception ex)
            {
                return new GenericCommandResult(500, null, null);
            }
        }
    }
}
