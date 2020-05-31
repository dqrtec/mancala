using System;
using System.Collections.Generic;
using mancalalib;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro sem = new Tabuleiro(new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 });
            //Tabuleiro[] todos = sem.movimentar(4, 0);
            Tabuleiro[] todos = sem.todosMovimentos(0);

            Console.WriteLine(todos.Length);

            for (int t=0; t<todos.Length ; t++)
            {
                Console.Write("Tabuleiro ");
                Console.WriteLine(t);
                for (int i = 0; i < 14; i++)
                {
                    Console.Write(todos[t]._posicoes[i]);
                }
                Console.WriteLine();
            }
            Console.Write("z");



            //Tabuleiro inicial = new Tabuleiro();
            //Arvore arvore = new Arvore();
            //int indiceInicial = arvore.adicinarNo(inicial);
            //Heap heap = new Heap( new List<(int, int)> { (inicial.pontosFavor(), indiceInicial) } );
        }
    }
}
