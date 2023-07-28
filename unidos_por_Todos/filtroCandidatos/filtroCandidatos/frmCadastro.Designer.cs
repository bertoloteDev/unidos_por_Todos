
namespace filtroCandidatos
{
    partial class frmCadastro
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
            this.nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Men = new System.Windows.Forms.RadioButton();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.Sex = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.RepitaaSenha = new System.Windows.Forms.Label();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(415, 169);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(48, 16);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(807, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(827, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha:";
            // 
            // Birth
            // 
            this.Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birth.Location = new System.Drawing.Point(481, 266);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(149, 22);
            this.Birth.TabIndex = 7;
            this.Birth.ValueChanged += new System.EventHandler(this.Birth_ValueChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(481, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 22);
            this.txtNome.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(481, 216);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(149, 22);
            this.LastName.TabIndex = 9;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(889, 216);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(190, 22);
            this.Email.TabIndex = 10;
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(889, 271);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(190, 22);
            this.Password.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dados Pessoais";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(633, 494);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(135, 35);
            this.Register.TabIndex = 15;
            this.Register.Text = "REGISTRE-SE";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // Men
            // 
            this.Men.AutoSize = true;
            this.Men.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Men.Location = new System.Drawing.Point(28, 42);
            this.Men.Name = "Men";
            this.Men.Size = new System.Drawing.Size(73, 17);
            this.Men.TabIndex = 16;
            this.Men.TabStop = true;
            this.Men.Text = "Masculino";
            this.Men.UseVisualStyleBackColor = true;
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Woman.Location = new System.Drawing.Point(28, 19);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(67, 17);
            this.Woman.TabIndex = 17;
            this.Woman.TabStop = true;
            this.Woman.Text = "Feminino";
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.Men);
            this.Gender.Controls.Add(this.Woman);
            this.Gender.Location = new System.Drawing.Point(482, 359);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(124, 76);
            this.Gender.TabIndex = 18;
            this.Gender.TabStop = false;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(421, 369);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(42, 16);
            this.Sex.TabIndex = 19;
            this.Sex.Text = "Sexo:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(889, 166);
            this.PhoneNumber.Mask = "(00) 00000-0000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(131, 22);
            this.PhoneNumber.TabIndex = 21;
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(482, 317);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(131, 22);
            this.cpf.TabIndex = 22;
            // 
            // Image
            // 
            this.Image.Image = global::filtroCandidatos.Properties.Resources.hide;
            this.Image.Location = new System.Drawing.Point(1085, 272);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(23, 19);
            this.Image.TabIndex = 23;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Password2
            // 
            this.Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password2.Location = new System.Drawing.Point(889, 320);
            this.Password2.Name = "Password2";
            this.Password2.PasswordChar = '*';
            this.Password2.Size = new System.Drawing.Size(190, 22);
            this.Password2.TabIndex = 24;
            // 
            // RepitaaSenha
            // 
            this.RepitaaSenha.AutoSize = true;
            this.RepitaaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepitaaSenha.Location = new System.Drawing.Point(773, 323);
            this.RepitaaSenha.Name = "RepitaaSenha";
            this.RepitaaSenha.Size = new System.Drawing.Size(104, 16);
            this.RepitaaSenha.TabIndex = 25;
            this.RepitaaSenha.Text = "Repita a Senha:";
            // 
            // Image2
            // 
            this.Image2.Image = global::filtroCandidatos.Properties.Resources.hide;
            this.Image2.Location = new System.Drawing.Point(1085, 323);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(23, 19);
            this.Image2.TabIndex = 26;
            this.Image2.TabStop = false;
            this.Image2.Click += new System.EventHandler(this.Image2_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 659);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.RepitaaSenha);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Name = "frmCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Birth;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.RadioButton Men;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.Label RepitaaSenha;
        private System.Windows.Forms.PictureBox Image2;
    }
}