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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.gbMatriz1 = new System.Windows.Forms.GroupBox();
            this.cbExibir = new System.Windows.Forms.CheckBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluirMatriz = new System.Windows.Forms.Button();
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
            this.btnSomarConstante = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMatrizes = new System.Windows.Forms.TabPage();
            this.tpOperacoes = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.gbMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpMatrizes.SuspendLayout();
            this.tpOperacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(9, 12);
            this.dgvMatriz.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(723, 500);
            this.dgvMatriz.TabIndex = 2;
            this.dgvMatriz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellEndEdit);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(189, 177);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(155, 32);
            this.btnLerArquivo.TabIndex = 3;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // gbMatriz1
            // 
            this.gbMatriz1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatriz1.Controls.Add(this.cbExibir);
            this.gbMatriz1.Controls.Add(this.btnExibir);
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
            this.gbMatriz1.Controls.Add(this.btnSomarConstante);
            this.gbMatriz1.Controls.Add(this.btnLerArquivo);
            this.gbMatriz1.Location = new System.Drawing.Point(741, 10);
            this.gbMatriz1.Name = "gbMatriz1";
            this.gbMatriz1.Size = new System.Drawing.Size(395, 502);
            this.gbMatriz1.TabIndex = 5;
            this.gbMatriz1.TabStop = false;
            this.gbMatriz1.Text = "Matriz";
            // 
            // cbExibir
            // 
            this.cbExibir.AutoSize = true;
            this.cbExibir.Location = new System.Drawing.Point(25, 44);
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.Size = new System.Drawing.Size(266, 27);
            this.cbExibir.TabIndex = 28;
            this.cbExibir.Text = "Exibí-las automaticamente";
            this.cbExibir.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(95, 416);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(197, 50);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluirMatriz
            // 
            this.btnExcluirMatriz.Location = new System.Drawing.Point(25, 177);
            this.btnExcluirMatriz.Name = "btnExcluirMatriz";
            this.btnExcluirMatriz.Size = new System.Drawing.Size(155, 33);
            this.btnExcluirMatriz.TabIndex = 27;
            this.btnExcluirMatriz.Text = "Excluir Matriz";
            this.btnExcluirMatriz.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz.Visible = false;
            this.btnExcluirMatriz.Click += new System.EventHandler(this.btnExcluirMatriz_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(219, 83);
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
            this.cbxMatrizes.Location = new System.Drawing.Point(217, 109);
            this.cbxMatrizes.Name = "cbxMatrizes";
            this.cbxMatrizes.Size = new System.Drawing.Size(121, 31);
            this.cbxMatrizes.TabIndex = 25;
            this.cbxMatrizes.SelectedIndexChanged += new System.EventHandler(this.cbxMatrizes_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(189, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 33);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar Matriz";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(22, 299);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(316, 30);
            this.txtValor.TabIndex = 23;
            this.txtValor.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(217, 252);
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
            this.btnExcluir.Location = new System.Drawing.Point(122, 252);
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
            this.btnIncluir.Location = new System.Drawing.Point(22, 252);
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
            this.nudColunas.Location = new System.Drawing.Point(125, 126);
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
            this.nudLinhas.Location = new System.Drawing.Point(125, 83);
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
            this.btnCriarMatriz.Location = new System.Drawing.Point(35, 177);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(136, 33);
            this.btnCriarMatriz.TabIndex = 12;
            this.btnCriarMatriz.Text = "Criar Matriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Location = new System.Drawing.Point(18, 128);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(86, 23);
            this.lblColunas.TabIndex = 11;
            this.lblColunas.Text = "Colunas:";
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Location = new System.Drawing.Point(18, 85);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(74, 23);
            this.lblLinhas.TabIndex = 9;
            this.lblLinhas.Text = "Linhas:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(31, 357);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 23);
            this.lblK.TabIndex = 7;
            this.lblK.Text = "K";
            this.lblK.Visible = false;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(57, 354);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(140, 30);
            this.txtK.TabIndex = 6;
            this.txtK.Visible = false;
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(217, 351);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(118, 35);
            this.btnSomarConstante.TabIndex = 4;
            this.btnSomarConstante.Text = "Somar K";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Visible = false;
            this.btnSomarConstante.Click += new System.EventHandler(this.btnSomarConstante_Click);
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(939, 62);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(197, 50);
            this.btnMultiplicarMatrizes.TabIndex = 5;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrizes.Click += new System.EventHandler(this.btnMultiplicarMatrizes_Click);
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSomarMatrizes.Location = new System.Drawing.Point(939, 6);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(197, 50);
            this.btnSomarMatrizes.TabIndex = 4;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.DefaultExt = "txt";
            this.ofdAbrir.FileName = "openFileDialog1";
            this.ofdAbrir.InitialDirectory = "c:\\temp";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpMatrizes);
            this.tabControl1.Controls.Add(this.tpOperacoes);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 556);
            this.tabControl1.TabIndex = 9;
            // 
            // tpMatrizes
            // 
            this.tpMatrizes.Controls.Add(this.dgvMatriz);
            this.tpMatrizes.Controls.Add(this.gbMatriz1);
            this.tpMatrizes.Location = new System.Drawing.Point(4, 32);
            this.tpMatrizes.Name = "tpMatrizes";
            this.tpMatrizes.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatrizes.Size = new System.Drawing.Size(1142, 520);
            this.tpMatrizes.TabIndex = 0;
            this.tpMatrizes.Text = "Matrizes";
            this.tpMatrizes.UseVisualStyleBackColor = true;
            // 
            // tpOperacoes
            // 
            this.tpOperacoes.Controls.Add(this.btnMultiplicarMatrizes);
            this.tpOperacoes.Controls.Add(this.dgvResult);
            this.tpOperacoes.Controls.Add(this.btnSomarMatrizes);
            this.tpOperacoes.Location = new System.Drawing.Point(4, 32);
            this.tpOperacoes.Name = "tpOperacoes";
            this.tpOperacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOperacoes.Size = new System.Drawing.Size(1142, 520);
            this.tpOperacoes.TabIndex = 1;
            this.tpOperacoes.Text = "Operações";
            this.tpOperacoes.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResult.Location = new System.Drawing.Point(12, 6);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(921, 508);
            this.dgvResult.TabIndex = 7;
            // 
            // FrmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 575);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMatrizes";
            this.Text = "Matrizes Esparsas";
            this.Load += new System.EventHandler(this.FrmMatrizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.gbMatriz1.ResumeLayout(false);
            this.gbMatriz1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpMatrizes.ResumeLayout(false);
            this.tpOperacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.GroupBox gbMatriz1;
        private System.Windows.Forms.Button btnSomarConstante;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnMultiplicarMatrizes;
        private System.Windows.Forms.Button btnSomarMatrizes;
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
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxMatrizes;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Button btnExcluirMatriz;
        private System.Windows.Forms.CheckBox cbExibir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMatrizes;
        private System.Windows.Forms.TabPage tpOperacoes;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

