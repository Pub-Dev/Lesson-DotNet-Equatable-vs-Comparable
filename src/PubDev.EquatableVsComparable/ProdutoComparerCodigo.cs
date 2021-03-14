using System.Collections.Generic;

namespace PubDev.EquatableVsComparable
{
    public class ProdutoComparerCodigo : IComparer<Produto>
    {
        public int Compare(Produto produtoA, Produto produtoB)
        {
            if (produtoA.Codigo > produtoB.Codigo)
            {
                return 1;
            }

            if (produtoA.Codigo < produtoB.Codigo)
            {
                return -1;
            }

            return 0;
        }
    }
}