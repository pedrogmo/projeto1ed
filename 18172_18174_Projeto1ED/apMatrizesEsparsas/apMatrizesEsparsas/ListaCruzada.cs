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
        //Atributos que indicam a cabeça Lista, número de linhas e colunas e uma constante
        //para o índice da cabeça.
        Celula cabeca;
        int qtdLinhas, qtdColunas;
        const int indCabeca = 0;


        //Propriedades para obtenção dos números de linhas e colunas: 
        public int QtdLinhas { get => qtdLinhas; }
        public int QtdColunas { get => qtdColunas; }


        // Construtor da classe:
        public ListaCruzada(int qtdL, int qtdC)
        {
            //Verificações das quantidades de linhas e colunas.
            //Se forem menor que zero, haverá uma exceção de quantidade inválida.
            if (qtdL <= 0)
                throw new Exception("Quantidade de Linhas inválida");
            if (qtdC <= 0)
                throw new Exception("Quantidade de Colunas inválida");

            //Caso contrário, uma nova lista será criada a partir da instanciação de células.
            qtdColunas = qtdC;
            qtdLinhas = qtdL;
            cabeca = new Celula(0, indCabeca, indCabeca, null, null);

            //Este percorrimento conectas as cabeças das linhas e das colunas.

            Celula atual = cabeca;
            for(int c=1; c<=qtdColunas; c++)
            {
                Celula novaCelula = new Celula(0, indCabeca, c, null, null);
                //instanciação de nova célula que será a cabeça da coluna 'c'
                novaCelula.Abaixo = novaCelula; //célula aponta para si mesma, para manter circularidade da lista
                atual.Direita = novaCelula; //célula à direta da atual passa a ser a nova célula instanciada
                atual = novaCelula; //atual vai para sua próxima
            } //ao final do processo, atual é a última célula da cabeças das colunas 
            atual.Direita = cabeca; //para manter a circularidade, última coluna aponta para a primeira
            atual = cabeca; //atual é reinicializada para fazer o mesmo processo, só que com linhas
            for (int l = 1; l <= qtdLinhas; l++)
            {
                Celula novaCelula = new Celula(0, l, indCabeca, null, null); //instanciação da cabeça da linha 'l'
                novaCelula.Direita = novaCelula; //cabeça da linha aponta para ela mesma
                atual.Abaixo = novaCelula; //conecta as duas células (atual e novaCelula) usadas para percorrer as linhas
                atual = novaCelula; //atual vira seu próximo
            }
            atual.Abaixo = cabeca; //ao final do processo, última aponta para primeira
        }

        //Método Boolean para verificar existência de uma célula em um dado ponto da lista (no caso, da "matriz").
        private bool ExisteCelula(Celula cabecaLinha, Celula cabecaColuna, ref Celula esquerda, ref Celula acima)
            //além de retornar um bool de presença da célula na matriz, retorna por referência as células
            //que estão (ou deveriam estar) à esquerda e acima da célula procurada
        {
            //Trata-se de percorrer a "matriz" em busca da célula descrita nos parâmetros.
            esquerda = cabecaLinha; //esquerda recebe inicialmente o ponteiro da cabecaLinha
            while (esquerda.Direita.Coluna < cabecaColuna.Coluna && esquerda.Direita.Coluna != indCabeca)
                //enquanto a célula à direita da esquerda tem valor de sua coluna menor que a coluna da célula procurada
                //e diferente no índice da cabeça
                esquerda = esquerda.Direita; //esquerda recebe célula a sua direita

            //aqui é feito o mesmo processo, mas com a célula acima
            acima = cabecaColuna;
            while (acima.Abaixo.Linha < cabecaLinha.Linha && acima.Abaixo.Linha != indCabeca)
                acima = acima.Abaixo;
            return esquerda.Direita.Coluna == cabecaColuna.Coluna; 
            //retorna-se true se a célula à direita da esquerda corresponde à celula procurada
        }

        //Método de inclusão de uma nova célula.
        public void Incluir(Celula novaCelula)
        {
            //Verificações para assegurar a inclusão de uma célula válida em um local correto.
            //Não se pode adicionar uma célula nula ou com valor 0, por exemplo.
            if (novaCelula == null)
                throw new Exception("Célula nula");
            if (novaCelula.Valor == 0)
                throw new Exception("Valor da célula não pode ser 0");
            if (novaCelula.Linha <= indCabeca || novaCelula.Linha > qtdLinhas)
                throw new Exception("Linha da célula inválida");
            if (novaCelula.Coluna <= indCabeca || novaCelula.Coluna > qtdColunas)
                throw new Exception("Coluna da célula inválida");            

            //Percorre-se a matriz para a inserção no local passado pelos parâmetros.
            Celula esquerda = null, acima = null;

            //obtenção das cabeças de linha e coluna para chamada do método ExisteCelula
            Celula cabecaLinha = cabeca;
            for (int l = 1; l <= novaCelula.Linha; l++)
                cabecaLinha = cabecaLinha.Abaixo;
            Celula cabecaColuna = cabeca;
            for (int c = 1; c <= novaCelula.Coluna; c++)
                cabecaColuna = cabecaColuna.Direita;            
            if (ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                esquerda.Direita.Valor = novaCelula.Valor; //se existe célula, seu valor passa a ser o novo valor passado
            else
            //se não existe, inclui-se célula
            {
                novaCelula.Abaixo = acima.Abaixo; //abaixo fica com valor do abaixo da célula acima
                novaCelula.Direita = esquerda.Direita; //direita fica com valor da direita da célula esquerda
                esquerda.Direita = novaCelula; //direita da esquerda passa a ser novaCelula
                acima.Abaixo = novaCelula; //abaixo da acima passa a ser novaCelula
            }            
        }        

        //Método para exibição da "matriz" em um DataGridView passado por parâmetro.
        public void Exibir(DataGridView dgv)
        {
            if (dgv == null)
                throw new Exception("DataGridView nulo");
            dgv.Rows.Clear();
            dgv.RowCount = qtdLinhas;
            dgv.ColumnCount = qtdColunas;
            Celula cabecaColuna = cabeca.Direita;
            //Inicializa a matriz com os valores do cabeçalho e células preecnhidas com 0    
            for (int l = 0; l < qtdLinhas; l++)
            {
                dgv.Rows[l].HeaderCell.Value = (l+1) + ""; //Põe o valor do cabeçalho de linhas.
                for (int c = 0; c < qtdColunas; c++)
                {
                    if (l==0)
                        dgv.Columns[c].HeaderText = (c + 1) + ""; //Põe o valor do cabeçalho de colunas.
                    dgv.Rows[l].Cells[c].Value = "0";
                    //"Seta" o valor como zero.
                }
            }
            //Aumento automático do cabeçalho de linhas DataGridView.
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            //percorre-se a matriz coluna por coluna, enquanto a coluna da cabecaColuna for diferente do indCabeca(0)
            while (cabecaColuna.Coluna!=cabeca.Coluna)
            {
                Celula atual = cabecaColuna.Abaixo;
                while (atual.Linha!=cabecaColuna.Linha) //percorrem-se todos os valores da coluna atual
                {
                    dgv.Rows[atual.Linha - 1].Cells[atual.Coluna - 1].Value = atual.Valor; //célula correspondende do gridView receb o valor da atual
                    atual = atual.Abaixo; //atual passa para a próxima
                }
                cabecaColuna = cabecaColuna.Direita;
            }            
        }


        //Método que o retorna o valor de uma posição da "matriz" em uma linha e em uma coluna dos respectivos parâmetros.
        public double ValorDe(int linha, int coluna)
        {
            //Verificações para validar o uso dos parâmetros.
            //Não podem ter o valor da cabeça e nem terem ponteiros de esquerda e acima nulos, por exemplo.

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
                return 0; //se não existe célula, é retornado 0
            return esquerda.Direita.Valor; //se existe, retorna-se o valor
        }


        //Método de exclusão de uma célula em determinado ponto passado pelos parâmetros de linha e coluna.
        public void Excluir(int linha, int coluna)
        {
            //A verificação é a mesma do método ValorDe(). A finalidade permanece a única alterada.
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
                throw new Exception("Célula inexistente");
            //se a célula existe, removem-se todos os ponteiros para ela, da seguinte forma:
            acima.Abaixo = acima.Abaixo.Abaixo;
            esquerda.Direita = esquerda.Direita.Direita;
        }

        //Método que limpa a matriz por meio das cabeças apontando para si mesmas (conceito da lista circular).
        public void Limpar()
        {
            for (Celula coluna = cabeca.Direita; coluna.Coluna != cabeca.Coluna; coluna = coluna.Direita)
                coluna.Abaixo = coluna;
            for (Celula linha = cabeca.Abaixo; linha.Linha != cabeca.Linha; linha = linha.Abaixo)
                linha.Direita = linha;
        }                        


        //Método que soma uma constante K digitada pelo usuário à matriz que ele escolher.
        public void SomarEmColuna(double k, int coluna)
        {
            //Verificação para validação da coluna passada.
            if (coluna <= indCabeca || coluna > qtdColunas)
                throw new Exception("Coluna inválida");
            if (k != 0) //Se o valor for 0, nada é feito. A célula será dada como vazia.
            {
                Celula cabecaColuna = cabeca;
                for (int c = 1; c <= coluna; c++)
                    cabecaColuna = cabecaColuna.Direita;
                Celula esquerda = null, acima = null, cabecaLinha = cabeca.Abaixo;
                while (cabecaLinha.Linha != indCabeca)
                {
                    //Se a célula existir, haverá uma soma embutida. entre o valor dela e K.
                    //Lembrando que estamos a percorrer a "matriz".
                    if (ExisteCelula(cabecaLinha, cabecaColuna, ref esquerda, ref acima))
                        esquerda.Direita.Valor += k;
                    else
                    //Caso contrário, instanciaremos uma nova Célula, configuraremos seus ponteiros e adicionaremos K ao seu valor.
                    {
                        //instanciação e inclusão da célula por meio dos ponteiros
                        Celula nova = new Celula(k, cabecaLinha.Linha, cabecaColuna.Coluna, null, null);
                        nova.Abaixo = acima.Abaixo;
                        nova.Direita = esquerda.Direita;
                        esquerda.Direita = nova;
                        acima.Abaixo = nova;                        
                    }
                    cabecaLinha = cabecaLinha.Abaixo;
                    //Percorrendo os dados da linha.
                }
            }
        }

        //Método que soma duas matrizes criadas pelo usuário e as devolve em forma de uma "matriz" resultante.
        public ListaCruzada SomaMatriz(ListaCruzada outra)
        {
            //Verificação para tamanho das "matrizes". Ele precisa ser igual. Caso contrário, não haverá possibilidade de soma.
            if (outra.qtdLinhas != this.qtdLinhas ||
                outra.qtdColunas != this.qtdColunas)
                throw new Exception("Dimensões das matrizes devem ser iguais");

            //Cria-se uma instância de ListaCruzada com valor de linhas e colunas semelhante ao das "matrizes" iniciais.
            ListaCruzada ret = new ListaCruzada(qtdLinhas,qtdColunas);

            //Percorrendo linhas e colunas.
            for (int c = 1; c <= qtdColunas; c++)
                for (int l = 1; l <= qtdLinhas; l++)
                {
                    double valor = ValorDe(l, c) + outra.ValorDe(l, c); //valor da nova célula recebe soma das células com essa posição
                    if (valor != 0)
                        ret.Incluir(new Celula(valor, l, c, null, null));
                    //Aviso: se for zero, não vai incluir.
                }
            return ret;           
        }


        //Método que multiplica duas matrizes criadas pelo usuário. É uma articulação do método anterior.
        public ListaCruzada MultiplicacaoMatriz(ListaCruzada outra)
        {
            //Verificação para o tamanho. O número de colunas de uma deve ser o número de linhas da outra.
            if (this.qtdColunas != outra.qtdLinhas)
                throw new Exception("Quantidade de colunas diferente da quantidade de linhas da segunda matriz");

            //Instancia-se uma ListaCruzada ret com a quantidade de linhas de uma e a quantidade de colunas da outra.
            ListaCruzada ret = new ListaCruzada(qtdLinhas, outra.qtdColunas);

            //Percorrendo linhas e colunas.
            for (int l = 1; l<= qtdLinhas; l++) //para cada linha da matriz atual
            {                
                for(int c2 = 1; c2<=outra.qtdColunas; c2++) //para cada coluna da outra matriz
                {
                    double valor = 0;
                    for (int l2 = 1; l2 <= outra.qtdLinhas; l2++) //para cada linha da segunda matriz
                        valor += this.ValorDe(l, l2) * outra.ValorDe(l2, c2); 
                    //valor incrementa produto das células [linha, linha2] da matriz 1 com [linha2,coluna2] da matriz 2
                    if (valor != 0) //se o valor é diferente de 0, incluí-se na matriz de resultado
                        ret.Incluir(new Celula(valor,l,c2,null,null));

                    //Mesmas condições e comandos do método anterior, mas com acréscimo de cálculos de multiplicação.
                }                
            }
            return ret;
        }


        //Método sobreescrito para conversão em classe String.
        public override string ToString()
        {
            return $"Lista Cruzada com {qtdLinhas} linhas e {qtdColunas} colunas";
        }

        //Método para conversão em tipo próprio para leitura (arquivo .txt).
        public string ParaArquivo()
        {
            string ret = qtdLinhas + "\n" + qtdColunas;
            for (Celula cabecaColuna = cabeca.Direita; cabecaColuna.Coluna != indCabeca; cabecaColuna = cabecaColuna.Direita)
                for (Celula atual = cabecaColuna.Abaixo; atual.Linha != indCabeca; atual = atual.Abaixo)
                    ret += "\n" + atual.ToString();
            return ret;
        }
    }
}