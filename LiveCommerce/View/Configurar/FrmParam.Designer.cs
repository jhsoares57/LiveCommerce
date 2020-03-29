namespace LiveCommerce.View.Configurar
{
    partial class FrmParam
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
            this.bgLogin = new System.Windows.Forms.GroupBox();
            this.chkUsarLogin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgLogin
            // 
            this.bgLogin.Controls.Add(this.chkUsarLogin);
            this.bgLogin.Location = new System.Drawing.Point(12, 12);
            this.bgLogin.Name = "bgLogin";
            this.bgLogin.Size = new System.Drawing.Size(219, 46);
            this.bgLogin.TabIndex = 1;
            this.bgLogin.TabStop = false;
            this.bgLogin.Text = "Login";
            // 
            // chkUsarLogin
            // 
            this.chkUsarLogin.AutoSize = true;
            this.chkUsarLogin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsarLogin.Location = new System.Drawing.Point(6, 19);
            this.chkUsarLogin.Name = "chkUsarLogin";
            this.chkUsarLogin.Size = new System.Drawing.Size(182, 17);
            this.chkUsarLogin.TabIndex = 1;
            this.chkUsarLogin.Text = "Utilizar usuário para realizar login:";
            this.chkUsarLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::LiveCommerce.Properties.Resources.Salvar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(370, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::LiveCommerce.Properties.Resources.Sair;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(260, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.bgLogin.ResumeLayout(false);
            this.bgLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgLogin;
        private System.Windows.Forms.CheckBox chkUsarLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}