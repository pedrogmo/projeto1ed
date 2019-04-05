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
            if (novaCelula.Valor == 0)
                throw new Exception("Valor da célula não pode ser 0");
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
            InserirCelula(novaCelula, cabecaLinha, cabecaColuna);
        }        

        public void Exibir(DataGridView dgv)
        {
            if (dgv == null)
                throw new Exception("DataGridView nulo");
            dgv.Rows.Clear();
            dgv.RowCount = qtdLinhas;
            dgv.ColumnCount = qtdColunas;
            Celula cabecaColuna = cabeca.Direita;
            //preenche matriz com 0       
            for (int l = 0; l < qtdLinhas; l++)
            {
                dgv.Rows[l].HeaderCell.Value = (l+1) + "";
                for (int c = 0; c < qtdColunas; c++)
                {
                    if (l==0)
                        dgv.Columns[c].HeaderText = (c + 1) + "";
                    dgv.Rows[l].Cells[c].Value = "0";
                }
            }
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            while (cabecaColuna.Coluna!=cabeca.Coluna)
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
            if (!ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                return 0;
            return esquerda.Direita.Valor;
        }

        public void Excluir(int linha, int coluna)
        {
            if (linha <= indCabeca || linha > qtdLinhas)
                throw new Exception("Linha inválida");
            if (coluna <= indCabeca || coluna > qtdColunas)
                throw new Exception("Coluna inválida");
            Celula cabecaLinha = cabeca, cabecaColuna = cabeca, esquerda = null, acima = null;
            for (int l = 1; l <= linha; l++)
                cabecaLinha = cabecaLinha.Abaixo;
            for (int c = 1; c <= coluna; c++)
                cabecaColuna = cabecaColuna.Direita;
            if (!ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                throw new CelulaInexistenteException("Célula inexistente");
            acima.Abaixo = acima.Abaixo.Abaixo;
            esquerda.Direita = esquerda.Direita.Direita;
        }

        public void Limpar()
        {
            for (Celula coluna = cabeca.Direita; coluna.Coluna != cabeca.Coluna; coluna = coluna.Direita)
                coluna.Abaixo = coluna;
            for (Celula linha = cabeca.Abaixo; linha.Linha != cabeca.Linha; linha = linha.Abaixo)
                linha.Direita = linha;
        }                

        private void InserirCelula(Celula novaCelula, Celula cabecaLinha, Celula cabecaColuna)
        {
            novaCelula.Abaixo = cabecaColuna;
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
            novaCelula.Direita = cabecaLinha;
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
        }

        public void SomarEmColuna(double k, int coluna)
        {
            if (coluna <= indCabeca || coluna > qtdColunas)
                throw new Exception("Coluna inválida");
            if (k != 0) //se o valor for 0, nada é feito
            {
                Celula cabecaColuna = cabeca;
                for (int c = 1; c <= coluna; c++)
                    cabecaColuna = cabecaColuna.Direita;
                Celula esquerda = null, acima = null, cabecaLinha = cabeca.Abaixo;
                while (cabecaLinha.Linha != cabeca.Linha)
                {
                    if (ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                        esquerda.Direita.Valor += k;
                    else
                    {
                        Celula nova = new Celula(k, cabecaLinha.Linha, cabecaColuna.Coluna, null, null);
                        esquerda.Direita = nova;
                        acima.Abaixo = nova;
                        InserirCelula(nova, cabecaLinha, cabecaColuna);
                    }
                    cabecaLinha = cabecaLinha.Abaixo;
                }
            }
        }

        public ListaCruzada SomaMatriz(ListaCruzada outra)
        {
            if (outra.qtdLinhas != this.qtdLinhas)
                throw new Exception("Quantidade diferente de linhas das matrizes");
            if (outra.qtdColunas != this.qtdColunas)
                throw new Exception("Quantidade diferentes de colunas das matrizes");
            ListaCruzada ret = new ListaCruzada(qtdLinhas,qtdColunas);
            //operação
             
            Celula cabecaColunaA = cabeca.Direita;
            Celula cabecaColunaB = outra.cabeca.Direita;

            Celula atualA = cabecaColunaA.Abaixo;
            Celula atualB = cabecaColunaB.Abaixo;

            for (int c = 1; c <= qtdColunas; c++)
            {
                for (int l = 1; l <= qtdLinhas; l++)
                {
                    if (atualA.Linha == cabecaColunaA.Linha || atualB.Linha == cabecaColunaB.Linha)
                        break;
                    if (atualA.Linha == atualB.Linha)
                    {
                        ret.Incluir(new Celula(atualA.Valor + atualB.Valor, atualA.Linha, atualB.Coluna, null, null));
                        atualA = atualA.Abaixo;
                        atualB = atualB.Abaixo;
                    }
                    if (atualA.Linha > atualB.Linha)
                        atualB = atualB.Abaixo;
                    if (atualA.Linha < atualB.Linha)
                        atualA = atualA.Abaixo;                                        
                }
                cabecaColunaA = cabecaColunaA.Direita;
                cabecaColunaB = cabecaColunaB.Direita;
                atualA = cabecaColunaA.Abaixo;
                atualB = cabecaColunaB.Abaixo;

            }

            return ret;
        }

        public ListaCruzada MultiplicacaoMatriz(ListaCruzada outra)
        {
            if (this.qtdColunas != outra.qtdLinhas)
                throw new Exception("Quantidade de colunas diferente da quantidade de linhas da segunda matriz");
            ListaCruzada ret = new ListaCruzada(qtdLinhas, outra.qtdColunas);
            //operação
            return ret;
        }
    }
}
