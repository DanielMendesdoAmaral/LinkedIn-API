using Shared.Entities;

namespace Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }
        public int QtdEntregas { get; private set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string email, decimal latitude, decimal longitude)
        {
            Nome = nome;
            Email = email;
            Latitude = latitude;
            Longitude = longitude;
            QtdEntregas = 0;
        }

        public void MudarGeolocalizacao(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
