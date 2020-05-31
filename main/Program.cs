using System;
using System.Collections.Generic;
using mancalalib;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro sem = new Tabuleiro(new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 0 });
            Tabuleiro t = sem.testarSemMovimento(0);

            for (int i=0; i<14;i++)
            {
                Console.WriteLine(t._posicoes[i]);
            }
            

            //Tabuleiro inicial = new Tabuleiro();
            //Arvore arvore = new Arvore();
            //int indiceInicial = arvore.adicinarNo(inicial);
            //Heap heap = new Heap( new List<(int, int)> { (inicial.pontosFavor(), indiceInicial) } );
        }
    }
}
