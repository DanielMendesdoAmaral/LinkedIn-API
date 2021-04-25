using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Usuario Buscar(Guid id);
        void Alterar(Usuario usuario);
    }
}
