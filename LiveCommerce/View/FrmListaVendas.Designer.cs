namespace LiveCommerce.View
{
    partial class FrmListaVendas
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnImprimirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnSairlistaVendas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVendasDias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasDias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Vendas";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(6, 34);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(180, 21);
            this.txtPeriodo.TabIndex = 18;
            this.txtPeriodo.TextChanged += new System.EventHandler(this.txtPeriodo_TextChanged);
            // 
            // btnImprimirVenda
            // 
            this.btnImprimirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirVenda.Image = global::LiveCommerce.Properties.Resources.Imprimir;
            this.btnImprimirVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirVenda.Location = new System.Drawing.Point(558, 173);
            this.btnImprimirVenda.Name = "btnImprimirVenda";
            this.btnImprimirVenda.Size = new System.Drawing.Size(108, 54);
            this.btnImprimirVenda.TabIndex = 37;
            this.btnImprimirVenda.Text = "Imprimir";
            this.btnImprimirVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirVenda.UseVisualStyleBackColor = true;
            this.btnImprimirVenda.Click += new System.EventHandler(this.btnImprimirVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Image = global::LiveCommerce.Properties.Resources.Excluir;
            this.btnCancelarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVenda.Location = new System.Drawing.Point(558, 238);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(108, 50);
            this.btnCancelarVenda.TabIndex = 38;
            this.btnCancelarVenda.Text = "Cancelar";
            this.btnCancelarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnSairlistaVendas
            // 
            this.btnSairlistaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairlistaVendas.Image = global::LiveCommerce.Properties.Resources.Sair;
            this.btnSairlistaVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairlistaVendas.Location = new System.Drawing.Point(559, 299);
            this.btnSairlistaVendas.Name = "btnSairlistaVendas";
            this.btnSairlistaVendas.Size = new System.Drawing.Size(108, 49);
            this.btnSairlistaVendas.TabIndex = 39;
            this.btnSairlistaVendas.Text = "Sair";
            this.btnSairlistaVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairlistaVendas.UseVisualStyleBackColor = true;
            this.btnSairlistaVendas.Click += new System.EventHandler(this.btnSairlistaVendas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVendasDias);
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 243);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // dgvVendasDias
            // 
            this.dgvVendasDias.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendasDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasDias.Location = new System.Drawing.Point(7, 22);
            this.dgvVendasDias.Name = "dgvVendasDias";
            this.dgvVendasDias.Size = new System.Drawing.Size(514, 204);
            this.dgvVendasDias.TabIndex = 0;
            this.dgvVendasDias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendasDias_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(15, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 61);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVenda.Image = global::LiveCommerce.Properties.Resources.Adicionar;
            this.btnAdicionarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarVenda.Location = new System.Drawing.Point(558, 105);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(108, 55);
            this.btnAdicionarVenda.TabIndex = 35;
            this.btnAdicionarVenda.Text = "Adicionar";
            this.btnAdicionarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click_1);
            // 
            // FrmListaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 369);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSairlistaVendas);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnImprimirVenda);
            this.Controls.Add(this.btnAdicionarVenda);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmListaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vendas";
            this.Load += new System.EventHandler(this.FrmListaVendas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasDias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btnAdicionarVenda;
        private System.Windows.Forms.Button btnImprimirVenda;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnSairlistaVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVendasDias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}