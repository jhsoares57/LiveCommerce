namespace LiveCommerce.View
{
    partial class FrmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDTFuncionario = new System.Windows.Forms.DateTimePicker();
            this.cbxCidadeFuncionario = new System.Windows.Forms.ComboBox();
            this.txtCELFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtCEPFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoCadastroFuncionario = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxSituacaoFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRGFuncionario = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSalarioBaseFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxUFcadastrofuncionario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroFuncionario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPesquisaFuncionario = new System.Windows.Forms.DataGridView();
            this.txtPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluirCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnSairCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarCadastroFuncionario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDTFuncionario);
            this.groupBox1.Controls.Add(this.cbxCidadeFuncionario);
            this.groupBox1.Controls.Add(this.txtCELFuncionario);
            this.groupBox1.Controls.Add(this.txtCEPFuncionario);
            this.groupBox1.Controls.Add(this.txtCPFFuncionario);
            this.groupBox1.Controls.Add(this.cbxSexoCadastroFuncionario);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbxSituacaoFuncionario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmailFuncionario);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtRGFuncionario);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtSalarioBaseFuncionario);
            this.groupBox1.Controls.Add(this.txtNomeFuncionario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbxUFcadastrofuncionario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBairroFuncionario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNumeroFuncionario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEnderecoFuncionario);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(388, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // txtDTFuncionario
            // 
            this.txtDTFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDTFuncionario.Location = new System.Drawing.Point(329, 122);
            this.txtDTFuncionario.Name = "txtDTFuncionario";
            this.txtDTFuncionario.Size = new System.Drawing.Size(128, 26);
            this.txtDTFuncionario.TabIndex = 67;
            // 
            // cbxCidadeFuncionario
            // 
            this.cbxCidadeFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidadeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeFuncionario.FormattingEnabled = true;
            this.cbxCidadeFuncionario.Location = new System.Drawing.Point(305, 222);
            this.cbxCidadeFuncionario.Name = "cbxCidadeFuncionario";
            this.cbxCidadeFuncionario.Size = new System.Drawing.Size(136, 26);
            this.cbxCidadeFuncionario.TabIndex = 9;
            // 
            // txtCELFuncionario
            // 
            this.txtCELFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCELFuncionario.Location = new System.Drawing.Point(111, 274);
            this.txtCELFuncionario.Mask = "(99)99999-9999";
            this.txtCELFuncionario.Name = "txtCELFuncionario";
            this.txtCELFuncionario.Size = new System.Drawing.Size(96, 24);
            this.txtCELFuncionario.TabIndex = 12;
            // 
            // txtCEPFuncionario
            // 
            this.txtCEPFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEPFuncionario.Location = new System.Drawing.Point(461, 222);
            this.txtCEPFuncionario.Mask = "99999-999";
            this.txtCEPFuncionario.Name = "txtCEPFuncionario";
            this.txtCEPFuncionario.Size = new System.Drawing.Size(85, 26);
            this.txtCEPFuncionario.TabIndex = 10;
            // 
            // txtCPFFuncionario
            // 
            this.txtCPFFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFFuncionario.Location = new System.Drawing.Point(18, 119);
            this.txtCPFFuncionario.Mask = "999.999.999.99";
            this.txtCPFFuncionario.Name = "txtCPFFuncionario";
            this.txtCPFFuncionario.Size = new System.Drawing.Size(135, 26);
            this.txtCPFFuncionario.TabIndex = 2;
            // 
            // cbxSexoCadastroFuncionario
            // 
            this.cbxSexoCadastroFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexoCadastroFuncionario.FormattingEnabled = true;
            this.cbxSexoCadastroFuncionario.Location = new System.Drawing.Point(130, 322);
            this.cbxSexoCadastroFuncionario.Name = "cbxSexoCadastroFuncionario";
            this.cbxSexoCadastroFuncionario.Size = new System.Drawing.Size(100, 26);
            this.cbxSexoCadastroFuncionario.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Sexo";
            // 
            // cbxSituacaoFuncionario
            // 
            this.cbxSituacaoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacaoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSituacaoFuncionario.FormattingEnabled = true;
            this.cbxSituacaoFuncionario.Location = new System.Drawing.Point(22, 322);
            this.cbxSituacaoFuncionario.Name = "cbxSituacaoFuncionario";
            this.cbxSituacaoFuncionario.Size = new System.Drawing.Size(83, 26);
            this.cbxSituacaoFuncionario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "E-mail";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFuncionario.Location = new System.Drawing.Point(241, 274);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(296, 24);
            this.txtEmailFuncionario.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(325, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 20);
            this.label21.TabIndex = 60;
            this.label21.Text = "Data Nascimento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(159, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 20);
            this.label20.TabIndex = 58;
            this.label20.Text = "RG";
            // 
            // txtRGFuncionario
            // 
            this.txtRGFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGFuncionario.Location = new System.Drawing.Point(163, 119);
            this.txtRGFuncionario.Name = "txtRGFuncionario";
            this.txtRGFuncionario.Size = new System.Drawing.Size(141, 26);
            this.txtRGFuncionario.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 56;
            this.label19.Text = "CPF";
            // 
            // txtSalarioBaseFuncionario
            // 
            this.txtSalarioBaseFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBaseFuncionario.Location = new System.Drawing.Point(19, 274);
            this.txtSalarioBaseFuncionario.Name = "txtSalarioBaseFuncionario";
            this.txtSalarioBaseFuncionario.Size = new System.Drawing.Size(86, 24);
            this.txtSalarioBaseFuncionario.TabIndex = 11;
            this.txtSalarioBaseFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioBaseFuncionario_KeyPress);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(90, 69);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(447, 26);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Salário Base";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(18, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 26);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Código";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(318, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cidade";
            // 
            // cbxUFcadastrofuncionario
            // 
            this.cbxUFcadastrofuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUFcadastrofuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUFcadastrofuncionario.FormattingEnabled = true;
            this.cbxUFcadastrofuncionario.Location = new System.Drawing.Point(222, 223);
            this.cbxUFcadastrofuncionario.Name = "cbxUFcadastrofuncionario";
            this.cbxUFcadastrofuncionario.Size = new System.Drawing.Size(63, 26);
            this.cbxUFcadastrofuncionario.TabIndex = 8;
            this.cbxUFcadastrofuncionario.SelectedIndexChanged += new System.EventHandler(this.cbxUFcadastrofuncionario_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "UF";
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroFuncionario.Location = new System.Drawing.Point(19, 224);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(186, 26);
            this.txtBairroFuncionario.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "CEP";
            // 
            // txtNumeroFuncionario
            // 
            this.txtNumeroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFuncionario.Location = new System.Drawing.Point(341, 175);
            this.txtNumeroFuncionario.Name = "txtNumeroFuncionario";
            this.txtNumeroFuncionario.Size = new System.Drawing.Size(86, 26);
            this.txtNumeroFuncionario.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Bairro";
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(18, 175);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(294, 26);
            this.txtEnderecoFuncionario.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Endereço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPesquisaFuncionario);
            this.groupBox2.Controls.Add(this.txtPesquisaFuncionario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 354);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // dgvPesquisaFuncionario
            // 
            this.dgvPesquisaFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesquisaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaFuncionario.Location = new System.Drawing.Point(7, 52);
            this.dgvPesquisaFuncionario.Name = "dgvPesquisaFuncionario";
            this.dgvPesquisaFuncionario.Size = new System.Drawing.Size(330, 289);
            this.dgvPesquisaFuncionario.TabIndex = 1;
            this.dgvPesquisaFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaFuncionario_CellContentDoubleClick);
            // 
            // txtPesquisaFuncionario
            // 
            this.txtPesquisaFuncionario.Location = new System.Drawing.Point(7, 20);
            this.txtPesquisaFuncionario.Name = "txtPesquisaFuncionario";
            this.txtPesquisaFuncionario.Size = new System.Drawing.Size(330, 26);
            this.txtPesquisaFuncionario.TabIndex = 0;
            this.txtPesquisaFuncionario.TextChanged += new System.EventHandler(this.txtPesquisaFuncionario_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LiveCommerce.Properties.Resources.Limpar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(518, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar Grid";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCadastroFuncionario
            // 
            this.btnExcluirCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCadastroFuncionario.Image")));
            this.btnExcluirCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCadastroFuncionario.Location = new System.Drawing.Point(664, 373);
            this.btnExcluirCadastroFuncionario.Name = "btnExcluirCadastroFuncionario";
            this.btnExcluirCadastroFuncionario.Size = new System.Drawing.Size(104, 49);
            this.btnExcluirCadastroFuncionario.TabIndex = 3;
            this.btnExcluirCadastroFuncionario.Text = "Excluir";
            this.btnExcluirCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirCadastroFuncionario.Click += new System.EventHandler(this.btnExcluirCadastroFuncionario_Click);
            // 
            // btnSairCadastroFuncionario
            // 
            this.btnSairCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastroFuncionario.Image = global::LiveCommerce.Properties.Resources.Sair;
            this.btnSairCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairCadastroFuncionario.Location = new System.Drawing.Point(778, 372);
            this.btnSairCadastroFuncionario.Name = "btnSairCadastroFuncionario";
            this.btnSairCadastroFuncionario.Size = new System.Drawing.Size(104, 50);
            this.btnSairCadastroFuncionario.TabIndex = 2;
            this.btnSairCadastroFuncionario.Text = "Sair";
            this.btnSairCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnSairCadastroFuncionario.Click += new System.EventHandler(this.btnSairCadastroFuncionario_Click_1);
            // 
            // btnSalvarCadastroFuncionario
            // 
            this.btnSalvarCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroFuncionario.Image = global::LiveCommerce.Properties.Resources.Salvar;
            this.btnSalvarCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCadastroFuncionario.Location = new System.Drawing.Point(888, 372);
            this.btnSalvarCadastroFuncionario.Name = "btnSalvarCadastroFuncionario";
            this.btnSalvarCadastroFuncionario.Size = new System.Drawing.Size(104, 49);
            this.btnSalvarCadastroFuncionario.TabIndex = 1;
            this.btnSalvarCadastroFuncionario.Text = "Salvar";
            this.btnSalvarCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroFuncionario.Click += new System.EventHandler(this.btnSalvarCadastroFuncionario_Click_1);
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1004, 428);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluirCadastroFuncionario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSairCadastroFuncionario);
            this.Controls.Add(this.btnSalvarCadastroFuncionario);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxUFcadastrofuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroFuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSituacaoFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRGFuncionario;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSalarioBaseFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSexoCadastroFuncionario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSalvarCadastroFuncionario;
        private System.Windows.Forms.Button btnSairCadastroFuncionario;
        private System.Windows.Forms.MaskedTextBox txtCPFFuncionario;
        private System.Windows.Forms.MaskedTextBox txtCELFuncionario;
        private System.Windows.Forms.MaskedTextBox txtCEPFuncionario;
        private System.Windows.Forms.ComboBox cbxCidadeFuncionario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPesquisaFuncionario;
        private System.Windows.Forms.TextBox txtPesquisaFuncionario;
        private System.Windows.Forms.Button btnExcluirCadastroFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtDTFuncionario;
    }
}