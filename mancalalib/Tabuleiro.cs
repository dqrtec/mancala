using System;

namespace mancalalib
{
    public class Tabuleiro
    {
        // jogador = 0 -> player 1
        // jogador = 1 -> player 2
        public int[] _posicoes;
        public Tabuleiro(int[] posicoes){
            _posicoes = posicoes;
        }
        public Tabuleiro(){
            _posicoes = new int[]{4,4,4,4,4,4,0,4,4,4,4,4,4,0};
        }
        public int pontosFavor(){
            return this._posicoes[6];
        }
        public int pontosContra(){
            return this._posicoes[13];
        }

        public Tabuleiro testarSemMovimento(int jogador)
        {
            for(int i = 0; i<6; i++)
            {
                if (_posicoes[jogador*7 + i] != 0)
                {
                    return this;
                }
            }

            Tabuleiro final = new Tabuleiro(_posicoes);
            int jogadorContra = 1 - jogador;
            for (int i = 0; i < 6; i++)
            {
                final._posicoes[6+ jogadorContra * 7] += _posicoes[jogadorContra * 7 + i];
                final._posicoes[jogadorContra * 7 + i] = 0;
            }

            return final;
        }
    }
}
