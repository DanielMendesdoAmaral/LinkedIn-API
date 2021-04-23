using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IVagaRepository
    {
        List<Vaga> Listar();
    }
}
