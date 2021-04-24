using Shared.Entities;

namespace Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Geolocalização { get; set; }
        public int QtdEntregas { get; private set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string geolocalizacao)
        {
            Nome = nome;
            Email = email;
            Geolocalização = geolocalizacao;
            QtdEntregas = 0;
        }
    }
}
