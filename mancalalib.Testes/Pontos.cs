using System;
using Xunit;

using mancalalib;

namespace mancalalib.Testes
{
    public class Pontos
    {
        Tabuleiro _tabuleiro;
        public Pontos()
        {
            _tabuleiro = new Tabuleiro();
        }

        [Fact]
        public void TestePontosFavor()
        {
            Assert.Equal(_tabuleiro._posicoes[6], _tabuleiro.pontosFavor());
        }

        [Fact]
        public void TestePontosContra()
        {
            Assert.Equal(_tabuleiro._posicoes[13], _tabuleiro.pontosContra());
        }
    }
}
