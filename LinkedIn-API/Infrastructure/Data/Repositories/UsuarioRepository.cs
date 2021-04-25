using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
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

        public Usuario Buscar(Guid id)
        {
            return
                _context
                .Usuarios
                .Find(id);
        }

        public void Alterar(Usuario usuario)
        {
            _context
                .Entry(usuario)
                .State = EntityState.Modified;

            _context
                .SaveChangesAsync();
        }
    }
}
