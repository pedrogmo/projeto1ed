using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Incluir(Celula novaCelula)
        {
            if (novaCelula == null)
                throw new Exception("Célula nula");
            novaCelula.Direita = null;
            novaCelula.Abaixo = null;
            if (novaCelula.Linha <= indCabeca || novaCelula.Linha > qtdLinhas)
                throw new Exception("Linha da célula inválida");
            if (novaCelula.Coluna <= indCabeca || novaCelula.Coluna > qtdColunas)
                throw new Exception("Coluna da célula inválida");
            Celula cabecaLinha = cabeca;
            for (int l = 1; l <= novaCelula.Linha; l++)
                cabecaLinha = cabecaLinha.Abaixo;
            Celula cabecaColuna = cabeca;
            for (int c = 1; c <= novaCelula.Coluna; c++)
                cabecaColuna = cabecaColuna.Direita;
            Celula esquerda = cabecaLinha;
            for (int c = 1; c < novaCelula.Coluna; c++)
            {
                if (esquerda.Direita.Coluna == cabecaLinha.Coluna)
                    break;
                esquerda = esquerda.Direita;
            }
            esquerda.Direita = novaCelula;
            Celula acima = cabecaColuna;
            for(int l=1; l<cabeca.Linha; l++)
            {
                if (acima.Abaixo.Linha == cabecaColuna.Linha)
                    break;
                acima = acima.Abaixo;
            }
            acima.Abaixo = novaCelula;
            Celula cabecaLinhaAbaixo = cabecaLinha.Abaixo;
            Celula abaixo = cabecaLinhaAbaixo;
            for(int c=1; c<=novaCelula.Coluna; c++)
            {
                if (abaixo.Direita.Coluna == cabecaLinhaAbaixo.Coluna)
                    break;
                abaixo = abaixo.Direita;
                if (abaixo.Coluna==novaCelula.Coluna)
                {
                    novaCelula.Abaixo = abaixo;
                    break;
                }
            }
            Celula cabecaColunaDireita = cabecaColuna.Direita;
            Celula direita = cabecaColunaDireita;
            for (int l = 1; l <= novaCelula.Linha; l++)
            {
                if (direita.Abaixo.Linha== cabecaColunaDireita.Linha)
                    break;
                direita = direita.Abaixo;
                if (direita.Linha== novaCelula.Linha)
                {
                    novaCelula.Direita = direita;
                    break;
                }
            }
        }

        public void Exibir(ListBox lsb)
        {

        }
    }
}
