using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apMatrizesEsparsas
{
    public partial class FrmMatrizes : Form
    {
        ListaCruzada matriz1, matriz2, resultado;

        private void FrmMatrizes_Load(object sender, EventArgs e)
        {
            
        }        

        public FrmMatrizes()
        {
            InitializeComponent();
        }

        private void ExibirMatriz(ListaCruzada matriz, DataGridView onde)
        {

        }

        private void btnLerArquivo1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomarConstante_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicarConstante_Click(object sender, EventArgs e)
        {

        }

        private void btnLerArquivo2_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            matriz1 = new ListaCruzada((int)nudLinhas.Value, (int)nudColunas.Value);
            nudLinhas.Maximum = matriz1.QtdLinhas;
            nudColunas.Maximum = matriz1.QtdColunas;
            MessageBox.Show("Matriz criada");
            btnExcluir.Visible = true;
            btnIncluir.Visible = true;
            btnPesquisar.Visible = true;
            txtValor.Visible = true;
            btnSomarConstante.Visible = true;
            btnMultiplicarConstante.Visible = true;
            lblK.Visible = true;
            txtK.Visible = true;
        }

        private void btnCriarMatriz2_Click(object sender, EventArgs e)
        {
            matriz2 = new ListaCruzada((int)nudLinhas2.Value, (int)nudColunas2.Value);
            nudLinhas2.Maximum = matriz2.QtdLinhas;
            nudColunas2.Maximum = matriz2.QtdColunas;
            MessageBox.Show("Matriz criada");
            btnExcluir2.Visible = true;
            btnIncluir2.Visible = true;
            btnPesquisar2.Visible = true;
            txtValor2.Visible = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            matriz1.Incluir(new Celula(double.Parse(txtValor.Text), (int)nudLinhas.Value, (int)nudColunas.Value, null, null));
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void lblK_Click(object sender, EventArgs e)
        {

        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIncluir2_Click(object sender, EventArgs e)
        {
            matriz2.Incluir(new Celula(double.Parse(txtValor2.Text), (int)nudLinhas2.Value, (int)nudColunas2.Value, null, null));
        }

        private void btnExibir1_Click(object sender, EventArgs e)
        {
            if (matriz1 != null)
                matriz1.Exibir(dgvMatrizResult);
        }

        private void btnExibir2_Click(object sender, EventArgs e)
        {
            if (matriz2 != null)
                matriz2.Exibir(dgvMatrizResult);
        }

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicarMatriz_Click(object sender, EventArgs e)
        {

        }
    }
}
