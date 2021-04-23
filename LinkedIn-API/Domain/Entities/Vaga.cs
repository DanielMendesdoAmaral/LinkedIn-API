using Shared.Entities;

namespace Domain.Entities
{
    public class Vaga : Entity
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Salario { get; private set; }

        public Vaga(string titulo, string descricao, decimal salario)
        {
            Titulo = titulo;
            Descricao = descricao;
            Salario = salario;
        }
    }
}
