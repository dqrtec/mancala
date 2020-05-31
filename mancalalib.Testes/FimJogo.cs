using System;
using Xunit;

using mancalalib;

namespace mancalalib.Testes
{
    public class FimJogo
    {
        Tabuleiro _tabuleiro;
        public FimJogo()
        {
            _tabuleiro = new Tabuleiro();
        }

        [Fact]
        public void SemJogadas()
        {
            Tabuleiro sem = new Tabuleiro( new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 0 } );
            int jogador = 0;
            Tabuleiro final = sem.testarSemMovimento(jogador);
            Assert.Equal(21, final.pontosContra());
        }
    }
}
