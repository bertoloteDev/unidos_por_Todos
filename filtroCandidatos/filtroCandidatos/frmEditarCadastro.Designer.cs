
namespace filtroCandidatos
{
    partial class frmEditarCadastro
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
            this.Confirmar = new System.Windows.Forms.Button();
            this.AlterarDados = new System.Windows.Forms.Label();
            this.TxtNomedeConfirmação = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.DatadeNacimento = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.DTPNacimento = new System.Windows.Forms.DateTimePicker();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.PbOcutar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbOcutar)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(243, 345);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // AlterarDados
            // 
            this.AlterarDados.AutoSize = true;
            this.AlterarDados.Location = new System.Drawing.Point(213, 31);
            this.AlterarDados.Name = "AlterarDados";
            this.AlterarDados.Size = new System.Drawing.Size(71, 13);
            this.AlterarDados.TabIndex = 1;
            this.AlterarDados.Text = "Alterar Dados";
            // 
            // TxtNomedeConfirmação
            // 
            this.TxtNomedeConfirmação.Location = new System.Drawing.Point(118, 95);
            this.TxtNomedeConfirmação.Name = "TxtNomedeConfirmação";
            this.TxtNomedeConfirmação.Size = new System.Drawing.Size(100, 20);
            this.TxtNomedeConfirmação.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(27, 95);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(85, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome Completo:";
            // 
            // DatadeNacimento
            // 
            this.DatadeNacimento.AutoSize = true;
            this.DatadeNacimento.Location = new System.Drawing.Point(10, 156);
            this.DatadeNacimento.Name = "DatadeNacimento";
            this.DatadeNacimento.Size = new System.Drawing.Size(102, 13);
            this.DatadeNacimento.TabIndex = 5;
            this.DatadeNacimento.Text = "Data de Nacimento:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(357, 99);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(33, 13);
            this.CPF.TabIndex = 6;
            this.CPF.Text = "CPF :";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(338, 150);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(52, 13);
            this.Telefone.TabIndex = 7;
            this.Telefone.Text = "Telefone:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(344, 201);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email:";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(338, 236);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(41, 13);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "Senha:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(398, 194);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 14;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(398, 233);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 15;
            // 
            // DTPNacimento
            // 
            this.DTPNacimento.Location = new System.Drawing.Point(118, 150);
            this.DTPNacimento.Name = "DTPNacimento";
            this.DTPNacimento.Size = new System.Drawing.Size(200, 20);
            this.DTPNacimento.TabIndex = 16;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(398, 96);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(100, 20);
            this.TxtCPF.TabIndex = 19;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(398, 147);
            this.TxtTelefone.Mask = "( 00)00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefone.TabIndex = 20;
            // 
            // PbOcutar
            // 
            this.PbOcutar.Image = global::filtroCandidatos.Properties.Resources.hide;
            this.PbOcutar.Location = new System.Drawing.Point(504, 236);
            this.PbOcutar.Name = "PbOcutar";
            this.PbOcutar.Size = new System.Drawing.Size(46, 27);
            this.PbOcutar.TabIndex = 21;
            this.PbOcutar.TabStop = false;
            this.PbOcutar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEditarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 527);
            this.Controls.Add(this.PbOcutar);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.DTPNacimento);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.DatadeNacimento);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.TxtNomedeConfirmação);
            this.Controls.Add(this.AlterarDados);
            this.Controls.Add(this.Confirmar);
            this.Name = "frmEditarCadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbOcutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Label AlterarDados;
        private System.Windows.Forms.TextBox TxtNomedeConfirmação;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DatadeNacimento;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.DateTimePicker DTPNacimento;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.PictureBox PbOcutar;
    }
}