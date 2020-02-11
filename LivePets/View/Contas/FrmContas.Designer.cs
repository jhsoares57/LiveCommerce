namespace LiveCommerce.View.Contas
{
    partial class FrmContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBgbDados = new System.Windows.Forms.GroupBox();
            this.txtDtPagamento = new System.Windows.Forms.DateTimePicker();
            this.txtDtLanc = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxTipoLabnc = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTotalContas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRealizarPagamento = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxFiltroTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtDataPagamentoFim = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.GBgbDados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.GBgbDados);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lançamento";
            // 
            // GBgbDados
            // 
            this.GBgbDados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GBgbDados.Controls.Add(this.txtDtPagamento);
            this.GBgbDados.Controls.Add(this.txtDtLanc);
            this.GBgbDados.Controls.Add(this.btnIncluir);
            this.GBgbDados.Controls.Add(this.btnLimpar);
            this.GBgbDados.Controls.Add(this.cbxTipoLabnc);
            this.GBgbDados.Controls.Add(this.cbxOrigem);
            this.GBgbDados.Controls.Add(this.label7);
            this.GBgbDados.Controls.Add(this.txtObservacao);
            this.GBgbDados.Controls.Add(this.txtValor);
            this.GBgbDados.Controls.Add(this.label6);
            this.GBgbDados.Controls.Add(this.label5);
            this.GBgbDados.Controls.Add(this.label4);
            this.GBgbDados.Controls.Add(this.label3);
            this.GBgbDados.Controls.Add(this.label2);
            this.GBgbDados.Controls.Add(this.txtCodigo);
            this.GBgbDados.Controls.Add(this.label1);
            this.GBgbDados.Location = new System.Drawing.Point(6, 19);
            this.GBgbDados.Name = "GBgbDados";
            this.GBgbDados.Size = new System.Drawing.Size(764, 126);
            this.GBgbDados.TabIndex = 0;
            this.GBgbDados.TabStop = false;
            this.GBgbDados.Text = "Dados";
            // 
            // txtDtPagamento
            // 
            this.txtDtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtPagamento.Location = new System.Drawing.Point(99, 81);
            this.txtDtPagamento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDtPagamento.Name = "txtDtPagamento";
            this.txtDtPagamento.Size = new System.Drawing.Size(97, 20);
            this.txtDtPagamento.TabIndex = 5;
            // 
            // txtDtLanc
            // 
            this.txtDtLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtLanc.Location = new System.Drawing.Point(198, 31);
            this.txtDtLanc.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDtLanc.Name = "txtDtLanc";
            this.txtDtLanc.Size = new System.Drawing.Size(97, 20);
            this.txtDtLanc.TabIndex = 2;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(629, 73);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(114, 28);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir Dados";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(629, 31);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 29);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cbxTipoLabnc
            // 
            this.cbxTipoLabnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoLabnc.FormattingEnabled = true;
            this.cbxTipoLabnc.Location = new System.Drawing.Point(65, 31);
            this.cbxTipoLabnc.Name = "cbxTipoLabnc";
            this.cbxTipoLabnc.Size = new System.Drawing.Size(127, 21);
            this.cbxTipoLabnc.TabIndex = 1;
            this.cbxTipoLabnc.SelectedIndexChanged += new System.EventHandler(this.cbxTipoLabnc_SelectedIndexChanged);
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(301, 31);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(304, 21);
            this.cbxOrigem.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(202, 81);
            this.txtObservacao.MaxLength = 250;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(403, 20);
            this.txtObservacao.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(9, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(82, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Lançamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Lançamento:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.btnFechar);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 353);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Lançados";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTotalContas);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(6, 309);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(664, 37);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            // 
            // txtTotalContas
            // 
            this.txtTotalContas.Enabled = false;
            this.txtTotalContas.ForeColor = System.Drawing.Color.Yellow;
            this.txtTotalContas.Location = new System.Drawing.Point(558, 11);
            this.txtTotalContas.Name = "txtTotalContas";
            this.txtTotalContas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalContas.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(471, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total de contas:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDataPagamentoFim);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnRealizarPagamento);
            this.groupBox6.Location = new System.Drawing.Point(307, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(395, 71);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Realizar Pagamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Selecione uma conta no grid para pagar";
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Location = new System.Drawing.Point(154, 31);
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.Size = new System.Drawing.Size(235, 33);
            this.btnRealizarPagamento.TabIndex = 13;
            this.btnRealizarPagamento.Text = "Realizar Pagamento";
            this.btnRealizarPagamento.UseVisualStyleBackColor = true;
            this.btnRealizarPagamento.Click += new System.EventHandler(this.btnRealizarPagamento_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(676, 309);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 37);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFiltrar);
            this.groupBox5.Controls.Add(this.cbxFiltroTipo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 71);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtros";
            // 
            // cbxFiltroTipo
            // 
            this.cbxFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroTipo.FormattingEnabled = true;
            this.cbxFiltroTipo.Location = new System.Drawing.Point(10, 35);
            this.cbxFiltroTipo.Name = "cbxFiltroTipo";
            this.cbxFiltroTipo.Size = new System.Drawing.Size(122, 21);
            this.cbxFiltroTipo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Lançamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.dgvContas);
            this.groupBox1.Location = new System.Drawing.Point(6, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // dgvContas
            // 
            this.dgvContas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(6, 11);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.Size = new System.Drawing.Size(746, 190);
            this.dgvContas.TabIndex = 15;
            this.dgvContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(163, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtDataPagamentoFim
            // 
            this.txtDataPagamentoFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPagamentoFim.Location = new System.Drawing.Point(18, 35);
            this.txtDataPagamentoFim.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDataPagamentoFim.Name = "txtDataPagamentoFim";
            this.txtDataPagamentoFim.Size = new System.Drawing.Size(112, 20);
            this.txtDataPagamentoFim.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Data Pagamento:";
            // 
            // FrmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar e Receber";
            this.Load += new System.EventHandler(this.FrmContas_Load);
            this.groupBox2.ResumeLayout(false);
            this.GBgbDados.ResumeLayout(false);
            this.GBgbDados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoLabnc;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRealizarPagamento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxFiltroTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DateTimePicker txtDtPagamento;
        private System.Windows.Forms.DateTimePicker txtDtLanc;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTotalContas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GBgbDados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker txtDataPagamentoFim;
        private System.Windows.Forms.Label label10;
    }
}