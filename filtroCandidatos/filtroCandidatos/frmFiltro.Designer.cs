
namespace filtroCandidatos
{
    partial class frmFiltro
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLocalidades = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocalidades
            // 
            this.txtLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidades.Location = new System.Drawing.Point(-1, 13);
            this.txtLocalidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLocalidades.Name = "txtLocalidades";
            this.txtLocalidades.Size = new System.Drawing.Size(148, 26);
            this.txtLocalidades.TabIndex = 0;
            this.txtLocalidades.Text = "1 -LOCALIDADES      ";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(175, 13);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(306, 26);
            this.txtQuant.TabIndex = 1;
            this.txtQuant.Text = "2- QUANTIDADES DE CADASTRADOS";
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Items.AddRange(new object[] {
            "Habilitação",
            "Assistência Social",
            "Desenvolvimento e Defesa de Direitos"});
            this.cbxCategorias.Location = new System.Drawing.Point(513, 13);
            this.cbxCategorias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(249, 28);
            this.cbxCategorias.TabIndex = 2;
            this.cbxCategorias.Text = "CATEGORIAS";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(-1, 308);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(113, 31);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 385);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtLocalidades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmFiltro";
            this.Text = "Filtros de Ongs cadastradas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtLocalidades;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Button btnFiltrar;
    }
}