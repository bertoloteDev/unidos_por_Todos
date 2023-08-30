
namespace filtroCandidatos
{
    partial class frmTeladeDesenvolvedor
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarParaTelaAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consult = new System.Windows.Forms.Button();
            this.consult2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl1.Location = new System.Drawing.Point(104, 118);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(260, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "USUÁRIOS CADASTRADOS:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(986, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ONGs CADASTRADAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(438, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "PÁGINA DO DESENVOLVEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(500, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOCAIS QUE PRECISAM DE AJUDA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // logoff
            // 
            this.logoff.Location = new System.Drawing.Point(712, 637);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(115, 42);
            this.logoff.TabIndex = 7;
            this.logoff.Text = "VOLTAR";
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarParaTelaAnteriorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarParaTelaAnteriorToolStripMenuItem
            // 
            this.voltarParaTelaAnteriorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.voltarParaTelaAnteriorToolStripMenuItem.Name = "voltarParaTelaAnteriorToolStripMenuItem";
            this.voltarParaTelaAnteriorToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.voltarParaTelaAnteriorToolStripMenuItem.Text = "Voltar para tela anterior ";
            this.voltarParaTelaAnteriorToolStripMenuItem.Click += new System.EventHandler(this.voltarParaTelaAnteriorToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.consult2);
            this.groupBox1.Controls.Add(this.consult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 466);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // consult
            // 
            this.consult.Location = new System.Drawing.Point(177, 205);
            this.consult.Name = "consult";
            this.consult.Size = new System.Drawing.Size(98, 40);
            this.consult.TabIndex = 6;
            this.consult.Text = "CONSULTAR";
            this.consult.UseVisualStyleBackColor = true;
            this.consult.Click += new System.EventHandler(this.consult_Click);
            // 
            // consult2
            // 
            this.consult2.Location = new System.Drawing.Point(1041, 205);
            this.consult2.Name = "consult2";
            this.consult2.Size = new System.Drawing.Size(97, 41);
            this.consult2.TabIndex = 7;
            this.consult2.Text = "CONSULTAR";
            this.consult2.UseVisualStyleBackColor = true;
            this.consult2.Click += new System.EventHandler(this.consult2_Click);
            // 
            // frmTeladeDesenvolvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1477, 899);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoff);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTeladeDesenvolvedor";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmTeladeDesenvolvedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem voltarParaTelaAnteriorToolStripMenuItem;
        private System.Windows.Forms.Button consult;
        private System.Windows.Forms.Button consult2;
    }
}