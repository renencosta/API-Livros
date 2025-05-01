namespace ProjetoLivros.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string? Telefone { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        //chave estrangeira
        public int TipoUsuarioId { get; set; }

        //objeto que tem relacao com outra tabela, permite navegacao
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
