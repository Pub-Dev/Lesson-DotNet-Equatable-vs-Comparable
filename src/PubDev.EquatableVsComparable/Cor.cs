using System.Diagnostics.CodeAnalysis;

namespace PubDev.EquatableVsComparable
{
    public struct Cor
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public Cor(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}