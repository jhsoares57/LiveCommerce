namespace LiveCommerce.View
{
    partial class FrmFomaPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoFormaPagamento = new System.Windows.Forms.TextBox();
            this.btnSalvarFormaPagamento = new System.Windows.Forms.Button();
            this.btnSairFormaPagamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFinanceiro = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescricaoFormaPagamento
            // 
            this.txtDescricaoFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFormaPagamento.Location = new System.Drawing.Point(9, 43);
            this.txtDescricaoFormaPagamento.Name = "txtDescricaoFormaPagamento";
            this.txtDescricaoFormaPagamento.Size = new System.Drawing.Size(267, 22);
            this.txtDescricaoFormaPagamento.TabIndex = 1;
            // 
            // btnSalvarFormaPagamento
            // 
            this.btnSalvarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFormaPagamento.Image = global::LiveCommerce.Properties.Resources.Salvar;
            this.btnSalvarFormaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFormaPagamento.Location = new System.Drawing.Point(401, 160);
            this.btnSalvarFormaPagamento.Name = "btnSalvarFormaPagamento";
            this.btnSalvarFormaPagamento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalvarFormaPagamento.Size = new System.Drawing.Size(95, 48);
            this.btnSalvarFormaPagamento.TabIndex = 2;
            this.btnSalvarFormaPagamento.Text = "Salvar";
            this.btnSalvarFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFormaPagamento.UseVisualStyleBackColor = true;
            this.btnSalvarFormaPagamento.Click += new System.EventHandler(this.btnSalvarFormaPagamento_Click);
            // 
            // btnSairFormaPagamento
            // 
            this.btnSairFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairFormaPagamento.Image = global::LiveCommerce.Properties.Resources.Sair;
            this.btnSairFormaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairFormaPagamento.Location = new System.Drawing.Point(300, 160);
            this.btnSairFormaPagamento.Name = "btnSairFormaPagamento";
            this.btnSairFormaPagamento.Size = new System.Drawing.Size(95, 48);
            this.btnSairFormaPagamento.TabIndex = 3;
            this.btnSairFormaPagamento.Text = "Sair";
            this.btnSairFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairFormaPagamento.UseVisualStyleBackColor = true;
            this.btnSairFormaPagamento.Click += new System.EventHandler(this.btnSairFormaPagamento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFinanceiro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricaoFormaPagamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permite Lançar Financiero Pendente:";
            // 
            // cbxFinanceiro
            // 
            this.cbxFinanceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFinanceiro.FormattingEnabled = true;
            this.cbxFinanceiro.Location = new System.Drawing.Point(9, 104);
            this.cbxFinanceiro.Name = "cbxFinanceiro";
            this.cbxFinanceiro.Size = new System.Drawing.Size(121, 21);
            this.cbxFinanceiro.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(188, 171);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmFomaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 220);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSairFormaPagamento);
            this.Controls.Add(this.btnSalvarFormaPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmFomaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foma de Pagamento";
            this.Load += new System.EventHandler(this.FrmFomaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoFormaPagamento;
        private System.Windows.Forms.Button btnSalvarFormaPagamento;
        private System.Windows.Forms.Button btnSairFormaPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFinanceiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}