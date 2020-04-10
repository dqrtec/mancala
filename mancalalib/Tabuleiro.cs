using System;

namespace mancalalib
{
    public class Tabuleiro
    {
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

        // public Tabuleiro Movimentar(int jogador, int posicao){
        //     int[] posicoes = this._posicoes;
        //     int jogada = jogador*7 + posicao;
        //     int bolas = posicoes[jogada];
        //     posicoes[jogada] = 0;
        //     for (int i = 1; i <= bolas; i++)
        //     {
        //         int adicionar = (jogada+i)%14;
        //         posicoes[adicionar] += 1;
        //         if(i == bolas){
                    
        //         }
        //     }

        //     return new Tabuleiro(posicoes);
        // }
    }
}
