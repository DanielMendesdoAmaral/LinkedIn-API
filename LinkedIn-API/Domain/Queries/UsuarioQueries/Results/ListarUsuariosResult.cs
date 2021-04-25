using System;

namespace Domain.Queries.UsuarioQueries.Results
{
    public class ListarUsuariosResult
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int QtdEntregas { get; set; }

        public ListarUsuariosResult(Guid id, DateTime dataCriacao, string nome, string email, decimal latitude, decimal longitude, int qtdEntregas)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Nome = nome;
            Email = email;
            Latitude = latitude;
            Longitude = longitude;
            QtdEntregas = qtdEntregas;
        }
    }
}
