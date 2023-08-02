
namespace filtroCandidatos
{
    partial class frmRecuperacaosenha
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaconf = new System.Windows.Forms.Label();
            this.lblConf = new System.Windows.Forms.Label();
            this.btnMsenha = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNsenha = new System.Windows.Forms.TextBox();
            this.txtConfsenha = new System.Windows.Forms.TextBox();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnMensa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(104, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(158, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail ou CNPJ/CPF:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(165, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(97, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Nova senha:";
            // 
            // lblSenhaconf
            // 
            this.lblSenhaconf.AutoSize = true;
            this.lblSenhaconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaconf.Location = new System.Drawing.Point(121, 241);
            this.lblSenhaconf.Name = "lblSenhaconf";
            this.lblSenhaconf.Size = new System.Drawing.Size(141, 20);
            this.lblSenhaconf.TabIndex = 3;
            this.lblSenhaconf.Text = "Confirme a Senha:";
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Location = new System.Drawing.Point(132, 288);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(130, 20);
            this.lblConf.TabIndex = 4;
            this.lblConf.Text = "Confirmação por:";
            // 
            // btnMsenha
            // 
            this.btnMsenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMsenha.Location = new System.Drawing.Point(534, 198);
            this.btnMsenha.Name = "btnMsenha";
            this.btnMsenha.Size = new System.Drawing.Size(98, 23);
            this.btnMsenha.TabIndex = 6;
            this.btnMsenha.Text = "Mostrar senha";
            this.btnMsenha.UseVisualStyleBackColor = false;
            this.btnMsenha.Click += new System.EventHandler(this.btnMsenha_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(332, 354);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(140, 37);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "Recuperar ";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(286, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNsenha
            // 
            this.txtNsenha.Location = new System.Drawing.Point(286, 198);
            this.txtNsenha.Name = "txtNsenha";
            this.txtNsenha.Size = new System.Drawing.Size(198, 20);
            this.txtNsenha.TabIndex = 9;
            // 
            // txtConfsenha
            // 
            this.txtConfsenha.Location = new System.Drawing.Point(286, 243);
            this.txtConfsenha.Name = "txtConfsenha";
            this.txtConfsenha.Size = new System.Drawing.Size(198, 20);
            this.txtConfsenha.TabIndex = 10;
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(286, 291);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(53, 17);
            this.rbtnEmail.TabIndex = 11;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "E-mail";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnMensa
            // 
            this.rbtnMensa.AutoSize = true;
            this.rbtnMensa.Location = new System.Drawing.Point(404, 291);
            this.rbtnMensa.Name = "rbtnMensa";
            this.rbtnMensa.Size = new System.Drawing.Size(80, 17);
            this.rbtnMensa.TabIndex = 12;
            this.rbtnMensa.TabStop = true;
            this.rbtnMensa.Text = "Mensagem ";
            this.rbtnMensa.UseVisualStyleBackColor = true;
            // 
            // frmRecuperacaosenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnMensa);
            this.Controls.Add(this.rbtnEmail);
            this.Controls.Add(this.txtConfsenha);
            this.Controls.Add(this.txtNsenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnMsenha);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.lblSenhaconf);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperacaosenha";
            this.Text = "Recuperação de Senha ";
            this.Load += new System.EventHandler(this.frmRecuperacaosenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenhaconf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.Button btnMsenha;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNsenha;
        private System.Windows.Forms.TextBox txtConfsenha;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnMensa;
    }
}