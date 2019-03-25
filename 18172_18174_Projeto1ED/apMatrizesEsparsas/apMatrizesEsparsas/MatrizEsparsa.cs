using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class MatrizEsparsa
    {
        int qtdLinhas, qtdColunas;
        ListaCircularCelula[] linhas, colunas;

        public ListaCircularCelula ListaLinha(int i)
        {
            if (i < 0 || i >= qtdLinhas)
                throw new Exception("Índice de linha inválido");
            return linhas[i];
        }

        public ListaCircularCelula ListaColuna(int i)
        {
            if (i < 0 || i >= qtdColunas)
                throw new Exception("Índice de coluna inválido");
            return colunas[i];
        }

        public int QtdLinhas { get => qtdLinhas; }

        public int QtdColunas { get => qtdColunas; }

        public MatrizEsparsa(int qtdL, int qtdC)
        {

        }

        public MatrizEsparsa SomaConstante(double k)
        {

        }

        public MatrizEsparsa SomaMatriz(MatrizEsparsa b)
        {
            if (b == null)
                throw new Exception("Matriz B nula");
        }

        public MatrizEsparsa MultiplicacaoConstante(double k)
        {

        }

        public MatrizEsparsa MultiplicacaoMatriz(MatrizEsparsa b)
        {
            if (b == null)
                throw new Exception("Matriz B nula");
        }
    }
}
