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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescricaoFormaPagamento
            // 
            this.txtDescricaoFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFormaPagamento.Location = new System.Drawing.Point(35, 69);
            this.txtDescricaoFormaPagamento.Name = "txtDescricaoFormaPagamento";
            this.txtDescricaoFormaPagamento.Size = new System.Drawing.Size(296, 22);
            this.txtDescricaoFormaPagamento.TabIndex = 1;
            // 
            // btnSalvarFormaPagamento
            // 
            this.btnSalvarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFormaPagamento.Location = new System.Drawing.Point(231, 110);
            this.btnSalvarFormaPagamento.Name = "btnSalvarFormaPagamento";
            this.btnSalvarFormaPagamento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalvarFormaPagamento.Size = new System.Drawing.Size(75, 38);
            this.btnSalvarFormaPagamento.TabIndex = 2;
            this.btnSalvarFormaPagamento.Text = "Salvar";
            this.btnSalvarFormaPagamento.UseVisualStyleBackColor = true;
            this.btnSalvarFormaPagamento.Click += new System.EventHandler(this.btnSalvarFormaPagamento_Click);
            // 
            // btnSairFormaPagamento
            // 
            this.btnSairFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairFormaPagamento.Location = new System.Drawing.Point(150, 110);
            this.btnSairFormaPagamento.Name = "btnSairFormaPagamento";
            this.btnSairFormaPagamento.Size = new System.Drawing.Size(75, 38);
            this.btnSairFormaPagamento.TabIndex = 3;
            this.btnSairFormaPagamento.Text = "Sair";
            this.btnSairFormaPagamento.UseVisualStyleBackColor = true;
            this.btnSairFormaPagamento.Click += new System.EventHandler(this.btnSairFormaPagamento_Click);
            // 
            // FrmFomaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 168);
            this.Controls.Add(this.btnSairFormaPagamento);
            this.Controls.Add(this.btnSalvarFormaPagamento);
            this.Controls.Add(this.txtDescricaoFormaPagamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmFomaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foma de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoFormaPagamento;
        private System.Windows.Forms.Button btnSalvarFormaPagamento;
        private System.Windows.Forms.Button btnSairFormaPagamento;
    }
}