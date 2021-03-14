using System;

namespace PubDev.EquatableVsComparable
{
    public class Animal : IEquatable<Animal>
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Animal(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public bool Equals(Animal outroAnimal)
        {
            if (Nome == outroAnimal.Nome && Tipo == outroAnimal.Tipo)
            {
                return true;
            }

            return false;
        }
    }
}