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
        MatrizEsparsa matriz1, matriz2, resultado;

        private void FrmMatrizes_Load(object sender, EventArgs e)
        {
            matriz1 = new MatrizEsparsa();
            matriz2 = new MatrizEsparsa();
        }        

        public FrmMatrizes()
        {
            InitializeComponent();
        }

        private void ExibirMatriz(MatrizEsparsa matriz, DataGridView onde)
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

        }

        private void btnCriarMatriz2_Click(object sender, EventArgs e)
        {

        }

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicarMatriz_Click(object sender, EventArgs e)
        {

        }
    }
}
