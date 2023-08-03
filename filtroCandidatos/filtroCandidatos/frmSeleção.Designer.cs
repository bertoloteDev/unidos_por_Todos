
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarATelaPricipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox88 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox88.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELEÇÃO DE REGIÕES";
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(64, 92);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(100, 60);
            this.btnNorte.TabIndex = 1;
            this.btnNorte.Text = "Norte";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNordeste
            // 
            this.btnNordeste.Location = new System.Drawing.Point(64, 168);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(100, 60);
            this.btnNordeste.TabIndex = 1;
            this.btnNordeste.Text = "Nordeste";
            this.btnNordeste.UseVisualStyleBackColor = true;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // btnCentroOeste
            // 
            this.btnCentroOeste.Location = new System.Drawing.Point(183, 92);
            this.btnCentroOeste.Name = "btnCentroOeste";
            this.btnCentroOeste.Size = new System.Drawing.Size(100, 60);
            this.btnCentroOeste.TabIndex = 1;
            this.btnCentroOeste.Text = "Centro-Oeste";
            this.btnCentroOeste.UseVisualStyleBackColor = true;
            this.btnCentroOeste.Click += new System.EventHandler(this.btnCentroOeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(183, 168);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(100, 60);
            this.btnSul.TabIndex = 1;
            this.btnSul.Text = "Sul";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.Location = new System.Drawing.Point(124, 247);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(100, 60);
            this.btnSudeste.TabIndex = 1;
            this.btnSudeste.Text = "Sudeste";
            this.btnSudeste.UseVisualStyleBackColor = true;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1442, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarATelaPricipalToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarATelaPricipalToolStripMenuItem
            // 
            this.voltarATelaPricipalToolStripMenuItem.Name = "voltarATelaPricipalToolStripMenuItem";
            this.voltarATelaPricipalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.voltarATelaPricipalToolStripMenuItem.Text = "Voltar a tela pricipal";
            this.voltarATelaPricipalToolStripMenuItem.Click += new System.EventHandler(this.voltarATelaPricipalToolStripMenuItem_Click);
            // 
            // groupBox88
            // 
            this.groupBox88.Controls.Add(this.btnCentroOeste);
            this.groupBox88.Controls.Add(this.btnSudeste);
            this.groupBox88.Controls.Add(this.label1);
            this.groupBox88.Controls.Add(this.btnSul);
            this.groupBox88.Controls.Add(this.btnNorte);
            this.groupBox88.Controls.Add(this.btnNordeste);
            this.groupBox88.Location = new System.Drawing.Point(747, 195);
            this.groupBox88.Name = "groupBox88";
            this.groupBox88.Size = new System.Drawing.Size(344, 332);
            this.groupBox88.TabIndex = 3;
            this.groupBox88.TabStop = false;
            this.groupBox88.Enter += new System.EventHandler(this.groupBox88_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1345, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar ONG";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSeleção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1442, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox88);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeleção";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GabrielFBraz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox88.ResumeLayout(false);
            this.groupBox88.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarATelaPricipalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox88;
        private System.Windows.Forms.Button button1;
    }
}