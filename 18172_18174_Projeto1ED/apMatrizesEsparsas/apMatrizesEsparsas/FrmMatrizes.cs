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

namespace apMatrizesEsparsas
{
    public partial class FrmMatrizes : Form
    {
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
                            "de linhas, a segunda é a quantidade de colunas e as demais são as células, no formato '[linha];[coluna]" +
                            ";[valor]'. Para incluir, pesquisar e excluir, determine a linha e coluna da célula no mesmo componente usado " +
                            "na criação. Para a inclusão, digite o valor da nova célula na caixa de texto, ou edite diretamente pelo DataGridView." +
                            "Também é possível realizar operações " +
                            "com as matrizes (somá-las, multiplicá-las e somar em determinada coluna um valor real K).",
                "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxMatrizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0)
            {
                if (matriz1 == null)
                {
                    HabilitarComponentes(false);
                    nudLinhas.Maximum = int.MaxValue;
                    nudColunas.Maximum = int.MaxValue;
                }
                else
                {
                    HabilitarComponentes(true);
                    nudLinhas.Maximum = matriz1.QtdLinhas;
                    nudColunas.Maximum = matriz1.QtdColunas;
                }
            }
            else
            {
                if (matriz2 == null)
                {
                    HabilitarComponentes(false);
                    nudLinhas.Maximum = int.MaxValue;
                    nudColunas.Maximum = int.MaxValue;
                }
                else
                {
                    HabilitarComponentes(true);
                    nudLinhas.Maximum = matriz2.QtdLinhas;
                    nudColunas.Maximum = matriz2.QtdColunas;
                }
            }
        }

        private void HabilitarComponentes(bool b)
        {
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
                if (cbxMatrizes.SelectedIndex == 0)
                    LerMatriz(ref matriz1);
                else
                    LerMatriz(ref matriz2);
                HabilitarComponentes(true);
                MessageBox.Show("Matriz lida", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void LerMatriz(ref ListaCruzada m)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arq = new StreamReader(ofdAbrir.FileName);
                int l = int.Parse(arq.ReadLine());
                int c = int.Parse(arq.ReadLine());
                m = new ListaCruzada(l, c);
                while (!arq.EndOfStream)
                {
                    string linha = arq.ReadLine();
                    string[] campos = linha.Split(';');
                    int valorLinha = int.Parse(campos[0]);
                    int valorColuna = int.Parse(campos[1]);
                    double valor = double.Parse(campos[2]);
                    m.Incluir(new Celula(valor, valorLinha, valorColuna, null, null));
                    //l;c;v
                    //string [l,c,v]
                }
                arq.Close();
            }
        }        

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0)
            {
                matriz1 = new ListaCruzada((int)nudLinhas.Value, (int)nudColunas.Value);
                nudLinhas.Maximum = matriz1.QtdLinhas;
                nudColunas.Maximum = matriz1.QtdColunas;
            }
            else
            {
                matriz2 = new ListaCruzada((int)nudLinhas.Value, (int)nudColunas.Value);
                nudLinhas.Maximum = matriz2.QtdLinhas;
                nudColunas.Maximum = matriz2.QtdColunas;
            }
            MessageBox.Show("Matriz criada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HabilitarComponentes(true);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Celula nova = new Celula(double.Parse(txtValor.Text), (int)nudLinhas.Value, (int)nudColunas.Value, null, null);
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.Incluir(nova);
                else
                    matriz2.Incluir(nova);
                txtValor.Text = "";
                MessageBox.Show("Valor incluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
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
                dgvMatriz.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMatriz.Rows.Clear();
            }
        }

        private void LimparDgv()
        {
            dgvMatriz.Rows.Clear();
            dgvMatriz.RowCount = 0;
            dgvMatriz.ColumnCount = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0)
                txtValor.Text = matriz1.ValorDe((int)nudLinhas.Value, (int)nudColunas.Value).ToString();
            else
                txtValor.Text = matriz2.ValorDe((int)nudLinhas.Value, (int)nudColunas.Value).ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.Excluir((int)nudLinhas.Value, (int)nudColunas.Value);
                else
                    matriz2.Excluir((int)nudLinhas.Value, (int)nudColunas.Value);
                MessageBox.Show("Valor excluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0)
                matriz1.Limpar();
            else
                matriz2.Limpar();
            MessageBox.Show("Matriz limpada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluirMatriz_Click(object sender, EventArgs e)
        {
            if (cbxMatrizes.SelectedIndex == 0)
                matriz1 = null;
            else
                matriz2 = null;
            nudLinhas.Maximum = int.MaxValue;
            nudColunas.Maximum = int.MaxValue;
            HabilitarComponentes(false);
        }

        private void btnSomarConstante_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.SomarEmColuna(double.Parse(txtK.Text), (int)nudColunas.Value);
                else
                    matriz2.SomarEmColuna(double.Parse(txtK.Text), (int)nudColunas.Value);
                MessageBox.Show("Coluna somada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            if (matriz1 != null && matriz2 != null)
            {
                try
                {
                    resultado = matriz1.SomaMatriz(matriz2);
                    resultado.Exibir(dgvMatriz);
                    dgvMatriz.EditMode = DataGridViewEditMode.EditProgrammatically;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            if (matriz1 != null && matriz2 != null)
            {
                try
                {
                    resultado = matriz1.MultiplicacaoMatriz(matriz2);
                    resultado.Exibir(dgvMatriz);
                    dgvMatriz.EditMode = DataGridViewEditMode.EditProgrammatically;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMatriz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Celula nova = new Celula(double.Parse(dgvMatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()), e.RowIndex+1, e.ColumnIndex+1, null, null);
                if (cbxMatrizes.SelectedIndex == 0)
                    matriz1.Incluir(nova);
                else
                    matriz2.Incluir(nova);
                MessageBox.Show("Valor incluído", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
