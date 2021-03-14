using System;

namespace PubDev.EquatableVsComparable
{
    public class Programador : IComparable<Programador>
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Programador(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public int CompareTo(Programador outroProgramador)
        {
            if (Salario == outroProgramador.Salario)
                return 0;

            if (Salario > outroProgramador.Salario)
                return 1;

            return -1;
        }
    }
}
