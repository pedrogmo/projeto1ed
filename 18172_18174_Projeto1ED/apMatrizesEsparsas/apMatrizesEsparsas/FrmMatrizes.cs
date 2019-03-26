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
            dgvMatriz1.RowCount = matriz1.QtdLinhas;
            dgvMatriz1.ColumnCount = matriz1.QtdColunas;
        }

        private void btnCriarMatriz2_Click(object sender, EventArgs e)
        {
            matriz2 = new ListaCruzada((int)nudLinhas2.Value, (int)nudColunas2.Value);
            dgvMatriz2.RowCount = matriz2.QtdLinhas;
            dgvMatriz2.ColumnCount = matriz2.QtdColunas;
        }

        private void dgvMatriz1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            matriz1.Incluir(new Celula(double.Parse(dgvMatriz1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()), 
                e.RowIndex+1, e.ColumnIndex+1,null,null));
        }

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicarMatriz_Click(object sender, EventArgs e)
        {

        }
    }
}
