namespace LiveCommerce.View
{
    partial class FrmUsuario
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
            this.gbxPermissao = new System.Windows.Forms.GroupBox();
            this.rdbComun = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.cbxUsuarioFuncionario = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCadastroUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSairCadastroUsuario = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.gbxPermissao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPermissao
            // 
            this.gbxPermissao.Controls.Add(this.rdbComun);
            this.gbxPermissao.Controls.Add(this.rdbAdministrador);
            this.gbxPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPermissao.Location = new System.Drawing.Point(394, 34);
            this.gbxPermissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxPermissao.Name = "gbxPermissao";
            this.gbxPermissao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxPermissao.Size = new System.Drawing.Size(177, 279);
            this.gbxPermissao.TabIndex = 1;
            this.gbxPermissao.TabStop = false;
            this.gbxPermissao.Text = "Permissão";
            // 
            // rdbComun
            // 
            this.rdbComun.AutoSize = true;
            this.rdbComun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbComun.Location = new System.Drawing.Point(26, 151);
            this.rdbComun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbComun.Name = "rdbComun";
            this.rdbComun.Size = new System.Drawing.Size(82, 24);
            this.rdbComun.TabIndex = 1;
            this.rdbComun.TabStop = true;
            this.rdbComun.Text = "Comum";
            this.rdbComun.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdministrador.Location = new System.Drawing.Point(26, 68);
            this.rdbAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(125, 24);
            this.rdbAdministrador.TabIndex = 0;
            this.rdbAdministrador.TabStop = true;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConfirmarSenha);
            this.groupBox2.Controls.Add(this.txtSenhaUsuario);
            this.groupBox2.Controls.Add(this.cbxUsuarioFuncionario);
            this.groupBox2.Controls.Add(this.txtUsuarioCadastroUsuario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(326, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(32, 234);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(258, 26);
            this.txtConfirmarSenha.TabIndex = 4;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(32, 174);
            this.txtSenhaUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(258, 26);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // cbxUsuarioFuncionario
            // 
            this.cbxUsuarioFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuarioFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuarioFuncionario.FormattingEnabled = true;
            this.cbxUsuarioFuncionario.Location = new System.Drawing.Point(32, 48);
            this.cbxUsuarioFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxUsuarioFuncionario.Name = "cbxUsuarioFuncionario";
            this.cbxUsuarioFuncionario.Size = new System.Drawing.Size(283, 28);
            this.cbxUsuarioFuncionario.TabIndex = 0;
            // 
            // txtUsuarioCadastroUsuario
            // 
            this.txtUsuarioCadastroUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastroUsuario.Location = new System.Drawing.Point(32, 120);
            this.txtUsuarioCadastroUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuarioCadastroUsuario.Name = "txtUsuarioCadastroUsuario";
            this.txtUsuarioCadastroUsuario.Size = new System.Drawing.Size(258, 26);
            this.txtUsuarioCadastroUsuario.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // btnSairCadastroUsuario
            // 
            this.btnSairCadastroUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastroUsuario.Image = global::LiveCommerce.Properties.Resources.Sair;
            this.btnSairCadastroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairCadastroUsuario.Location = new System.Drawing.Point(201, 323);
            this.btnSairCadastroUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSairCadastroUsuario.Name = "btnSairCadastroUsuario";
            this.btnSairCadastroUsuario.Size = new System.Drawing.Size(164, 54);
            this.btnSairCadastroUsuario.TabIndex = 3;
            this.btnSairCadastroUsuario.Text = "Sair";
            this.btnSairCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnSairCadastroUsuario.Click += new System.EventHandler(this.btnSairCadastroUsuario_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.Image = global::LiveCommerce.Properties.Resources.Salvar;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(394, 323);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(177, 52);
            this.btnCadastrarUsuario.TabIndex = 2;
            this.btnCadastrarUsuario.Text = "   Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(596, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnSairCadastroUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxPermissao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.gbxPermissao.ResumeLayout(false);
            this.gbxPermissao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPermissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtUsuarioCadastroUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUsuarioFuncionario;
        private System.Windows.Forms.Button btnSairCadastroUsuario;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.RadioButton rdbComun;
        private System.Windows.Forms.RadioButton rdbAdministrador;
    }
}