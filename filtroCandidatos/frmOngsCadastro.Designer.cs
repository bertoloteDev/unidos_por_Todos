﻿
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
            this.orcamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(371, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR ONG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CPNJ
            // 
            this.CPNJ.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPNJ.Location = new System.Drawing.Point(388, 158);
            this.CPNJ.Mask = "00.000.000/0000-00";
            this.CPNJ.Name = "CPNJ";
            this.CPNJ.Size = new System.Drawing.Size(140, 26);
            this.CPNJ.TabIndex = 1;
            this.CPNJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPNJ_MaskInputRejected);
            // 
            // lbl45
            // 
            this.lbl45.AutoSize = true;
            this.lbl45.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl45.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl45.Location = new System.Drawing.Point(208, 110);
            this.lbl45.Name = "lbl45";
            this.lbl45.Size = new System.Drawing.Size(168, 20);
            this.lbl45.TabIndex = 2;
            this.lbl45.Text = "Nome da Instituição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(317, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(310, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(261, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reponsável:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameONG
            // 
            this.NameONG.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameONG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameONG.Location = new System.Drawing.Point(388, 104);
            this.NameONG.Name = "NameONG";
            this.NameONG.Size = new System.Drawing.Size(212, 26);
            this.NameONG.TabIndex = 6;
            this.NameONG.TextChanged += new System.EventHandler(this.NameONG_TextChanged);
            // 
            // EmailONG
            // 
            this.EmailONG.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailONG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailONG.Location = new System.Drawing.Point(388, 208);
            this.EmailONG.Name = "EmailONG";
            this.EmailONG.Size = new System.Drawing.Size(212, 26);
            this.EmailONG.TabIndex = 7;
            this.EmailONG.TextChanged += new System.EventHandler(this.EmailONG_TextChanged);
            this.EmailONG.Validated += new System.EventHandler(this.EmailONG_Validated);
            // 
            // Response
            // 
            this.Response.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Response.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Response.Location = new System.Drawing.Point(388, 312);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(212, 26);
            this.Response.TabIndex = 8;
            this.Response.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(399, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneONG
            // 
            this.PhoneONG.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneONG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneONG.Location = new System.Drawing.Point(388, 257);
            this.PhoneONG.Mask = "(00)00000-0000";
            this.PhoneONG.Name = "PhoneONG";
            this.PhoneONG.Size = new System.Drawing.Size(140, 26);
            this.PhoneONG.TabIndex = 10;
            this.PhoneONG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PhoneONG_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(285, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone:";
            // 
            // cpfResponse
            // 
            this.cpfResponse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfResponse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpfResponse.Location = new System.Drawing.Point(388, 362);
            this.cpfResponse.Mask = "000.000.000-00";
            this.cpfResponse.Name = "cpfResponse";
            this.cpfResponse.Size = new System.Drawing.Size(131, 26);
            this.cpfResponse.TabIndex = 24;
            this.cpfResponse.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpfResponse_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(183, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "CPF do Responsável:";
            // 
            // orcamento
            // 
            this.orcamento.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.orcamento.Location = new System.Drawing.Point(388, 412);
            this.orcamento.Name = "orcamento";
            this.orcamento.Size = new System.Drawing.Size(212, 26);
            this.orcamento.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(261, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Orçamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voltar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CPNJ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.orcamento);
            this.groupBox1.Controls.Add(this.lbl45);
            this.groupBox1.Controls.Add(this.cpfResponse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PhoneONG);
            this.groupBox1.Controls.Add(this.NameONG);
            this.groupBox1.Controls.Add(this.EmailONG);
            this.groupBox1.Controls.Add(this.Response);
            this.groupBox1.Location = new System.Drawing.Point(203, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 579);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(6, 537);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(159, 36);
            this.voltar.TabIndex = 28;
            this.voltar.Text = "CANCELAR";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // frmOngsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1414, 649);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOngsCadastro";
            this.Text = "frmOngsCadastro";
            this.Load += new System.EventHandler(this.frmOngsCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox orcamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button voltar;
    }
}