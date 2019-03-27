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
            this.gbMatriz2 = new System.Windows.Forms.GroupBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.nudColunas2 = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar2 = new System.Windows.Forms.Button();
            this.nudLinhas2 = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.btnIncluir2 = new System.Windows.Forms.Button();
            this.btnCriarMatriz2 = new System.Windows.Forms.Button();
            this.lblColunas2 = new System.Windows.Forms.Label();
            this.lblLinhas2 = new System.Windows.Forms.Label();
            this.btnLerArquivo2 = new System.Windows.Forms.Button();
            this.btnMultiplicarMatriz = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnExibir2 = new System.Windows.Forms.Button();
            this.btnExibir1 = new System.Windows.Forms.Button();
            this.dgvAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResult)).BeginInit();
            this.gbMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            this.gbMatriz2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas2)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatrizResult
            // 
            this.dgvMatrizResult.AllowUserToAddRows = false;
            this.dgvMatrizResult.AllowUserToDeleteRows = false;
            this.dgvMatrizResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizResult.Location = new System.Drawing.Point(9, 31);
            this.dgvMatrizResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvMatrizResult.Name = "dgvMatrizResult";
            this.dgvMatrizResult.ReadOnly = true;
            this.dgvMatrizResult.Size = new System.Drawing.Size(359, 212);
            this.dgvMatrizResult.TabIndex = 2;
            // 
            // btnLerArquivo1
            // 
            this.btnLerArquivo1.Location = new System.Drawing.Point(263, 93);
            this.btnLerArquivo1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo1.Name = "btnLerArquivo1";
            this.btnLerArquivo1.Size = new System.Drawing.Size(136, 32);
            this.btnLerArquivo1.TabIndex = 3;
            this.btnLerArquivo1.Text = "Ler Arquivo";
            this.btnLerArquivo1.UseVisualStyleBackColor = true;
            this.btnLerArquivo1.Click += new System.EventHandler(this.btnLerArquivo1_Click);
            // 
            // gbMatriz1
            // 
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
            this.gbMatriz1.Location = new System.Drawing.Point(12, 12);
            this.gbMatriz1.Name = "gbMatriz1";
            this.gbMatriz1.Size = new System.Drawing.Size(437, 347);
            this.gbMatriz1.TabIndex = 5;
            this.gbMatriz1.TabStop = false;
            this.gbMatriz1.Text = "Matriz 1";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(21, 212);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 30);
            this.txtValor.TabIndex = 23;
            this.txtValor.Visible = false;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
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
            this.btnCriarMatriz.Location = new System.Drawing.Point(263, 45);
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
            this.lblK.Location = new System.Drawing.Point(30, 274);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 23);
            this.lblK.TabIndex = 7;
            this.lblK.Text = "K";
            this.lblK.Visible = false;
            this.lblK.Click += new System.EventHandler(this.lblK_Click);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(56, 271);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(140, 30);
            this.txtK.TabIndex = 6;
            this.txtK.Visible = false;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // btnMultiplicarConstante
            // 
            this.btnMultiplicarConstante.Location = new System.Drawing.Point(263, 271);
            this.btnMultiplicarConstante.Name = "btnMultiplicarConstante";
            this.btnMultiplicarConstante.Size = new System.Drawing.Size(140, 31);
            this.btnMultiplicarConstante.TabIndex = 5;
            this.btnMultiplicarConstante.Text = "Multiplicar K";
            this.btnMultiplicarConstante.UseVisualStyleBackColor = true;
            this.btnMultiplicarConstante.Visible = false;
            this.btnMultiplicarConstante.Click += new System.EventHandler(this.btnMultiplicarConstante_Click);
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(263, 227);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(136, 35);
            this.btnSomarConstante.TabIndex = 4;
            this.btnSomarConstante.Text = "Somar K";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Visible = false;
            this.btnSomarConstante.Click += new System.EventHandler(this.btnSomarConstante_Click);
            // 
            // gbMatriz2
            // 
            this.gbMatriz2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatriz2.Controls.Add(this.txtValor2);
            this.gbMatriz2.Controls.Add(this.nudColunas2);
            this.gbMatriz2.Controls.Add(this.btnPesquisar2);
            this.gbMatriz2.Controls.Add(this.nudLinhas2);
            this.gbMatriz2.Controls.Add(this.btnExcluir2);
            this.gbMatriz2.Controls.Add(this.btnIncluir2);
            this.gbMatriz2.Controls.Add(this.btnCriarMatriz2);
            this.gbMatriz2.Controls.Add(this.lblColunas2);
            this.gbMatriz2.Controls.Add(this.lblLinhas2);
            this.gbMatriz2.Controls.Add(this.btnLerArquivo2);
            this.gbMatriz2.Location = new System.Drawing.Point(472, 12);
            this.gbMatriz2.Name = "gbMatriz2";
            this.gbMatriz2.Size = new System.Drawing.Size(591, 147);
            this.gbMatriz2.TabIndex = 6;
            this.gbMatriz2.TabStop = false;
            this.gbMatriz2.Text = "Matriz 2";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(207, 85);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 30);
            this.txtValor2.TabIndex = 24;
            this.txtValor2.Visible = false;
            // 
            // nudColunas2
            // 
            this.nudColunas2.Location = new System.Drawing.Point(114, 86);
            this.nudColunas2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColunas2.Name = "nudColunas2";
            this.nudColunas2.Size = new System.Drawing.Size(72, 30);
            this.nudColunas2.TabIndex = 19;
            this.nudColunas2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPesquisar2
            // 
            this.btnPesquisar2.Location = new System.Drawing.Point(402, 39);
            this.btnPesquisar2.Name = "btnPesquisar2";
            this.btnPesquisar2.Size = new System.Drawing.Size(108, 35);
            this.btnPesquisar2.TabIndex = 21;
            this.btnPesquisar2.Text = "Pesquisar";
            this.btnPesquisar2.UseVisualStyleBackColor = true;
            this.btnPesquisar2.Visible = false;
            // 
            // nudLinhas2
            // 
            this.nudLinhas2.Location = new System.Drawing.Point(114, 43);
            this.nudLinhas2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLinhas2.Name = "nudLinhas2";
            this.nudLinhas2.Size = new System.Drawing.Size(72, 30);
            this.nudLinhas2.TabIndex = 18;
            this.nudLinhas2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(307, 39);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(89, 35);
            this.btnExcluir2.TabIndex = 20;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Visible = false;
            // 
            // btnIncluir2
            // 
            this.btnIncluir2.Location = new System.Drawing.Point(207, 39);
            this.btnIncluir2.Name = "btnIncluir2";
            this.btnIncluir2.Size = new System.Drawing.Size(94, 35);
            this.btnIncluir2.TabIndex = 19;
            this.btnIncluir2.Text = "Incluir";
            this.btnIncluir2.UseVisualStyleBackColor = true;
            this.btnIncluir2.Visible = false;
            this.btnIncluir2.Click += new System.EventHandler(this.btnIncluir2_Click);
            // 
            // btnCriarMatriz2
            // 
            this.btnCriarMatriz2.Location = new System.Drawing.Point(451, 82);
            this.btnCriarMatriz2.Name = "btnCriarMatriz2";
            this.btnCriarMatriz2.Size = new System.Drawing.Size(119, 34);
            this.btnCriarMatriz2.TabIndex = 17;
            this.btnCriarMatriz2.Text = "Criar Matriz";
            this.btnCriarMatriz2.UseVisualStyleBackColor = true;
            this.btnCriarMatriz2.Click += new System.EventHandler(this.btnCriarMatriz2_Click);
            // 
            // lblColunas2
            // 
            this.lblColunas2.AutoSize = true;
            this.lblColunas2.Location = new System.Drawing.Point(22, 88);
            this.lblColunas2.Name = "lblColunas2";
            this.lblColunas2.Size = new System.Drawing.Size(86, 23);
            this.lblColunas2.TabIndex = 16;
            this.lblColunas2.Text = "Colunas:";
            // 
            // lblLinhas2
            // 
            this.lblLinhas2.AutoSize = true;
            this.lblLinhas2.Location = new System.Drawing.Point(22, 45);
            this.lblLinhas2.Name = "lblLinhas2";
            this.lblLinhas2.Size = new System.Drawing.Size(74, 23);
            this.lblLinhas2.TabIndex = 15;
            this.lblLinhas2.Text = "Linhas:";
            // 
            // btnLerArquivo2
            // 
            this.btnLerArquivo2.Location = new System.Drawing.Point(316, 82);
            this.btnLerArquivo2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo2.Name = "btnLerArquivo2";
            this.btnLerArquivo2.Size = new System.Drawing.Size(126, 35);
            this.btnLerArquivo2.TabIndex = 3;
            this.btnLerArquivo2.Text = "Ler Arquivo";
            this.btnLerArquivo2.UseVisualStyleBackColor = true;
            this.btnLerArquivo2.Click += new System.EventHandler(this.btnLerArquivo2_Click);
            // 
            // btnMultiplicarMatriz
            // 
            this.btnMultiplicarMatriz.Location = new System.Drawing.Point(377, 87);
            this.btnMultiplicarMatriz.Name = "btnMultiplicarMatriz";
            this.btnMultiplicarMatriz.Size = new System.Drawing.Size(197, 50);
            this.btnMultiplicarMatriz.TabIndex = 5;
            this.btnMultiplicarMatriz.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatriz.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatriz.Click += new System.EventHandler(this.btnMultiplicarMatriz_Click);
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Location = new System.Drawing.Point(377, 31);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(197, 50);
            this.btnSomarMatrizes.TabIndex = 4;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultado.Controls.Add(this.btnExibir2);
            this.gbResultado.Controls.Add(this.btnExibir1);
            this.gbResultado.Controls.Add(this.btnMultiplicarMatriz);
            this.gbResultado.Controls.Add(this.dgvMatrizResult);
            this.gbResultado.Controls.Add(this.btnSomarMatrizes);
            this.gbResultado.Location = new System.Drawing.Point(471, 166);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(592, 262);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // btnExibir2
            // 
            this.btnExibir2.Location = new System.Drawing.Point(377, 199);
            this.btnExibir2.Name = "btnExibir2";
            this.btnExibir2.Size = new System.Drawing.Size(197, 50);
            this.btnExibir2.TabIndex = 7;
            this.btnExibir2.Text = "Matriz 2";
            this.btnExibir2.UseVisualStyleBackColor = true;
            this.btnExibir2.Click += new System.EventHandler(this.btnExibir2_Click);
            // 
            // btnExibir1
            // 
            this.btnExibir1.Location = new System.Drawing.Point(377, 143);
            this.btnExibir1.Name = "btnExibir1";
            this.btnExibir1.Size = new System.Drawing.Size(197, 50);
            this.btnExibir1.TabIndex = 6;
            this.btnExibir1.Text = "Matriz 1";
            this.btnExibir1.UseVisualStyleBackColor = true;
            this.btnExibir1.Click += new System.EventHandler(this.btnExibir1_Click);
            // 
            // dgvAbrir
            // 
            this.dgvAbrir.DefaultExt = "txt";
            this.dgvAbrir.FileName = "openFileDialog1";
            // 
            // FrmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 441);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbMatriz2);
            this.Controls.Add(this.gbMatriz1);
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
            this.gbMatriz2.ResumeLayout(false);
            this.gbMatriz2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas2)).EndInit();
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
        private System.Windows.Forms.GroupBox gbMatriz2;
        private System.Windows.Forms.Button btnMultiplicarMatriz;
        private System.Windows.Forms.Button btnSomarMatrizes;
        private System.Windows.Forms.Button btnLerArquivo2;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.OpenFileDialog dgvAbrir;
        private System.Windows.Forms.NumericUpDown nudColunas;
        private System.Windows.Forms.NumericUpDown nudLinhas;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.NumericUpDown nudColunas2;
        private System.Windows.Forms.NumericUpDown nudLinhas2;
        private System.Windows.Forms.Button btnCriarMatriz2;
        private System.Windows.Forms.Label lblColunas2;
        private System.Windows.Forms.Label lblLinhas2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnPesquisar2;
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.Button btnIncluir2;
        private System.Windows.Forms.Button btnExibir2;
        private System.Windows.Forms.Button btnExibir1;
    }
}

