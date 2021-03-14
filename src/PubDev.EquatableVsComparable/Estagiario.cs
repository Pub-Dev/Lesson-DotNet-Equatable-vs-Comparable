namespace PubDev.EquatableVsComparable
{
    public class Estagiario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Estagiario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
