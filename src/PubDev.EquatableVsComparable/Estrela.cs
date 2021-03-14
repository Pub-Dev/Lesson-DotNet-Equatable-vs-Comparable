using System;

namespace PubDev.EquatableVsComparable
{
    public struct Estrela : IEquatable<Estrela>
    {
        public string Nome { get; set; }
        public string DistanciaTerra { get; set; }

        public Estrela(string nome, string distanciaTerra)
        {
            Nome = nome;
            DistanciaTerra = distanciaTerra;
        }

        public bool Equals(Estrela outraEstrela)
        {
            return Nome == outraEstrela.Nome && DistanciaTerra == outraEstrela.DistanciaTerra;
        }
    }
}