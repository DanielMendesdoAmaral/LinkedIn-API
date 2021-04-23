using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class VagaRepository : IVagaRepository
    {
        private LinkedInContext _context { get; }

        public VagaRepository(LinkedInContext context)
        {
            _context = context;
        }

        public List<Vaga> Listar()
        {
            return 
                _context
                .Vagas
                .ToList();
        }
    }
}
