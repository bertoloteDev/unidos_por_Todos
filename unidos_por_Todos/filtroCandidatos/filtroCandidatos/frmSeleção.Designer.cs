﻿
namespace filtroCandidatos
{
    partial class frmSeleção
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
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentroOeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "seleção de regiões";
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(85, 79);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(83, 23);
            this.btnNorte.TabIndex = 1;
            this.btnNorte.Text = "Norte";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNordeste
            // 
            this.btnNordeste.Location = new System.Drawing.Point(85, 108);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(83, 23);
            this.btnNordeste.TabIndex = 1;
            this.btnNordeste.Text = "Nordeste";
            this.btnNordeste.UseVisualStyleBackColor = true;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // btnCentroOeste
            // 
            this.btnCentroOeste.Location = new System.Drawing.Point(174, 79);
            this.btnCentroOeste.Name = "btnCentroOeste";
            this.btnCentroOeste.Size = new System.Drawing.Size(83, 23);
            this.btnCentroOeste.TabIndex = 1;
            this.btnCentroOeste.Text = "Centro-Oeste";
            this.btnCentroOeste.UseVisualStyleBackColor = true;
            this.btnCentroOeste.Click += new System.EventHandler(this.btnCentroOeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(174, 108);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(83, 23);
            this.btnSul.TabIndex = 1;
            this.btnSul.Text = "Sul";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.Location = new System.Drawing.Point(129, 137);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(84, 23);
            this.btnSudeste.TabIndex = 1;
            this.btnSudeste.Text = "Sudeste";
            this.btnSudeste.UseVisualStyleBackColor = true;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmSeleção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 195);
            this.Controls.Add(this.btnSudeste);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnCentroOeste);
            this.Controls.Add(this.btnNordeste);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeleção";
            this.Text = "GabrielFBraz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.Button btnCentroOeste;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}