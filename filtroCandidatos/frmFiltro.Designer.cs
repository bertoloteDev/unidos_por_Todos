
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarParaTelaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarParaTelaAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalidades
            // 
            this.txtLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtLocalidades.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidades.ForeColor = System.Drawing.Color.White;
            this.txtLocalidades.Location = new System.Drawing.Point(144, 24);
            this.txtLocalidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLocalidades.Name = "txtLocalidades";
            this.txtLocalidades.Size = new System.Drawing.Size(194, 29);
            this.txtLocalidades.TabIndex = 0;
            this.txtLocalidades.Text = "  1 -LOCALIDADES      ";
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuant.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.ForeColor = System.Drawing.Color.White;
            this.txtQuant.Location = new System.Drawing.Point(503, 24);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(382, 29);
            this.txtQuant.TabIndex = 1;
            this.txtQuant.Text = "2- QUANTIDADES DE CADASTRADOS";
            this.txtQuant.TextChanged += new System.EventHandler(this.txtQuant_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFiltrar.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(435, 442);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(113, 38);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1459, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarParaTelaInicialToolStripMenuItem,
            this.voltarParaTelaAnteriorToolStripMenuItem,
            this.alteraçãoDeDadosToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarParaTelaInicialToolStripMenuItem
            // 
            this.voltarParaTelaInicialToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline);
            this.voltarParaTelaInicialToolStripMenuItem.Name = "voltarParaTelaInicialToolStripMenuItem";
            this.voltarParaTelaInicialToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.voltarParaTelaInicialToolStripMenuItem.Text = "Voltar para tela Inicial";
            this.voltarParaTelaInicialToolStripMenuItem.Click += new System.EventHandler(this.voltarParaTelaInicialToolStripMenuItem_Click);
            // 
            // voltarParaTelaAnteriorToolStripMenuItem
            // 
            this.voltarParaTelaAnteriorToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline);
            this.voltarParaTelaAnteriorToolStripMenuItem.Name = "voltarParaTelaAnteriorToolStripMenuItem";
            this.voltarParaTelaAnteriorToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.voltarParaTelaAnteriorToolStripMenuItem.Text = "Voltar para tela anterior";
            this.voltarParaTelaAnteriorToolStripMenuItem.Click += new System.EventHandler(this.voltarParaTelaAnteriorToolStripMenuItem_Click);
            // 
            // alteraçãoDeDadosToolStripMenuItem
            // 
            this.alteraçãoDeDadosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline);
            this.alteraçãoDeDadosToolStripMenuItem.Name = "alteraçãoDeDadosToolStripMenuItem";
            this.alteraçãoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.alteraçãoDeDadosToolStripMenuItem.Text = "Alteração de Dados";
            this.alteraçãoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.alteraçãoDeDadosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLocalidades);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.txtLocalidades);
            this.groupBox1.Location = new System.Drawing.Point(172, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 498);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(41, 69);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.Size = new System.Drawing.Size(916, 354);
            this.dgvLocalidades.TabIndex = 3;
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1459, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmFiltro";
            this.Text = "Filtros de Ongs cadastradas";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtLocalidades;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarParaTelaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarParaTelaAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoDeDadosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLocalidades;
    }
}