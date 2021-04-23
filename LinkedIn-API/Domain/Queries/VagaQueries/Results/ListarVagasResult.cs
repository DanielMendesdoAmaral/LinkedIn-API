using System;

namespace Domain.Queries.VagaQueries.Results
{
    public class ListarVagasResult
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Titulo { get; set; }
        public decimal Salario { get; set; }
        public string Descricao { get; set; }
    }
}
