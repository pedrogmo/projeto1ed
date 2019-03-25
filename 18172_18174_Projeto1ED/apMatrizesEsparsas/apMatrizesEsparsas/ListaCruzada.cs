using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class ListaCruzada
    {
        Celula cabeca;
        int qtdLinhas, qtdColunas;
        const int indCabeca = 0;

        public int QtdLinhas { get => qtdLinhas; }

        public int QtdColunas { get => qtdColunas; }

        public ListaCruzada(int qtdL, int qtdC)
        {
            if (qtdL <= 0)
                throw new Exception("Quantidade de Linhas inválida");
            if (qtdC <= 0)
                throw new Exception("Quantidade de Colunas inválida");
            qtdColunas = qtdC;
            qtdLinhas = qtdL;
            cabeca = new Celula(0, indCabeca, indCabeca, null, null);
            Celula atual = cabeca;
            for(int c=1; c<=qtdColunas; c++)
            {
                Celula novaCelula = new Celula(0, indCabeca, c, null, null);
                novaCelula.Abaixo = novaCelula;
                atual.Direita = novaCelula;
                atual = novaCelula;
            }
            atual.Direita = cabeca;
            atual = cabeca;
            for (int l = 1; l <= qtdLinhas; l++)
            {
                Celula novaCelula = new Celula(0, l, indCabeca, null, null);
                novaCelula.Direita = novaCelula;
                atual.Abaixo = novaCelula;
                atual = novaCelula;
            }
            atual.Abaixo = cabeca;
        }

        public void Incluir(Celula c)
        {
            if (c.Linha <= indCabeca || c.Linha > qtdLinhas)
                throw new Exception("Linha da célula inválida");
            if (c.Coluna <= indCabeca || c.Coluna > qtdColunas)
                throw new Exception("Coluna da célula inválida");

        }
    }
}
