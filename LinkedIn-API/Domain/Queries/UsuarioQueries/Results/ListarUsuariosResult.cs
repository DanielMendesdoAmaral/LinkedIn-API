using System;

namespace Domain.Queries.UsuarioQueries.Results
{
    public class ListarUsuariosResult
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Geolocalização { get; set; }
        public int QtdEntregas { get; set; }

        public ListarUsuariosResult(Guid id, DateTime dataCriacao, string nome, string email, string geolocalização, int qtdEntregas)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Nome = nome;
            Email = email;
            Geolocalização = geolocalização;
            QtdEntregas = qtdEntregas;
        }
    }
}
