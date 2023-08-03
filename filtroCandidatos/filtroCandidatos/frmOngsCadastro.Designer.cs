
namespace filtroCandidatos
{
    partial class frmOngsCadastro
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
            this.CPNJ = new System.Windows.Forms.MaskedTextBox();
            this.lbl45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameONG = new System.Windows.Forms.TextBox();
            this.EmailONG = new System.Windows.Forms.TextBox();
            this.Response = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneONG = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpfResponse = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR ONG";
            // 
            // CPNJ
            // 
            this.CPNJ.Location = new System.Drawing.Point(600, 257);
            this.CPNJ.Mask = "00.000.000/0000-00";
            this.CPNJ.Name = "CPNJ";
            this.CPNJ.Size = new System.Drawing.Size(140, 20);
            this.CPNJ.TabIndex = 1;
            // 
            // lbl45
            // 
            this.lbl45.AutoSize = true;
            this.lbl45.Location = new System.Drawing.Point(461, 206);
            this.lbl45.Name = "lbl45";
            this.lbl45.Size = new System.Drawing.Size(104, 13);
            this.lbl45.TabIndex = 2;
            this.lbl45.Text = "Nome da Instituição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reponsável:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameONG
            // 
            this.NameONG.Location = new System.Drawing.Point(600, 203);
            this.NameONG.Name = "NameONG";
            this.NameONG.Size = new System.Drawing.Size(212, 20);
            this.NameONG.TabIndex = 6;
            // 
            // EmailONG
            // 
            this.EmailONG.Location = new System.Drawing.Point(600, 307);
            this.EmailONG.Name = "EmailONG";
            this.EmailONG.Size = new System.Drawing.Size(212, 20);
            this.EmailONG.TabIndex = 7;
            this.EmailONG.Validated += new System.EventHandler(this.EmailONG_Validated);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(600, 411);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(212, 20);
            this.Response.TabIndex = 8;
            this.Response.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneONG
            // 
            this.PhoneONG.Location = new System.Drawing.Point(600, 356);
            this.PhoneONG.Mask = "(00) 0 0000-0000";
            this.PhoneONG.Name = "PhoneONG";
            this.PhoneONG.Size = new System.Drawing.Size(140, 20);
            this.PhoneONG.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone:";
            // 
            // cpfResponse
            // 
            this.cpfResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfResponse.Location = new System.Drawing.Point(600, 461);
            this.cpfResponse.Mask = "000.000.000-00";
            this.cpfResponse.Name = "cpfResponse";
            this.cpfResponse.Size = new System.Drawing.Size(131, 22);
            this.cpfResponse.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "CPF do Responsável:";
            // 
            // frmOngsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 777);
            this.Controls.Add(this.cpfResponse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneONG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.EmailONG);
            this.Controls.Add(this.NameONG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl45);
            this.Controls.Add(this.CPNJ);
            this.Controls.Add(this.label1);
            this.Name = "frmOngsCadastro";
            this.Text = "frmOngsCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox CPNJ;
        private System.Windows.Forms.Label lbl45;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameONG;
        private System.Windows.Forms.TextBox EmailONG;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox PhoneONG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cpfResponse;
        private System.Windows.Forms.Label label6;
    }
}