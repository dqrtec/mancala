using System;
using Xunit;

using mancalalib;

namespace mancalalib.Testes
{
    public class Pontos
    {
        [Fact]
        public void Test1()
        {
            Tabuleiro c1= new Tabuleiro();
            bool valor = c1.retornTrue();

            Assert.False(valor, "o valor tem que ser true");
        }
    }
}
