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
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.dgvMatrizResult = new System.Windows.Forms.DataGridView();
            this.btnLerArquivo1 = new System.Windows.Forms.Button();
            this.gbMatriz1 = new System.Windows.Forms.GroupBox();
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
            this.nudColunas2 = new System.Windows.Forms.NumericUpDown();
            this.nudLinhas2 = new System.Windows.Forms.NumericUpDown();
            this.btnCriarMatriz2 = new System.Windows.Forms.Button();
            this.lblColunas2 = new System.Windows.Forms.Label();
            this.lblLinhas2 = new System.Windows.Forms.Label();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.btnLerArquivo2 = new System.Windows.Forms.Button();
            this.btnMultiplicarMatriz = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.dgvAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResult)).BeginInit();
            this.gbMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            this.gbMatriz2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AllowUserToAddRows = false;
            this.dgvMatriz1.AllowUserToDeleteRows = false;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.Location = new System.Drawing.Point(10, 46);
            this.dgvMatriz1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.Size = new System.Drawing.Size(357, 223);
            this.dgvMatriz1.TabIndex = 0;
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
            this.btnLerArquivo1.Location = new System.Drawing.Point(113, 279);
            this.btnLerArquivo1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo1.Name = "btnLerArquivo1";
            this.btnLerArquivo1.Size = new System.Drawing.Size(136, 49);
            this.btnLerArquivo1.TabIndex = 3;
            this.btnLerArquivo1.Text = "Ler Arquivo";
            this.btnLerArquivo1.UseVisualStyleBackColor = true;
            this.btnLerArquivo1.Click += new System.EventHandler(this.btnLerArquivo1_Click);
            // 
            // gbMatriz1
            // 
            this.gbMatriz1.Controls.Add(this.nudColunas);
            this.gbMatriz1.Controls.Add(this.nudLinhas);
            this.gbMatriz1.Controls.Add(this.btnCriarMatriz);
            this.gbMatriz1.Controls.Add(this.lblColunas);
            this.gbMatriz1.Controls.Add(this.lblLinhas);
            this.gbMatriz1.Controls.Add(this.lblK);
            this.gbMatriz1.Controls.Add(this.txtK);
            this.gbMatriz1.Controls.Add(this.btnMultiplicarConstante);
            this.gbMatriz1.Controls.Add(this.btnSomarConstante);
            this.gbMatriz1.Controls.Add(this.dgvMatriz1);
            this.gbMatriz1.Controls.Add(this.btnLerArquivo1);
            this.gbMatriz1.Location = new System.Drawing.Point(12, 12);
            this.gbMatriz1.Name = "gbMatriz1";
            this.gbMatriz1.Size = new System.Drawing.Size(437, 526);
            this.gbMatriz1.TabIndex = 5;
            this.gbMatriz1.TabStop = false;
            this.gbMatriz1.Text = "Matriz 1";
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(113, 407);
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
            this.nudLinhas.Location = new System.Drawing.Point(113, 364);
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
            this.btnCriarMatriz.Location = new System.Drawing.Point(23, 451);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(162, 50);
            this.btnCriarMatriz.TabIndex = 12;
            this.btnCriarMatriz.Text = "Criar Matriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Location = new System.Drawing.Point(6, 409);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(86, 23);
            this.lblColunas.TabIndex = 11;
            this.lblColunas.Text = "Colunas:";
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Location = new System.Drawing.Point(6, 366);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(74, 23);
            this.lblLinhas.TabIndex = 9;
            this.lblLinhas.Text = "Linhas:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(247, 362);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 23);
            this.lblK.TabIndex = 7;
            this.lblK.Text = "K";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(273, 359);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(140, 30);
            this.txtK.TabIndex = 6;
            // 
            // btnMultiplicarConstante
            // 
            this.btnMultiplicarConstante.Location = new System.Drawing.Point(251, 451);
            this.btnMultiplicarConstante.Name = "btnMultiplicarConstante";
            this.btnMultiplicarConstante.Size = new System.Drawing.Size(162, 50);
            this.btnMultiplicarConstante.TabIndex = 5;
            this.btnMultiplicarConstante.Text = "Multiplicar K";
            this.btnMultiplicarConstante.UseVisualStyleBackColor = true;
            this.btnMultiplicarConstante.Click += new System.EventHandler(this.btnMultiplicarConstante_Click);
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(251, 395);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(162, 50);
            this.btnSomarConstante.TabIndex = 4;
            this.btnSomarConstante.Text = "Somar K";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Click += new System.EventHandler(this.btnSomarConstante_Click);
            // 
            // gbMatriz2
            // 
            this.gbMatriz2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatriz2.Controls.Add(this.nudColunas2);
            this.gbMatriz2.Controls.Add(this.nudLinhas2);
            this.gbMatriz2.Controls.Add(this.btnCriarMatriz2);
            this.gbMatriz2.Controls.Add(this.lblColunas2);
            this.gbMatriz2.Controls.Add(this.lblLinhas2);
            this.gbMatriz2.Controls.Add(this.dgvMatriz2);
            this.gbMatriz2.Controls.Add(this.btnLerArquivo2);
            this.gbMatriz2.Location = new System.Drawing.Point(472, 12);
            this.gbMatriz2.Name = "gbMatriz2";
            this.gbMatriz2.Size = new System.Drawing.Size(591, 277);
            this.gbMatriz2.TabIndex = 6;
            this.gbMatriz2.TabStop = false;
            this.gbMatriz2.Text = "Matriz 2";
            // 
            // nudColunas2
            // 
            this.nudColunas2.Location = new System.Drawing.Point(501, 96);
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
            // nudLinhas2
            // 
            this.nudLinhas2.Location = new System.Drawing.Point(501, 53);
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
            // btnCriarMatriz2
            // 
            this.btnCriarMatriz2.Location = new System.Drawing.Point(411, 140);
            this.btnCriarMatriz2.Name = "btnCriarMatriz2";
            this.btnCriarMatriz2.Size = new System.Drawing.Size(162, 50);
            this.btnCriarMatriz2.TabIndex = 17;
            this.btnCriarMatriz2.Text = "Criar Matriz";
            this.btnCriarMatriz2.UseVisualStyleBackColor = true;
            this.btnCriarMatriz2.Click += new System.EventHandler(this.btnCriarMatriz2_Click);
            // 
            // lblColunas2
            // 
            this.lblColunas2.AutoSize = true;
            this.lblColunas2.Location = new System.Drawing.Point(394, 98);
            this.lblColunas2.Name = "lblColunas2";
            this.lblColunas2.Size = new System.Drawing.Size(86, 23);
            this.lblColunas2.TabIndex = 16;
            this.lblColunas2.Text = "Colunas:";
            // 
            // lblLinhas2
            // 
            this.lblLinhas2.AutoSize = true;
            this.lblLinhas2.Location = new System.Drawing.Point(394, 55);
            this.lblLinhas2.Name = "lblLinhas2";
            this.lblLinhas2.Size = new System.Drawing.Size(74, 23);
            this.lblLinhas2.TabIndex = 15;
            this.lblLinhas2.Text = "Linhas:";
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AllowUserToAddRows = false;
            this.dgvMatriz2.AllowUserToDeleteRows = false;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.Location = new System.Drawing.Point(10, 46);
            this.dgvMatriz2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.Size = new System.Drawing.Size(357, 223);
            this.dgvMatriz2.TabIndex = 0;
            // 
            // btnLerArquivo2
            // 
            this.btnLerArquivo2.Location = new System.Drawing.Point(411, 220);
            this.btnLerArquivo2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo2.Name = "btnLerArquivo2";
            this.btnLerArquivo2.Size = new System.Drawing.Size(127, 49);
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
            this.gbResultado.Controls.Add(this.btnMultiplicarMatriz);
            this.gbResultado.Controls.Add(this.dgvMatrizResult);
            this.gbResultado.Controls.Add(this.btnSomarMatrizes);
            this.gbResultado.Location = new System.Drawing.Point(471, 301);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(592, 262);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
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
            this.ClientSize = new System.Drawing.Size(1083, 572);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbMatriz2);
            this.Controls.Add(this.gbMatriz1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMatrizes";
            this.Text = "Matrizes Esparsas";
            this.Load += new System.EventHandler(this.FrmMatrizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResult)).EndInit();
            this.gbMatriz1.ResumeLayout(false);
            this.gbMatriz1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).EndInit();
            this.gbMatriz2.ResumeLayout(false);
            this.gbMatriz2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz1;
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
        private System.Windows.Forms.DataGridView dgvMatriz2;
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
    }
}

