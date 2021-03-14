using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PubDev.EquatableVsComparable
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Pub Dev - Entedendo Equatable e Comparable";

            #region .: IComparable :.

            OrdenarEstagiarios();
            OrdenarProgramadores();

            #endregion .: IComparable :.

            #region .: IComparer :.

            OrdenarProdutosPreco();
            OrdenarProdutosCodigo();

            #endregion .: IComparer :.

            #region .: IEquatable Classes :.

            ContemPessoa();
            ContemAnimal();

            #endregion .: IEquatable Classes :.

            #region .: IEquatable Structs :.

            ContemCor();
            ContemEstrela();

            #endregion .: IEquatable Structs :.

            #region .: IEquatable Structs Performance :.

            ContemCorPerformance();
            ContemEstrelaPerformance();

            #endregion .: IEquatable Structs Performance :.

            Console.ReadKey();
        }

        private static void ContemPessoa()
        {
            var pessoas = new List<Pessoa>()
            {
                new Pessoa("Humberto",26),
                new Pessoa("Rafael", 27),
                new Pessoa("Fernando", 35)
            };

            var pessoaBusca = new Pessoa("Fernando", 27);

            var contem = pessoas.Contains(pessoaBusca);

            Console.WriteLine($"Contem pessoa ?  = {contem}");
        }

        private static void ContemAnimal()
        {
            var animais = new List<Animal>()
            {
                new Animal("Tucano","Ave"),
                new Animal("Baleia", "Mamífero"),
                new Animal("Jacaré", "Réptil")
            };

            var buscaAnimal = new Animal("Jacaré", "Réptil");

            var contem = animais.Contains(buscaAnimal);

            Console.WriteLine($"Contem Animal ?  = {contem}");
        }

        private static void OrdenarProdutosPreco()
        {
            var produtos = new List<Produto>()
            {
                new Produto(1,"Leite",4.5m),
                new Produto(2,"Ovo", 5m),
                new Produto(3,"Agua", 1.5m)
            };

            var produtoComparerPreco = new ProdutoComparerPreco();

            produtos.Sort(produtoComparerPreco);
        }

        private static void OrdenarProdutosCodigo()
        {
            var produtos = new List<Produto>()
            {
                new Produto(2, "Leite",4.5m),
                new Produto(1, "Ovo", 5m),
                new Produto(3, "Agua", 1.5m)
            };

            var produtoComparerPreco = new ProdutoComparerCodigo();

            produtos.Sort(produtoComparerPreco);
        }

        private static void OrdenarEstagiarios()
        {
            var estagiarios = new List<Estagiario>()
            {
                new Estagiario("Humberto",800),
                new Estagiario("Rafael", 1000),
                new Estagiario("Fernando", 650)
            };

            //Exception!
            estagiarios.Sort();
        }

        private static void OrdenarProgramadores()
        {
            var programadores = new List<Programador>()
            {
                new Programador("Henrique", 6500),
                new Programador("William", 6200),
                new Programador("Vinicius", 6500)
            };

            programadores.Sort();

            foreach (var programador in programadores)
            {
                Console.WriteLine($"Nome = {programador.Nome} - Salario {programador.Salario:C}");
            }
        }

        public static void ContemCor()
        {
            var cores = new List<Cor>()
            {
                new Cor("001","Azul"),
                new Cor("002", "Vermelho"),
                new Cor("003", "Verde")
            };

            var buscaCor = new Cor("001", "Azul");

            var contem = cores.Contains(buscaCor);

            Console.WriteLine($"Contem Cor ?  = {contem}");
        }

        public static void ContemCorPerformance()
        {
            var cores = new List<Cor>()
            {
                new Cor("001","Azul"),
                new Cor("002", "Vermelho"),
                new Cor("003", "Verde")
            };

            var buscaCor = new Cor("001", "Azul");

            var cronometro = new Stopwatch();

            cronometro.Start();

            for (int i = 0; i < 10_000_000; i++)
            {
                cores.Contains(buscaCor);
            }

            cronometro.Stop();
            //2342
            Console.WriteLine($"Tempo {cronometro.ElapsedMilliseconds}");
        }

        public static void ContemEstrela()
        {
            var estrelas = new List<Estrela>()
            {
                new Estrela("Sol","8 minutos-luz"),
                new Estrela("Eta Carinae", "7,5 mil anos-luz"),
                new Estrela("VY Canis Majoris", "4.892 anos-luz")
            };

            var buscaEstrela = new Estrela("Sol", "8 minutos-luz");

            var contem = estrelas.Contains(buscaEstrela);

            Console.WriteLine($"Contem Estrela ?  = {contem}");
        }

        public static void ContemEstrelaPerformance()
        {
            var estrelas = new List<Estrela>()
            {
                new Estrela("Sol","8 minutos-luz"),
                new Estrela("Eta Carinae", "7,5 mil anos-luz"),
                new Estrela("VY Canis Majoris", "4.892 anos-luz")
            };

            var buscaEstrela = new Estrela("Sol", "8 minutos-luz");

            var cronometro = new Stopwatch();

            cronometro.Start();

            for (int i = 0; i < 10_000_000; i++)
            {
                estrelas.Contains(buscaEstrela);
            }

            cronometro.Stop();

            //342
            Console.WriteLine($"Tempo {cronometro.ElapsedMilliseconds}");
        }
    }
}