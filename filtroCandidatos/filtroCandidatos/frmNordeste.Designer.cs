
namespace filtroCandidatos
{
    partial class frmNordeste
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
            this.groupBox82 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarATelaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox82.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui aparecerá os dados da região Nordeste onde mostra locais com alto numero de " +
    "pobreza";
            // 
            // groupBox82
            // 
            this.groupBox82.Controls.Add(this.label1);
            this.groupBox82.Location = new System.Drawing.Point(136, 238);
            this.groupBox82.Name = "groupBox82";
            this.groupBox82.Size = new System.Drawing.Size(526, 100);
            this.groupBox82.TabIndex = 1;
            this.groupBox82.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarATelaInicialToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarATelaInicialToolStripMenuItem
            // 
            this.voltarATelaInicialToolStripMenuItem.Name = "voltarATelaInicialToolStripMenuItem";
            this.voltarATelaInicialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voltarATelaInicialToolStripMenuItem.Text = "Voltar a tela inicial";
            this.voltarATelaInicialToolStripMenuItem.Click += new System.EventHandler(this.voltarATelaInicialToolStripMenuItem_Click);
            // 
            // frmNordeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox82);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNordeste";
            this.Text = "Região Nordeste";
            this.Load += new System.EventHandler(this.frmNordeste_Load);
            this.groupBox82.ResumeLayout(false);
            this.groupBox82.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox82;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarATelaInicialToolStripMenuItem;
    }
}