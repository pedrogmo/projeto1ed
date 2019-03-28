﻿using System;
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

        private bool ExisteCelula(Celula cabecaLinha, Celula cabecaColuna, ref Celula esquerda, ref Celula acima)
        {            
            esquerda = cabecaLinha;
            while (esquerda.Direita.Coluna < cabecaColuna.Coluna && esquerda.Direita.Coluna>cabecaLinha.Coluna)
                esquerda = esquerda.Direita;
            acima = cabecaColuna;
            while (acima.Abaixo.Linha < cabecaLinha.Linha && acima.Abaixo.Linha>cabecaColuna.Linha)
                acima = acima.Abaixo;
            return esquerda.Direita.Coluna == cabecaColuna.Coluna;
        }

        public void Incluir(Celula novaCelula)
        {
            if (novaCelula == null)
                throw new Exception("Célula nula");            
            if (novaCelula.Linha <= indCabeca || novaCelula.Linha > qtdLinhas)
                throw new Exception("Linha da célula inválida");
            if (novaCelula.Coluna <= indCabeca || novaCelula.Coluna > qtdColunas)
                throw new Exception("Coluna da célula inválida");            
            Celula esquerda = null, acima = null;
            Celula cabecaLinha = cabeca;
            for (int l = 1; l <= novaCelula.Linha; l++)
                cabecaLinha = cabecaLinha.Abaixo;
            novaCelula.Direita = cabecaLinha;
            Celula cabecaColuna = cabeca;
            for (int c = 1; c <= novaCelula.Coluna; c++)
                cabecaColuna = cabecaColuna.Direita;            
            novaCelula.Abaixo = cabecaColuna;
            if (ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                throw new Exception("Célula já existente");
            esquerda.Direita = novaCelula;
            acima.Abaixo = novaCelula;
            if (novaCelula.Linha < qtdLinhas)
            {
                Celula cabecaLinhaAbaixo = cabecaLinha.Abaixo;
                Celula abaixo = cabecaLinhaAbaixo;
                do
                {
                    abaixo = abaixo.Direita;
                    if (abaixo.Coluna == novaCelula.Coluna)
                    {
                        novaCelula.Abaixo = abaixo;
                        break;
                    }                    
                } while (abaixo.Direita.Coluna != cabecaLinhaAbaixo.Coluna);
            }
            else
                novaCelula.Abaixo = cabecaColuna;
            if (novaCelula.Coluna < qtdColunas)
            {
                Celula cabecaColunaDireita = cabecaColuna.Direita;
                Celula direita = cabecaColunaDireita;
                do
                {
                    direita = direita.Abaixo;
                    if (direita.Linha == novaCelula.Linha)
                    {
                        novaCelula.Direita = direita;
                        break;
                    }                    
                } while (direita.Abaixo.Linha != cabecaColunaDireita.Linha);
            }
            else
                novaCelula.Direita = cabecaLinha;
        }

        public void Exibir(DataGridView dgv)
        {
            if (dgv == null)
                throw new Exception("DataGridView nulo");
            dgv.Rows.Clear();
            dgv.RowCount = qtdLinhas;
            dgv.ColumnCount = qtdColunas;
            Celula cabecaColuna = cabeca.Direita;
            while(cabecaColuna.Coluna!=cabeca.Coluna)
            {
                Celula atual = cabecaColuna.Abaixo;
                while (atual.Linha!=cabecaColuna.Linha)
                {
                    dgv.Rows[atual.Linha - 1].Cells[atual.Coluna - 1].Value = atual.Valor;
                    atual = atual.Abaixo;
                }
                cabecaColuna = cabecaColuna.Direita;
            }
        }

        public double ValorDe(int linha, int coluna)
        {
            if (linha <= indCabeca || linha > qtdLinhas)
                throw new Exception("Linha inválida");
            if (coluna <= indCabeca || coluna > qtdColunas)
                throw new Exception("Coluna inválida");
            Celula cabecaLinha=cabeca, cabecaColuna=cabeca, esquerda=null, acima=null;
            for (int l = 1; l <= linha; l++)
                cabecaLinha = cabecaLinha.Abaixo;
            for (int c = 1; c <= coluna; c++)
                cabecaColuna = cabecaColuna.Direita;
            if (!ExisteCelula(cabecaLinha,cabecaColuna,ref esquerda,ref acima))
                throw new Exception("Celula inexistente");
            return esquerda.Direita.Valor;
        }
    }
}
