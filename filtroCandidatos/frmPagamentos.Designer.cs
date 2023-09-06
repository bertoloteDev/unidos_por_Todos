
namespace filtroCandidatos
{
    partial class frmPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamentos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarParaTelaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radCredito = new System.Windows.Forms.RadioButton();
            this.radDebito = new System.Windows.Forms.RadioButton();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.radPix = new System.Windows.Forms.RadioButton();
            this.maskCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskNume = new System.Windows.Forms.MaskedTextBox();
            this.pBPix = new System.Windows.Forms.PictureBox();
            this.maskvali = new System.Windows.Forms.MaskedTextBox();
            this.btnPaga = new System.Windows.Forms.Button();
            this.gBpag = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPix)).BeginInit();
            this.gBpag.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarParaTelaInicialToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // voltarParaTelaInicialToolStripMenuItem
            // 
            this.voltarParaTelaInicialToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarParaTelaInicialToolStripMenuItem.Name = "voltarParaTelaInicialToolStripMenuItem";
            this.voltarParaTelaInicialToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.voltarParaTelaInicialToolStripMenuItem.Text = "Voltar para tela inicial ";
            this.voltarParaTelaInicialToolStripMenuItem.Click += new System.EventHandler(this.voltarParaTelaInicialToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(807, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(761, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "N° do cartão:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(819, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(814, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CVV:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(715, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Validade do cartão:";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Forma de Pagamento";
            // 
            // radCredito
            // 
            this.radCredito.AutoSize = true;
            this.radCredito.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCredito.ForeColor = System.Drawing.Color.White;
            this.radCredito.Location = new System.Drawing.Point(81, 160);
            this.radCredito.Name = "radCredito";
            this.radCredito.Size = new System.Drawing.Size(92, 27);
            this.radCredito.TabIndex = 10;
            this.radCredito.TabStop = true;
            this.radCredito.Text = "Crédito";
            this.radCredito.UseVisualStyleBackColor = true;
            this.radCredito.CheckedChanged += new System.EventHandler(this.radCredito_CheckedChanged);
            // 
            // radDebito
            // 
            this.radDebito.AutoSize = true;
            this.radDebito.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDebito.ForeColor = System.Drawing.Color.White;
            this.radDebito.Location = new System.Drawing.Point(81, 205);
            this.radDebito.Name = "radDebito";
            this.radDebito.Size = new System.Drawing.Size(86, 27);
            this.radDebito.TabIndex = 11;
            this.radDebito.TabStop = true;
            this.radDebito.Text = "Débito";
            this.radDebito.UseVisualStyleBackColor = true;
            this.radDebito.CheckedChanged += new System.EventHandler(this.radDebito_CheckedChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(894, 198);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 13;
            this.txtnome.Visible = false;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(894, 372);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(100, 20);
            this.txtcvv.TabIndex = 16;
            this.txtcvv.Visible = false;
            // 
            // radPix
            // 
            this.radPix.AutoSize = true;
            this.radPix.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPix.ForeColor = System.Drawing.Color.White;
            this.radPix.Location = new System.Drawing.Point(81, 246);
            this.radPix.Name = "radPix";
            this.radPix.Size = new System.Drawing.Size(57, 27);
            this.radPix.TabIndex = 17;
            this.radPix.TabStop = true;
            this.radPix.Text = "Pix";
            this.radPix.UseVisualStyleBackColor = true;
            this.radPix.CheckedChanged += new System.EventHandler(this.radPix_CheckedChanged);
            // 
            // maskCpf
            // 
            this.maskCpf.Location = new System.Drawing.Point(894, 241);
            this.maskCpf.Mask = "000.000.000-00";
            this.maskCpf.Name = "maskCpf";
            this.maskCpf.Size = new System.Drawing.Size(100, 20);
            this.maskCpf.TabIndex = 18;
            this.maskCpf.Visible = false;
            // 
            // maskNume
            // 
            this.maskNume.Location = new System.Drawing.Point(894, 285);
            this.maskNume.Mask = "0000.0000.0000.0000";
            this.maskNume.Name = "maskNume";
            this.maskNume.Size = new System.Drawing.Size(115, 20);
            this.maskNume.TabIndex = 22;
            this.maskNume.Visible = false;
            // 
            // pBPix
            // 
            this.pBPix.BackColor = System.Drawing.Color.White;
            this.pBPix.Image = ((System.Drawing.Image)(resources.GetObject("pBPix.Image")));
            this.pBPix.Location = new System.Drawing.Point(874, 223);
            this.pBPix.Name = "pBPix";
            this.pBPix.Size = new System.Drawing.Size(159, 159);
            this.pBPix.TabIndex = 24;
            this.pBPix.TabStop = false;
            this.pBPix.Visible = false;
            this.pBPix.Click += new System.EventHandler(this.pBPix_Click);
            // 
            // maskvali
            // 
            this.maskvali.Location = new System.Drawing.Point(894, 326);
            this.maskvali.Mask = "00/00/0000";
            this.maskvali.Name = "maskvali";
            this.maskvali.Size = new System.Drawing.Size(100, 20);
            this.maskvali.TabIndex = 23;
            this.maskvali.ValidatingType = typeof(System.DateTime);
            this.maskvali.Visible = false;
            // 
            // btnPaga
            // 
            this.btnPaga.BackColor = System.Drawing.Color.White;
            this.btnPaga.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnPaga.Location = new System.Drawing.Point(772, 559);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(130, 33);
            this.btnPaga.TabIndex = 24;
            this.btnPaga.Text = "Concluir ";
            this.btnPaga.UseVisualStyleBackColor = false;
            this.btnPaga.Click += new System.EventHandler(this.btnPaga_Click);
            // 
            // gBpag
            // 
            this.gBpag.Controls.Add(this.label8);
            this.gBpag.Controls.Add(this.radCredito);
            this.gBpag.Controls.Add(this.radPix);
            this.gBpag.Controls.Add(this.radDebito);
            this.gBpag.Location = new System.Drawing.Point(288, 123);
            this.gBpag.Name = "gBpag";
            this.gBpag.Size = new System.Drawing.Size(264, 347);
            this.gBpag.TabIndex = 25;
            this.gBpag.TabStop = false;
            this.gBpag.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1477, 645);
            this.Controls.Add(this.maskvali);
            this.Controls.Add(this.btnPaga);
            this.Controls.Add(this.maskNume);
            this.Controls.Add(this.maskCpf);
            this.Controls.Add(this.pBPix);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.gBpag);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPagamentos";
            this.Text = "pagamentos";
            this.Load += new System.EventHandler(this.pagamentos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPix)).EndInit();
            this.gBpag.ResumeLayout(false);
            this.gBpag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radCredito;
        private System.Windows.Forms.RadioButton radDebito;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.RadioButton radPix;
        private System.Windows.Forms.MaskedTextBox maskCpf;
        private System.Windows.Forms.MaskedTextBox maskNume;
        private System.Windows.Forms.PictureBox pBPix;
        private System.Windows.Forms.ToolStripMenuItem voltarParaTelaInicialToolStripMenuItem;
        private System.Windows.Forms.Button btnPaga;
        private System.Windows.Forms.GroupBox gBpag;
        private System.Windows.Forms.MaskedTextBox maskvali;
    }
}