
namespace filtroCandidatos
{
    partial class frmGabriel
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
            this.Response = new System.Windows.Forms.Label();
            this.btnAbrirSeleção = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Matheus = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btnAbrirSeleção
            // 
            this.btnAbrirSeleção.Location = new System.Drawing.Point(256, 331);
            this.btnAbrirSeleção.Name = "btnAbrirSeleção";
            this.btnAbrirSeleção.Size = new System.Drawing.Size(75, 63);
            this.btnAbrirSeleção.TabIndex = 10;
            this.btnAbrirSeleção.Text = "abrir Seleção";
            this.btnAbrirSeleção.UseVisualStyleBackColor = true;
            this.btnAbrirSeleção.Click += new System.EventHandler(this.btnAbrirSeleção_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Quem Somos Nos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matheus
            // 
            this.Matheus.Location = new System.Drawing.Point(294, 473);
            this.Matheus.Name = "Matheus";
            this.Matheus.Size = new System.Drawing.Size(136, 43);
            this.Matheus.TabIndex = 12;
            this.Matheus.Text = "Cadastre-se";
            this.Matheus.UseVisualStyleBackColor = true;
            this.Matheus.Click += new System.EventHandler(this.Matheus_Click);
            // 
            // frmGabriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 800);
            this.Controls.Add(this.Matheus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbrirSeleção);
            this.Controls.Add(this.Response);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGabriel";
            this.Text = "GabrielFormHome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.Button btnAbrirSeleção;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Matheus;
    }
}

