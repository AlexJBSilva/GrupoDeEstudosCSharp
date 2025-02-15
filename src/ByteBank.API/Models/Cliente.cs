using ByteBank.API.Enums;

namespace ByteBank.API.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        required public string Cpf { get; set; }

        required public string Nome { get; set; }

        required public TipoCliente Tipo { get; set; }

        required public ICollection<Conta> Contas { get; set; }

        required public EnderecoCliente Endereco { get; set; }

        required public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;

        public DateTime? ExcluidoEm { get; set; } = null;

    }
}