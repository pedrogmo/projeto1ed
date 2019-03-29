namespace apMatrizesEsparsas
{
    partial class FrmMatrizes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMatrizResult = new System.Windows.Forms.DataGridView();
            this.btnLerArquivo1 = new System.Windows.Forms.Button();
            this.gbMatriz1 = new System.Windows.Forms.GroupBox();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.cbxMatrizes = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.nudColunas = new System.Windows.Forms.NumericUpDown();
            this.nudLinhas = new System.Windows.Forms.NumericUpDown();
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.lblColunas = new System.Windows.Forms.Label();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnMultiplicarConstante = new System.Windows.Forms.Button();
            this.btnSomarConstante = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnExibir2 = new System.Windows.Forms.Button();
            this.btnExibir1 = new System.Windows.Forms.Button();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnExcluirMatriz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResult)).BeginInit();
            this.gbMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatrizResult
            // 
            this.dgvMatrizResult.AllowUserToAddRows = false;
            this.dgvMatrizResult.AllowUserToDeleteRows = false;
            this.dgvMatrizResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatrizResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizResult.Location = new System.Drawing.Point(15, 14);
            this.dgvMatrizResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvMatrizResult.Name = "dgvMatrizResult";
            this.dgvMatrizResult.ReadOnly = true;
            this.dgvMatrizResult.Size = new System.Drawing.Size(500, 239);
            this.dgvMatrizResult.TabIndex = 2;
            // 
            // btnLerArquivo1
            // 
            this.btnLerArquivo1.Location = new System.Drawing.Point(279, 316);
            this.btnLerArquivo1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo1.Name = "btnLerArquivo1";
            this.btnLerArquivo1.Size = new System.Drawing.Size(155, 32);
            this.btnLerArquivo1.TabIndex = 3;
            this.btnLerArquivo1.Text = "Ler Arquivo";
            this.btnLerArquivo1.UseVisualStyleBackColor = true;
            this.btnLerArquivo1.Click += new System.EventHandler(this.btnLerArquivo1_Click);
            // 
            // gbMatriz1
            // 
            this.gbMatriz1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatriz1.Controls.Add(this.btnExcluirMatriz);
            this.gbMatriz1.Controls.Add(this.lblMatriz);
            this.gbMatriz1.Controls.Add(this.cbxMatrizes);
            this.gbMatriz1.Controls.Add(this.btnLimpar);
            this.gbMatriz1.Controls.Add(this.txtValor);
            this.gbMatriz1.Controls.Add(this.btnPesquisar);
            this.gbMatriz1.Controls.Add(this.btnExcluir);
            this.gbMatriz1.Controls.Add(this.btnIncluir);
            this.gbMatriz1.Controls.Add(this.nudColunas);
            this.gbMatriz1.Controls.Add(this.nudLinhas);
            this.gbMatriz1.Controls.Add(this.btnCriarMatriz);
            this.gbMatriz1.Controls.Add(this.lblColunas);
            this.gbMatriz1.Controls.Add(this.lblLinhas);
            this.gbMatriz1.Controls.Add(this.lblK);
            this.gbMatriz1.Controls.Add(this.txtK);
            this.gbMatriz1.Controls.Add(this.btnMultiplicarConstante);
            this.gbMatriz1.Controls.Add(this.btnSomarConstante);
            this.gbMatriz1.Controls.Add(this.btnLerArquivo1);
            this.gbMatriz1.Location = new System.Drawing.Point(524, 12);
            this.gbMatriz1.Name = "gbMatriz1";
            this.gbMatriz1.Size = new System.Drawing.Size(454, 402);
            this.gbMatriz1.TabIndex = 5;
            this.gbMatriz1.TabStop = false;
            this.gbMatriz1.Text = "Matriz";
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(252, 50);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(119, 23);
            this.lblMatriz.TabIndex = 26;
            this.lblMatriz.Text = "Qual Matriz?";
            // 
            // cbxMatrizes
            // 
            this.cbxMatrizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatrizes.FormattingEnabled = true;
            this.cbxMatrizes.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxMatrizes.Location = new System.Drawing.Point(250, 76);
            this.cbxMatrizes.Name = "cbxMatrizes";
            this.cbxMatrizes.Size = new System.Drawing.Size(121, 31);
            this.cbxMatrizes.TabIndex = 25;
            this.cbxMatrizes.SelectedIndexChanged += new System.EventHandler(this.cbxMatrizes_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(279, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 35);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar Matriz";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(21, 207);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(413, 30);
            this.txtValor.TabIndex = 23;
            this.txtValor.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(216, 160);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 34);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(121, 160);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 35);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(21, 160);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(94, 35);
            this.btnIncluir.TabIndex = 15;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Visible = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(124, 91);
            this.nudColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColunas.Name = "nudColunas";
            this.nudColunas.Size = new System.Drawing.Size(72, 30);
            this.nudColunas.TabIndex = 14;
            this.nudColunas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLinhas
            // 
            this.nudLinhas.Location = new System.Drawing.Point(124, 48);
            this.nudLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLinhas.Name = "nudLinhas";
            this.nudLinhas.Size = new System.Drawing.Size(72, 30);
            this.nudLinhas.TabIndex = 13;
            this.nudLinhas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Location = new System.Drawing.Point(298, 261);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(136, 35);
            this.btnCriarMatriz.TabIndex = 12;
            this.btnCriarMatriz.Text = "Criar Matriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Location = new System.Drawing.Point(17, 93);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(86, 23);
            this.lblColunas.TabIndex = 11;
            this.lblColunas.Text = "Colunas:";
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Location = new System.Drawing.Point(17, 50);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(74, 23);
            this.lblLinhas.TabIndex = 9;
            this.lblLinhas.Text = "Linhas:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(28, 261);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 23);
            this.lblK.TabIndex = 7;
            this.lblK.Text = "K";
            this.lblK.Visible = false;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(54, 258);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(140, 30);
            this.txtK.TabIndex = 6;
            this.txtK.Visible = false;
            // 
            // btnMultiplicarConstante
            // 
            this.btnMultiplicarConstante.Location = new System.Drawing.Point(32, 334);
            this.btnMultiplicarConstante.Name = "btnMultiplicarConstante";
            this.btnMultiplicarConstante.Size = new System.Drawing.Size(154, 40);
            this.btnMultiplicarConstante.TabIndex = 5;
            this.btnMultiplicarConstante.Text = "Multiplicar K";
            this.btnMultiplicarConstante.UseVisualStyleBackColor = true;
            this.btnMultiplicarConstante.Visible = false;
            this.btnMultiplicarConstante.Click += new System.EventHandler(this.btnMultiplicarConstante_Click);
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(32, 296);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(154, 35);
            this.btnSomarConstante.TabIndex = 4;
            this.btnSomarConstante.Text = "Somar K";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Visible = false;
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(209, 29);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(197, 50);
            this.btnMultiplicarMatrizes.TabIndex = 5;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrizes.Click += new System.EventHandler(this.btnMultiplicarMatrizes_Click);
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Location = new System.Drawing.Point(6, 29);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(197, 50);
            this.btnSomarMatrizes.TabIndex = 4;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbResultado.Controls.Add(this.btnExibir2);
            this.gbResultado.Controls.Add(this.btnExibir1);
            this.gbResultado.Controls.Add(this.btnMultiplicarMatrizes);
            this.gbResultado.Controls.Add(this.btnSomarMatrizes);
            this.gbResultado.Location = new System.Drawing.Point(34, 261);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(422, 152);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // btnExibir2
            // 
            this.btnExibir2.Location = new System.Drawing.Point(208, 85);
            this.btnExibir2.Name = "btnExibir2";
            this.btnExibir2.Size = new System.Drawing.Size(197, 50);
            this.btnExibir2.TabIndex = 7;
            this.btnExibir2.Text = "Matriz 2";
            this.btnExibir2.UseVisualStyleBackColor = true;
            this.btnExibir2.Click += new System.EventHandler(this.btnExibir2_Click);
            // 
            // btnExibir1
            // 
            this.btnExibir1.Location = new System.Drawing.Point(6, 85);
            this.btnExibir1.Name = "btnExibir1";
            this.btnExibir1.Size = new System.Drawing.Size(197, 50);
            this.btnExibir1.TabIndex = 6;
            this.btnExibir1.Text = "Matriz 1";
            this.btnExibir1.UseVisualStyleBackColor = true;
            this.btnExibir1.Click += new System.EventHandler(this.btnExibir1_Click);
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.DefaultExt = "txt";
            this.ofdAbrir.FileName = "openFileDialog1";
            this.ofdAbrir.InitialDirectory = "c:\\temp";
            // 
            // btnExcluirMatriz
            // 
            this.btnExcluirMatriz.Location = new System.Drawing.Point(279, 255);
            this.btnExcluirMatriz.Name = "btnExcluirMatriz";
            this.btnExcluirMatriz.Size = new System.Drawing.Size(155, 47);
            this.btnExcluirMatriz.TabIndex = 27;
            this.btnExcluirMatriz.Text = "Excluir Matriz";
            this.btnExcluirMatriz.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz.Visible = false;
            this.btnExcluirMatriz.Click += new System.EventHandler(this.btnExcluirMatriz_Click);
            // 
            // FrmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 426);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbMatriz1);
            this.Controls.Add(this.dgvMatrizResult);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMatrizes";
            this.Text = "Matrizes Esparsas";
            this.Load += new System.EventHandler(this.FrmMatrizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResult)).EndInit();
            this.gbMatriz1.ResumeLayout(false);
            this.gbMatriz1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMatrizResult;
        private System.Windows.Forms.Button btnLerArquivo1;
        private System.Windows.Forms.GroupBox gbMatriz1;
        private System.Windows.Forms.Button btnMultiplicarConstante;
        private System.Windows.Forms.Button btnSomarConstante;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnMultiplicarMatrizes;
        private System.Windows.Forms.Button btnSomarMatrizes;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.NumericUpDown nudColunas;
        private System.Windows.Forms.NumericUpDown nudLinhas;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExibir2;
        private System.Windows.Forms.Button btnExibir1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxMatrizes;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Button btnExcluirMatriz;
    }
}

