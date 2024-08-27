namespace AplicacaoMVCLinq.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly Nascimeto { get; set; }

        public Cliente(int id, string nome, string email, string telefone, DateOnly Nascimento)
        {
            this.ClienteId = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Nascimeto = Nascimento;
        }
    }
}
