using System;
using System.Linq;
using System.Runtime.CompilerServices;

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
        public Tabuleiro[] todosMovimentos(int jogador)
        {
            Tabuleiro[] listaTodasPossibilidades = new Tabuleiro[] { };

            Tabuleiro sem = this.testarSemMovimento(jogador);
            if (sem._posicoes != _posicoes)
            {
                listaTodasPossibilidades.Append(sem);
                return listaTodasPossibilidades;
            }

            for (int i=0; i<=6 ;i++)
            {
                if(_posicoes[jogador*7 + i] != 0)
                {
                    Tabuleiro movimentado = new Tabuleiro( _posicoes );
                    listaTodasPossibilidades.Concat(movimentado.movimentar(i,jogador));

                }
            }

            return listaTodasPossibilidades;
        }
        public Tabuleiro[] movimentar(int posicao,int jogador)
        {
            Tabuleiro[] movimentosComplexos = new Tabuleiro[] { };

            int posicaoInicial = 7 * jogador + posicao;

            int bolas = _posicoes[posicaoInicial];
            _posicoes[posicaoInicial] = 0;

            for (int i=1;i<=bolas;i++)
            {
                if (posicaoInicial+i == (6 + (1 - jogador) * 7 ))
                {
                    bolas += 1;
                }
                else
                {
                    int local = (posicaoInicial + i) % 14;
                    _posicoes[local] += 1;
                    
                    if (i == bolas)
                    {
                        if (_posicoes[local] == 1)
                        {
                            _posicoes[local] = 0;
                            int oposto = 12 - local;
                            _posicoes[6 + jogador * 7] += 1 + _posicoes[oposto];
                            _posicoes[oposto] = 0;
                        }else if (local == 6+jogador*7)
                        {
                            return this.todosMovimentos(jogador);
                        }

                    }
                }
            }

            //movimentosComplexos.Append(this) ;
            //movimentosComplexos.Append(new Tabuleiro( this._posicoes ));
            //movimentosComplexos.Concat( new Tabuleiro[] { new Tabuleiro(this._posicoes) } );

            movimentosComplexos = new Tabuleiro[] { new Tabuleiro(this._posicoes) } ;

            return movimentosComplexos;
        }
    }
}
