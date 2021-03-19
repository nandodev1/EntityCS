namespace EntityCS
{
    public class Cliente : Pessoa
    {
        public double credito { get; set; }
        public Cliente ( uint id, string cpf, string nome, double credito)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.credito = credito;
        }
    }
}