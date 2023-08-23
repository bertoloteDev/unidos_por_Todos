
namespace filtroCandidatos
{
    partial class frmNorte
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
            this.groupBox80 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarATelaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox80.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui aparecerá os dados da região norte onde mostra locais com alto numero de pob" +
    "reza";
            // 
            // groupBox80
            // 
            this.groupBox80.Controls.Add(this.label1);
            this.groupBox80.Location = new System.Drawing.Point(164, 93);
            this.groupBox80.Name = "groupBox80";
            this.groupBox80.Size = new System.Drawing.Size(703, 100);
            this.groupBox80.TabIndex = 1;
            this.groupBox80.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarATelaDeInicioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarATelaDeInicioToolStripMenuItem
            // 
            this.voltarATelaDeInicioToolStripMenuItem.Name = "voltarATelaDeInicioToolStripMenuItem";
            this.voltarATelaDeInicioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.voltarATelaDeInicioToolStripMenuItem.Text = "Voltar a tela de inicio";
            this.voltarATelaDeInicioToolStripMenuItem.Click += new System.EventHandler(this.voltarATelaDeInicioToolStripMenuItem_Click);
            // 
            // frmNorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.Controls.Add(this.groupBox80);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmNorte";
            this.Text = "Região Norte";
            this.Load += new System.EventHandler(this.frmNorte_Load);
            this.groupBox80.ResumeLayout(false);
            this.groupBox80.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox80;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarATelaDeInicioToolStripMenuItem;
    }
}