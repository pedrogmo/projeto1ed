using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Victor Botin Avelino (18172) e Pedro Gomes Moreira (18174)

namespace apMatrizesEsparsas
{
    public partial class FrmMatrizes : Form
    {
        //matrizes que serão usadas pela aplicação
        ListaCruzada matriz1, matriz2, resultado;       

        public FrmMatrizes()
        {
            InitializeComponent();
        }

        private void FrmMatrizes_Load(object sender, EventArgs e)
        {
            cbxMatrizes.SelectedIndex = 0;
            MessageBox.Show("Para criar uma matriz, determine a quantidade de linhas e colunas e clique no botão Criar Matriz. " +
                            "Você também pode ler a matriz de um arquivo texto, no qual a primeira linha deve ser a quantidade " +
                            "de linhas, a segunda é a quantidade de colunas e as demais são as células, no formato '[valor];[linha]" +
                            ";[coluna]'. Para incluir, pesquisar e excluir, determine a linha e coluna da célula no mesmo componente usado " +
                            "na criação. Para a inclusão, digite o valor da nova célula na caixa de texto, ou edite diretamente pelo DataGridView." +
                            "Também é possível realizar operações " +
                            "com as matrizes (somá-las, multiplicá-las e somar em determinada coluna um valor real K).",
                "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //antes de aparecer o formulário, exibe-se uma caixa de texto com as instruções do programa,
            //algo importante de se fazer para garantir a boa usabilidade do formulário
        }

        private void cbxMatrizes_SelectedIndexChanged(object sender, EventArgs e)
            //evento disparado quando muda o índice selecionado do ComboBox, significando que a matriz atual
            //foi alterada. Assim, deve-se esconder/exibir componentes de alteração da matriz
        {
            if (cbxMatrizes.SelectedIndex == 0) //se é a matriz1
            {
                if (matriz1 == null)
                    //se ela estiver nula, esconder componentes e permitir o máximo número inteiro para 
                    //os NumericUpDown
                {
                    ExibirComponentes(false);
                    nudLinhas.Maximum = int.MaxValue;
                    nudColunas.Maximum = int.MaxValue;
                    if (cbExibir.Checked) //caso seja exibição automática, limpa-se o DataGridView, representando a matriz nula
                        LimparDgv();
                }
                else
                    //caso não esteja vazia, exibem-se os componentes de edição e os máximos valores inteiros
                    //dos NumericUpDown passam a ser os limites da matriz atual
                {
                    ExibirComponentes(true);
                    nudLinhas.Maximum = matriz1.QtdLinhas;
                    nudColunas.Maximum = matriz1.QtdColunas;
                    if (cbExibir.Checked) //caso se queira exibir automaticamente, matriz se exibe e habilita-se a edição
                        matriz1.Exibir(dgvMatriz);
                }                
            }
            else
            //se a matriz2 foi selecionada
            {
                if (matriz2 == null)
                {
                    ExibirComponentes(false);
                    nudLinhas.Maximum = int.MaxValue;
                    nudColunas.Maximum = int.MaxValue;
                    if (cbExibir.Checked)
                        LimparDgv();
                }
                else
                {
                    ExibirComponentes(true);
                    nudLinhas.Maximum = matriz2.QtdLinhas;
                    nudColunas.Maximum = matriz2.QtdColunas;
                    if (cbExibir.Checked)
                        matriz2.Exibir(dgvMatriz);                        
                }                
            }
            if (cbExibir.Checked)
                //exibir a matriz atual se o usuário selecionou a opção
                //de exibição automática
                btnExibir.PerformClick();
        }

        private void ExibirComponentes(bool b)
        {
            //componentes de edição são deixados visíveis
            //e de criação são escondidos
            btnExcluir.Visible = b;
            btnIncluir.Visible = b;
            btnPesquisar.Visible = b;
            txtValor.Visible = b;
            btnSomarConstante.Visible = b;
            lblK.Visible = b;
            txtK.Visible = b;
            btnLimpar.Visible = b;
            btnExcluirMatriz.Visible = b;
            btnExibir.Visible = b;
            btnCriarMatriz.Visible = !b;
            btnLerArquivo.Visible = !b;
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                //ler a matriz atual, dependendo do índice selecionado do ComboBox
                if (cbxMatrizes.SelectedIndex == 0)
                    LerMatriz(ref matriz1);
                else
                    LerMatriz(ref matriz2);                
            }
            catch(Exception exc)
            {
                //caso ocorra algum erro durante o método, a mensagem do erro é exibida ao usuário,
                //mas o programa não é abortado
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void LerMatriz(ref ListaCruzada m) //método com argumento por referência
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK) //quando o arquivo texto for selecionado
            {
                StreamReader arq = new StreamReader(ofdAbrir.FileName);
                //instanciação do leitor de arquivo.
                int l = int.Parse(arq.ReadLine()); //leitura da quantidade de linhas
                int c = int.Parse(arq.ReadLine()); //leitura da quantidade de colunas
                m = new ListaCruzada(l, c); //instanciação da matriz com a dimensão presente no arquivo texto.
                while (!arq.EndOfStream) //enquanto não é fim do arquivo
                {
                    string linha = arq.ReadLine(); //string linha armazena toda a linha lida
                    string[] campos = linha.Split(';'); //separam-se os campos por meio do método Split no caractere de ponto e vírgula

                    //armazenam-se os campos conforme o formato '[valor];[linha];[coluna]'
                    double valor = double.Parse(campos[0]);
                    int valorLinha = int.Parse(campos[1]);
                    int valorColuna = int.Parse(campos[2]);
                    
                    m.Incluir(new Celula(valor, valorLinha, valorColuna, null, null));
                    //por fim, é incluída nova célula com os valores lidos
                }                
                arq.Close(); //fecha-se o arquivo
                ExibirComponentes(true); //exibem-se os componentes                
                if (cbExibir.Checked)
                    btnExibir.PerformClick();
                MessageBox.Show("Matriz lida", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ao final de muitos métodos desse formulário, exibe-se uma caixa de texto indicando
                //que a operação foi feita
            }
        }        

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0) //se é a primeira matriz a selecionada
            {
                matriz1 = new ListaCruzada((int)nudLinhas.Value, (int)nudColunas.Value);
                //instanciação da matriz com a quantidade de linhas e colunas determinadas
                nudLinhas.Maximum = matriz1.QtdLinhas;
                nudColunas.Maximum = matriz1.QtdColunas;
                //valores máximos dos NumericUpDown tornam-se iguais aos limites da matriz criada
            }
            else //se foi selecionada a segunda matriz, faz-se a mesma operação
            {
                matriz2 = new ListaCruzada((int)nudLinhas.Value, (int)nudColunas.Value);
                nudLinhas.Maximum = matriz2.QtdLinhas;
                nudColunas.Maximum = matriz2.QtdColunas;
            }
            MessageBox.Show("Matriz criada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExibirComponentes(true); //exibem-se os componentes
            if (cbExibir.Checked)
                btnExibir.PerformClick();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciação de nova célula com linha e coluna vindas dos NumericUpDown e valor escrito no TextBox
                Celula nova = new Celula(double.Parse(txtValor.Text), (int)nudLinhas.Value, (int)nudColunas.Value, null, null);
                if (cbxMatrizes.SelectedIndex == 0) //incluí-se a célula na matriz selecionada
                    matriz1.Incluir(nova);
                else
                    matriz2.Incluir(nova);
                txtValor.Text = ""; //limpa-se o TextBox
                MessageBox.Show("Valor incluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbExibir.Checked)
                    btnExibir.PerformClick();
            }
            catch (Exception exc)
            {
                //caso seja disparada alguma exceção durante a inclusão
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                //é chamado método Exibir() da matriz que está em uso pelo usuário
                if (cbxMatrizes.SelectedIndex == 0)
                {
                    if (matriz1 != null)
                        matriz1.Exibir(dgvMatriz);
                    else
                        LimparDgv();
                }
                else
                {
                    if (matriz2 != null)
                        matriz2.Exibir(dgvMatriz);
                    else
                        LimparDgv();
                }
            }
            catch (Exception exc)
            {                
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensgagem de erro
                LimparDgv(); //limpa-se o DataGridView
            }
        }

        private void LimparDgv()
        {
            //as linhas e as colunas do DataGridView são zeradas
            dgvMatriz.RowCount = 0;
            dgvMatriz.ColumnCount = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //TextBox de valor exibe o retorno do método ValorDe() com os parâmetros de linha e 
            //coluna especificados nos NumericUpDown
            if (cbxMatrizes.SelectedIndex == 0)
                txtValor.Text = matriz1.ValorDe((int)nudLinhas.Value, (int)nudColunas.Value).ToString();
            else
                txtValor.Text = matriz2.ValorDe((int)nudLinhas.Value, (int)nudColunas.Value).ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //chama-se o método excluir da matriz selecionada, com os valores de linha
                //e coluna especificados pelo usuário
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.Excluir((int)nudLinhas.Value, (int)nudColunas.Value);
                else
                    matriz2.Excluir((int)nudLinhas.Value, (int)nudColunas.Value);
                MessageBox.Show("Valor excluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbExibir.Checked)
                    btnExibir.PerformClick();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //aqui, o fluxo de execução segue para o método Limpar() da instância de ListaCruzada
            //selecionada, que vai remover todos os itens da mesma
            if (cbxMatrizes.SelectedIndex == 0)
                matriz1.Limpar();
            else
                matriz2.Limpar();
            if (cbExibir.Checked)
                btnExibir.PerformClick();
            MessageBox.Show("Matriz limpada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluirMatriz_Click(object sender, EventArgs e)
        {
            //nesse evento, o objeto de ListaCruzada atual vai perder sua instância, recebendo
            //nulo
            if (cbxMatrizes.SelectedIndex == 0)
                matriz1 = null;
            else
                matriz2 = null;
            nudLinhas.Maximum = int.MaxValue;
            nudColunas.Maximum = int.MaxValue;
            //os valores máximos dos NumericUpDown voltam a ser int.MaxValue
            if (cbExibir.Checked)
                btnExibir.PerformClick();
            ExibirComponentes(false); //componentes de edição são desabilitados            
        }

        private void btnSomarConstante_Click(object sender, EventArgs e)
        {
            try
            {
                //é somado o valor 'K', digitado no TextBox, à coluna que foi selecionada
                //no componente NumericUpDown correspondente
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.SomarEmColuna(double.Parse(txtK.Text), (int)nudColunas.Value);
                else
                    matriz2.SomarEmColuna(double.Parse(txtK.Text), (int)nudColunas.Value);
                MessageBox.Show("Coluna somada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbExibir.Checked)
                    btnExibir.PerformClick();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            if (matriz1 != null && matriz2 != null)
                //se nenhuma das matrizes estiver nula
            {
                try
                {                    
                    resultado = matriz1.SomaMatriz(matriz2); //o objeto resultado recebe o valor da operação de soma de matrizes
                    resultado.Exibir(dgvResult); //exibe-se esse resultado
                    //já que o resultado não deve ter suas células alteradas
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        

        private void btnMultiplicar1_Click(object sender, EventArgs e)
        {
            if (matriz1 != null && matriz2 != null)
            {
                try
                {
                    //resultado agora recebe valor da multiplicação entre as duas matrizes
                    resultado = matriz1.MultiplicacaoMatriz(matriz2);
                    resultado.Exibir(dgvResult);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMultiplicar2_Click(object sender, EventArgs e)
        {
            if (matriz1 != null && matriz2 != null)
            {
                try
                {
                    //resultado agora recebe valor da multiplicação entre as duas matrizes
                    resultado = matriz2.MultiplicacaoMatriz(matriz1);
                    resultado.Exibir(dgvResult);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMatriz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            //evento disparado quando usuário termina edição de uma célula do DataGridView
        {
            try
            {
                //aqui, é usado o argumento 'e' do evento para acessar o índice da linha e da coluna da célula que foi editada,
                //para que se possa instanciar uma nova célula com o valor digitado, e o valor de sua linha e coluna acrescidos de 1
                Celula nova = new Celula(double.Parse(dgvMatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()), e.RowIndex+1, e.ColumnIndex+1, null, null);
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.Incluir(nova);
                else
                    matriz2.Incluir(nova);
                //incluí-se nova célula na ListaCruzada atual e mostra-se mensagem ao usuário
                MessageBox.Show("Valor incluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cbExibir.Checked)
                    //caso se deseje a exibição automática da matriz, ela é exibida novamente para 'limpar'
                    //um possível erro que o usuário possa ter cometido no DataGridView
                    btnExibir.PerformClick();
            }
        }
    }
}
