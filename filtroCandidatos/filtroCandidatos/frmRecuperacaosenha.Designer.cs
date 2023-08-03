
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
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNsenha = new System.Windows.Forms.TextBox();
            this.txtConfsenha = new System.Windows.Forms.TextBox();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnMensa = new System.Windows.Forms.RadioButton();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(212, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(63, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(180, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail ou CNPJ/CPF:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenha.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(139, 190);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(104, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Nova senha:";
            // 
            // lblSenhaconf
            // 
            this.lblSenhaconf.AutoSize = true;
            this.lblSenhaconf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenhaconf.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaconf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenhaconf.Location = new System.Drawing.Point(91, 234);
            this.lblSenhaconf.Name = "lblSenhaconf";
            this.lblSenhaconf.Size = new System.Drawing.Size(152, 20);
            this.lblSenhaconf.TabIndex = 3;
            this.lblSenhaconf.Text = "Confirme a Senha:";
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblConf.Location = new System.Drawing.Point(113, 300);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(130, 20);
            this.lblConf.TabIndex = 4;
            this.lblConf.Text = "Confirmação por:";
            this.lblConf.Click += new System.EventHandler(this.lblConf_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecuperar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecuperar.Location = new System.Drawing.Point(263, 359);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(140, 37);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "Recuperar ";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(263, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNsenha
            // 
            this.txtNsenha.Location = new System.Drawing.Point(263, 187);
            this.txtNsenha.Name = "txtNsenha";
            this.txtNsenha.Size = new System.Drawing.Size(214, 29);
            this.txtNsenha.TabIndex = 9;
            // 
            // txtConfsenha
            // 
            this.txtConfsenha.Location = new System.Drawing.Point(263, 234);
            this.txtConfsenha.Name = "txtConfsenha";
            this.txtConfsenha.Size = new System.Drawing.Size(214, 29);
            this.txtConfsenha.TabIndex = 10;
            this.txtConfsenha.TextChanged += new System.EventHandler(this.txtConfsenha_TextChanged);
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnEmail.Location = new System.Drawing.Point(263, 298);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(84, 24);
            this.rbtnEmail.TabIndex = 11;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "E-mail";
            this.rbtnEmail.UseVisualStyleBackColor = false;
            // 
            // rbtnMensa
            // 
            this.rbtnMensa.AutoSize = true;
            this.rbtnMensa.BackColor = System.Drawing.Color.White;
            this.rbtnMensa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnMensa.Location = new System.Drawing.Point(392, 296);
            this.rbtnMensa.Name = "rbtnMensa";
            this.rbtnMensa.Size = new System.Drawing.Size(124, 24);
            this.rbtnMensa.TabIndex = 12;
            this.rbtnMensa.TabStop = true;
            this.rbtnMensa.Text = "Mensagem ";
            this.rbtnMensa.UseVisualStyleBackColor = false;
            // 
            // pbPass
            // 
            this.pbPass.BackColor = System.Drawing.Color.White;
            this.pbPass.Image = global::filtroCandidatos.Properties.Resources.hide;
            this.pbPass.Location = new System.Drawing.Point(493, 246);
            this.pbPass.Margin = new System.Windows.Forms.Padding(2);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(23, 17);
            this.pbPass.TabIndex = 24;
            this.pbPass.TabStop = false;
            this.pbPass.Click += new System.EventHandler(this.pbPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::filtroCandidatos.Properties.Resources.hide;
            this.pictureBox1.Location = new System.Drawing.Point(493, 199);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 17);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbPass);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.rbtnMensa);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.lblSenhaconf);
            this.groupBox1.Controls.Add(this.txtConfsenha);
            this.groupBox1.Controls.Add(this.lblConf);
            this.groupBox1.Controls.Add(this.txtNsenha);
            this.groupBox1.Controls.Add(this.btnRecuperar);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(421, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 429);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1460, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "Voltar :)";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.voltarToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.voltarToolStripMenuItem.Text = "Voltar :)";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // frmRecuperacaosenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1460, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRecuperacaosenha";
            this.Text = "Recuperação de Senha ";
            this.Load += new System.EventHandler(this.frmRecuperacaosenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenhaconf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNsenha;
        private System.Windows.Forms.TextBox txtConfsenha;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnMensa;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}