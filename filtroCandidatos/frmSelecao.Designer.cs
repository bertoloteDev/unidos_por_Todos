
namespace filtroCandidatos
{
    partial class frmSelecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecao));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentroOeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.groupBox88 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarSemhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quemSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox88.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(232, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELEÇÃO DE REGIÕES";
            // 
            // btnNordeste
            // 
            this.btnNordeste.BackColor = System.Drawing.Color.Transparent;
            this.btnNordeste.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNordeste.ForeColor = System.Drawing.Color.Transparent;
            this.btnNordeste.Image = ((System.Drawing.Image)(resources.GetObject("btnNordeste.Image")));
            this.btnNordeste.Location = new System.Drawing.Point(458, 104);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(130, 108);
            this.btnNordeste.TabIndex = 1;
            this.btnNordeste.UseVisualStyleBackColor = false;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // btnCentroOeste
            // 
            this.btnCentroOeste.BackColor = System.Drawing.Color.Transparent;
            this.btnCentroOeste.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentroOeste.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCentroOeste.Image = ((System.Drawing.Image)(resources.GetObject("btnCentroOeste.Image")));
            this.btnCentroOeste.Location = new System.Drawing.Point(311, 207);
            this.btnCentroOeste.Name = "btnCentroOeste";
            this.btnCentroOeste.Size = new System.Drawing.Size(119, 81);
            this.btnCentroOeste.TabIndex = 1;
            this.btnCentroOeste.UseVisualStyleBackColor = false;
            this.btnCentroOeste.Click += new System.EventHandler(this.btnCentroOeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.BackColor = System.Drawing.Color.Transparent;
            this.btnSul.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSul.Image = ((System.Drawing.Image)(resources.GetObject("btnSul.Image")));
            this.btnSul.Location = new System.Drawing.Point(352, 338);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(91, 75);
            this.btnSul.TabIndex = 1;
            this.btnSul.UseVisualStyleBackColor = false;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.BackColor = System.Drawing.Color.Transparent;
            this.btnSudeste.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSudeste.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSudeste.Image = ((System.Drawing.Image)(resources.GetObject("btnSudeste.Image")));
            this.btnSudeste.Location = new System.Drawing.Point(436, 271);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(81, 49);
            this.btnSudeste.TabIndex = 1;
            this.btnSudeste.UseVisualStyleBackColor = false;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // groupBox88
            // 
            this.groupBox88.Controls.Add(this.btnNorte);
            this.groupBox88.Controls.Add(this.btnNordeste);
            this.groupBox88.Controls.Add(this.btnCentroOeste);
            this.groupBox88.Controls.Add(this.btnSudeste);
            this.groupBox88.Controls.Add(this.btnSul);
            this.groupBox88.Controls.Add(this.pictureBox1);
            this.groupBox88.Location = new System.Drawing.Point(324, 84);
            this.groupBox88.Name = "groupBox88";
            this.groupBox88.Size = new System.Drawing.Size(772, 441);
            this.groupBox88.TabIndex = 3;
            this.groupBox88.TabStop = false;
            this.groupBox88.Enter += new System.EventHandler(this.groupBox88_Enter);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.oNGToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1442, 28);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recuperarSemhaToolStripMenuItem,
            this.quemSomosToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.cadastrosToolStripMenuItem.Text = "Menu";
            // 
            // recuperarSemhaToolStripMenuItem
            // 
            this.recuperarSemhaToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperarSemhaToolStripMenuItem.Name = "recuperarSemhaToolStripMenuItem";
            this.recuperarSemhaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recuperarSemhaToolStripMenuItem.Text = "Recuperar senha ";
            // 
            // quemSomosToolStripMenuItem
            // 
            this.quemSomosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            this.quemSomosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quemSomosToolStripMenuItem.Text = "Quem somos?";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loginToolStripMenuItem.Text = "Desenvolvedores ";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // oNGToolStripMenuItem
            // 
            this.oNGToolStripMenuItem.Name = "oNGToolStripMenuItem";
            this.oNGToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.oNGToolStripMenuItem.Text = "ONG";
            this.oNGToolStripMenuItem.Click += new System.EventHandler(this.oNGToolStripMenuItem_Click);
            // 
            // frmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1442, 566);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox88);
            this.Name = "frmSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GabrielFBraz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox88.ResumeLayout(false);
            this.groupBox88.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox88;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarSemhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quemSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNGToolStripMenuItem;
    }
}