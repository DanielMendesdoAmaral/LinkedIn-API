using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();
    }
}
