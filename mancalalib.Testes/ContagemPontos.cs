using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;

namespace mancalalib.Testes
{
    public class ContagemPontos
    {
        Tabuleiro _tabuleiro;
        public ContagemPontos()
        {
            _tabuleiro = new Tabuleiro();
        }

        [Fact]
        public void TesteBase()
        {
            Assert.Equal(0, _tabuleiro.pontosFavor());

        }
    }
}
