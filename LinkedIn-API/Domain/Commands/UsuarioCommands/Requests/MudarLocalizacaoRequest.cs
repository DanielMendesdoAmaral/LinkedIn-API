using Shared.Commands;
using System;

namespace Domain.Commands.UsuarioCommands.Requests
{
    public class MudarLocalizacaoRequest : ICommand
    {
        public Guid Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public void Validar(){}
    }
}
