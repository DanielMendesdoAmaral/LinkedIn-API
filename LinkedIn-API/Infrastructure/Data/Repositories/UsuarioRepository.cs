using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private RadarContext _context { get; }

        public UsuarioRepository(RadarContext context)
        {
            _context = context;
        }

        public List<Usuario> Listar()
        {
            return 
                _context
                .Usuarios
                .ToList();
        }
    }
}
