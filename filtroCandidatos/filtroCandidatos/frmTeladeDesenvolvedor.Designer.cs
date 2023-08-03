
namespace filtroCandidatos
{
    partial class frmTeladeDesenvolvedor
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.logoff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "João dos Santos Silva",
            "Data de Nascimento: 14/12/1979;",
            "Sexo: Masculino;",
            "CPF: 112.233.445.56;",
            "Telefone: (11) 94002-8922",
            "Email: joãoss@gmail.com",
            "Orçamento: R$ 700.000",
            "",
            "Eliana Rodrigues Almeida",
            "Data de Nascimento: 19/10/2001",
            "Sexo: Feminino;",
            "CPF: 457.542.828-08",
            "Telefone: (11) 99113 - 0727",
            "Email: elianarodrigues54@gmail.com",
            "Orçamento: R$ 500.450 "});
            this.listBox1.Location = new System.Drawing.Point(294, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 212);
            this.listBox1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(111, 141);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "USUÁRIOS CADASTRADOS:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            " Por um mundo melhor",
            "CNPJ: 85.544.884/2481-48 ",
            "Responsável : João dos Santos Silva",
            "Email: porummundomelhor@gmail.com",
            "Orçamento: R$ 700.000",
            "",
            "",
            "Transformando Vidas",
            "CNPJ: 12.345.678/0001-90",
            "Responsável: Eliana Rodrigues Almeida",
            "Email: transformandovidas@gmail.com",
            "Orçamento: R$ 500.450"});
            this.listBox2.Location = new System.Drawing.Point(896, 141);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(329, 173);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ONGs CADASTRADAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PÁGINA DO DESENVOLVEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOCAIS QUE PRECISAM DE AJUDA:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Cidade: São Paulo",
            "Estado:  São Paulo",
            "Bairro: Capão Redondo",
            "IDH: 0,782"});
            this.listBox3.Location = new System.Drawing.Point(591, 477);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(315, 95);
            this.listBox3.TabIndex = 6;
            // 
            // logoff
            // 
            this.logoff.Location = new System.Drawing.Point(712, 637);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(115, 42);
            this.logoff.TabIndex = 7;
            this.logoff.Text = "VOLTAR";
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmTeladeDesenvolvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 899);
            this.Controls.Add(this.logoff);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTeladeDesenvolvedor";
            this.Text = "frmTeladeDesenvolvedor";
            this.Load += new System.EventHandler(this.frmTeladeDesenvolvedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}