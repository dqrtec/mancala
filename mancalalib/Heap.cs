using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace mancalalib
{
    public class Heap
    {
        int n = 0;
        List<(int,int)> vetorHeap = new List<(int pontos, int indice) >{};

        public Heap(List<(int, int)> vetorHeap)
        {
            this.n = vetorHeap.Count;
            this.vetorHeap = vetorHeap;
            for (int i=vetorHeap.Count/2; i>=1 ;i--)
            {
                 corrigeDescendo(i);
            }
        }

        public void showValues()
        {
            int potencia = 1;
            int quebras = 1;
            for (int i=1; i<=vetorHeap.Count;i++)
            {
                Console.Write(vetorHeap[i-1].Item1);
                Console.Write(", ");
                if (quebras == i )
                {
                    quebras = quebras + (int)Math.Pow(2, potencia);
                    Console.WriteLine();
                    potencia += 1;
                }
            }
        }

        public void corrigeDescendo(int i)
        {
            var A = this.vetorHeap;

            int j = i;

            while (2*j <= n)
            {
                int f = 2*j;
                if (f<n)
                {
                    if(A[f-1].Item1< A[f].Item1)
                    {
                        f = f + 1;
                    }
                }
                if (A[j-1].Item1 >= A[f-1].Item1)
                {
                    j = n;
                }
                else
                {
                    trocarNo(f, j);
                    j = f;
                }
            }

            this.vetorHeap = A;
        }

        public (int,int) removerNo()
        {
            (int, int) raiz = vetorHeap[0];
            int pontos = raiz.Item1;
            int indice = raiz.Item2;

            vetorHeap[0] = (-vetorHeap[0].Item1, vetorHeap[0].Item2);
            corrigeDescendo(1);

            return (pontos, indice);
        }

        public void trocarNo(int index1, int index2)
        {
            Tuple<int, int> tuplaAuxiliar = new Tuple<int, int>(vetorHeap[index1 - 1].Item1, vetorHeap[index1 - 1].Item2);
            vetorHeap[index1 - 1] = vetorHeap[index2 - 1];
            vetorHeap[index2 - 1] = (tuplaAuxiliar.Item1, tuplaAuxiliar.Item2);
        }

        public void adicionarNo(int pontos, int index)
        {
            vetorHeap.Add((pontos,index));
            n = vetorHeap.Count;

            corrigeSubindo(n);
        }

        public void corrigeSubindo(int i)
        {
            while (i>=2)
            {
                if((vetorHeap[i - 1].Item1 > vetorHeap[(i / 2) - 1].Item1))
                {
                    trocarNo(i, i / 2);
                    i = i / 2;
                }
            }
        }
    }
}
