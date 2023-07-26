
namespace filtroCandidatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Candidate1 = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pessoa2 = new System.Windows.Forms.Label();
            this.Candidate2 = new System.Windows.Forms.TextBox();
            this.ideinha = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.TextBox();
            this.btnAbrirSeleção = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Candidate1
            // 
            this.Candidate1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidate1.Location = new System.Drawing.Point(355, 65);
            this.Candidate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Candidate1.Multiline = true;
            this.Candidate1.Name = "Candidate1";
            this.Candidate1.Size = new System.Drawing.Size(132, 32);
            this.Candidate1.TabIndex = 0;
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(355, 129);
            this.money.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.money.Multiline = true;
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(132, 33);
            this.money.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(332, 397);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(104, 45);
            this.Result.TabIndex = 2;
            this.Result.Text = "APERTE";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Response
            // 
            this.Response.AutoSize = true;
            this.Response.Location = new System.Drawing.Point(409, 542);
            this.Response.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(0, 20);
            this.Response.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = " Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orçamento:";
            // 
            // pessoa2
            // 
            this.pessoa2.AutoSize = true;
            this.pessoa2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoa2.Location = new System.Drawing.Point(232, 217);
            this.pessoa2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pessoa2.Name = "pessoa2";
            this.pessoa2.Size = new System.Drawing.Size(54, 20);
            this.pessoa2.TabIndex = 6;
            this.pessoa2.Text = "Cliente:";
            // 
            // Candidate2
            // 
            this.Candidate2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidate2.Location = new System.Drawing.Point(355, 212);
            this.Candidate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Candidate2.Multiline = true;
            this.Candidate2.Name = "Candidate2";
            this.Candidate2.Size = new System.Drawing.Size(132, 36);
            this.Candidate2.TabIndex = 7;
            this.Candidate2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ideinha
            // 
            this.ideinha.AutoSize = true;
            this.ideinha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideinha.Location = new System.Drawing.Point(232, 286);
            this.ideinha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ideinha.Name = "ideinha";
            this.ideinha.Size = new System.Drawing.Size(78, 20);
            this.ideinha.TabIndex = 8;
            this.ideinha.Text = "Orçamento:";
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(355, 282);
            this.cash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cash.Multiline = true;
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(132, 36);
            this.cash.TabIndex = 9;
            // 
            // btnAbrirSeleção
            // 
            this.btnAbrirSeleção.Location = new System.Drawing.Point(361, 565);
            this.btnAbrirSeleção.Name = "btnAbrirSeleção";
            this.btnAbrirSeleção.Size = new System.Drawing.Size(75, 63);
            this.btnAbrirSeleção.TabIndex = 10;
            this.btnAbrirSeleção.Text = "abrir Seleção";
            this.btnAbrirSeleção.UseVisualStyleBackColor = true;
            this.btnAbrirSeleção.Click += new System.EventHandler(this.btnAbrirSeleção_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 800);
            this.Controls.Add(this.btnAbrirSeleção);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.ideinha);
            this.Controls.Add(this.Candidate2);
            this.Controls.Add(this.pessoa2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Candidate1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Candidate1;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pessoa2;
        private System.Windows.Forms.TextBox Candidate2;
        private System.Windows.Forms.Label ideinha;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Button btnAbrirSeleção;
    }
}

