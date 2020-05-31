    using System;
using System.Collections.Generic;
using System.Text;

namespace mancalalib
{
    public class Arvore
    {
        List<int> listaPais;
        List<Tabuleiro> listaTabuleiros;

        public int adicinarNo(Tabuleiro tabuleiro, int indexPai = 0)
        {
            listaPais.Add(indexPai);
            listaTabuleiros.Add(tabuleiro);
            int index = listaTabuleiros.IndexOf(tabuleiro);
            return index;
        }
    }
}
