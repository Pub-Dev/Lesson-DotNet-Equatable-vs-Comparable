using System.Collections.Generic;

namespace PubDev.EquatableVsComparable
{
    public class ProdutoComparerPreco : IComparer<Produto>
    {
        public int Compare(Produto produtoA, Produto produtoB)
        {
            if (produtoA.Preco > produtoB.Preco)
            {
                return 1;
            }

            if (produtoA.Preco < produtoB.Preco)
            {
                return -1;
            }

            return 0;
        }
    }
}