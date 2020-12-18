namespace LiveCommerce.View
{
    partial class FrmVendas
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
            this.lblVendas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataPrimeiroVencimento = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.cbxFormaPagamentoVendas = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelarVendas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraVenda = new System.Windows.Forms.TextBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtDescricaoCliente = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.Location = new System.Drawing.Point(242, 9);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(91, 25);
            this.lblVendas.TabIndex = 0;
            this.lblVendas.Text = "Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataPrimeiroVencimento);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtValorParcela);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtParcela);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTotalaPagar);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtTotalVenda);
            this.groupBox1.Controls.Add(this.cbxFormaPagamentoVendas);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnCancelarVendas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(728, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 485);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // txtDataPrimeiroVencimento
            // 
            this.txtDataPrimeiroVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDataPrimeiroVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPrimeiroVencimento.Location = new System.Drawing.Point(27, 320);
            this.txtDataPrimeiroVencimento.Name = "txtDataPrimeiroVencimento";
            this.txtDataPrimeiroVencimento.Size = new System.Drawing.Size(157, 26);
            this.txtDataPrimeiroVencimento.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 16);
            this.label19.TabIndex = 57;
            this.label19.Text = "Primeiro Vencimento";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParcela.Location = new System.Drawing.Point(100, 260);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(84, 26);
            this.txtValorParcela.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Valor";
            // 
            // txtParcela
            // 
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(22, 260);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(72, 26);
            this.txtParcela.TabIndex = 54;
            this.txtParcela.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParcela_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Parcelas";
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.Enabled = false;
            this.txtTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalaPagar.Location = new System.Drawing.Point(22, 152);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(162, 26);
            this.txtTotalaPagar.TabIndex = 52;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(22, 104);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(162, 26);
            this.txtDesconto.TabIndex = 0;
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(22, 47);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(162, 26);
            this.txtTotalVenda.TabIndex = 50;
            // 
            // cbxFormaPagamentoVendas
            // 
            this.cbxFormaPagamentoVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormaPagamentoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamentoVendas.FormattingEnabled = true;
            this.cbxFormaPagamentoVendas.Location = new System.Drawing.Point(22, 208);
            this.cbxFormaPagamentoVendas.Name = "cbxFormaPagamentoVendas";
            this.cbxFormaPagamentoVendas.Size = new System.Drawing.Size(162, 28);
            this.cbxFormaPagamentoVendas.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 16);
            this.label18.TabIndex = 48;
            this.label18.Text = "Forma de Pagam...\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 47;
            this.label17.Text = "Total a Pagar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 46;
            this.label16.Text = "Desconto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "Total Venda";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = global::LiveCommerce.Properties.Resources.Salvar;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(43, 372);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(127, 52);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelarVendas
            // 
            this.btnCancelarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVendas.Image = global::LiveCommerce.Properties.Resources.Excluir;
            this.btnCancelarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVendas.Location = new System.Drawing.Point(43, 430);
            this.btnCancelarVendas.Name = "btnCancelarVendas";
            this.btnCancelarVendas.Size = new System.Drawing.Size(127, 49);
            this.btnCancelarVendas.TabIndex = 3;
            this.btnCancelarVendas.Text = "Sair";
            this.btnCancelarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVendas.UseVisualStyleBackColor = true;
            this.btnCancelarVendas.Click += new System.EventHandler(this.btnCancelarVendas_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHoraVenda);
            this.groupBox2.Controls.Add(this.txtDataVenda);
            this.groupBox2.Controls.Add(this.txtCodigoVenda);
            this.groupBox2.Location = new System.Drawing.Point(12, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "NºVenda";
            // 
            // txtHoraVenda
            // 
            this.txtHoraVenda.Enabled = false;
            this.txtHoraVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraVenda.Location = new System.Drawing.Point(217, 38);
            this.txtHoraVenda.Name = "txtHoraVenda";
            this.txtHoraVenda.Size = new System.Drawing.Size(100, 26);
            this.txtHoraVenda.TabIndex = 10;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(111, 38);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(100, 26);
            this.txtDataVenda.TabIndex = 9;
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Enabled = false;
            this.txtCodigoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenda.Location = new System.Drawing.Point(5, 38);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoVenda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vendedor";
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(16, 36);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(224, 28);
            this.cbxVendedor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxVendedor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(374, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 73);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendedor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCpfCliente);
            this.groupBox4.Controls.Add(this.btnPesquisarCliente);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtCodigoCliente);
            this.groupBox4.Controls.Add(this.txtDescricaoCliente);
            this.groupBox4.Location = new System.Drawing.Point(12, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 92);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliente.Location = new System.Drawing.Point(534, 43);
            this.txtCpfCliente.Mask = "000,000,000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(121, 26);
            this.txtCpfCliente.TabIndex = 24;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(64, 44);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(75, 26);
            this.btnPesquisarCliente.TabIndex = 1;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Descricao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Codigo";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(5, 44);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(53, 26);
            this.txtCodigoCliente.TabIndex = 6;
            // 
            // txtDescricaoCliente
            // 
            this.txtDescricaoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCliente.Location = new System.Drawing.Point(146, 44);
            this.txtDescricaoCliente.Name = "txtDescricaoCliente";
            this.txtDescricaoCliente.Size = new System.Drawing.Size(382, 26);
            this.txtDescricaoCliente.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtValorTotal);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnPesquisar);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnIncluir);
            this.groupBox5.Controls.Add(this.txtDescricaoProduto);
            this.groupBox5.Controls.Add(this.txtQuantidade);
            this.groupBox5.Controls.Add(this.txtPrecoProduto);
            this.groupBox5.Controls.Add(this.txtCodigoProduto);
            this.groupBox5.Location = new System.Drawing.Point(12, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 79);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produto";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(487, 33);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(88, 26);
            this.txtValorTotal.TabIndex = 2;
            this.txtValorTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTotal_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Valor Total:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(58, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(47, 26);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesq";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(396, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Preço Unit...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(328, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Qtde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Codigo";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(596, 32);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(59, 26);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(111, 34);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(211, 26);
            this.txtDescricaoProduto.TabIndex = 30;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(331, 34);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(59, 26);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoProduto.Location = new System.Drawing.Point(398, 34);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(76, 26);
            this.txtPrecoProduto.TabIndex = 28;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(6, 35);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(52, 26);
            this.txtCodigoProduto.TabIndex = 27;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvVenda);
            this.groupBox6.Location = new System.Drawing.Point(12, 298);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(688, 221);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Itens Venda";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToOrderColumns = true;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(18, 19);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowHeadersWidth = 21;
            this.dgvVenda.Size = new System.Drawing.Size(653, 196);
            this.dgvVenda.TabIndex = 0;
            this.dgvVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellDoubleClick);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 531);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.ComboBox cbxFormaPagamentoVendas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelarVendas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraVenda;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TextBox txtCodigoCliente;
        public System.Windows.Forms.TextBox txtDescricaoCliente;
        public System.Windows.Forms.MaskedTextBox txtCpfCliente;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtPrecoProduto;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtDataPrimeiroVencimento;
    }
}

