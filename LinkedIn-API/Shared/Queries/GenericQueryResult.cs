namespace Shared.Queries
{
    public class GenericQueryResult : IQueryResult
    {
        public int StatusCode { get; private set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; private set; }
        public object Dados { get; private set; }

        public GenericQueryResult(int statusCode, bool sucesso, string mensagem, object dados)
        {
            StatusCode = statusCode;
            Sucesso = statusCode != 200 ? false : true;
            Mensagem = mensagem;
            Dados = dados;
        }
    }
}
