
namespace filtroCandidatos
{
    partial class frmbdcadastrados
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
            this.bancodedados_cadastrados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedados_cadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // bancodedados_cadastrados
            // 
            this.bancodedados_cadastrados.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.bancodedados_cadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bancodedados_cadastrados.Location = new System.Drawing.Point(231, 174);
            this.bancodedados_cadastrados.Name = "bancodedados_cadastrados";
            this.bancodedados_cadastrados.Size = new System.Drawing.Size(836, 352);
            this.bancodedados_cadastrados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(474, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUÁRIOS CADASTRADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmbdcadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1277, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bancodedados_cadastrados);
            this.Name = "frmbdcadastrados";
            this.Text = "bdcadastrados";
            this.Load += new System.EventHandler(this.bdcadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancodedados_cadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bancodedados_cadastrados;
        private System.Windows.Forms.Label label1;
    }
}