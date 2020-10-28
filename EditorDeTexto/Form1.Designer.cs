namespace EditorDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.italico = new System.Windows.Forms.PictureBox();
            this.LerArquivo = new System.Windows.Forms.PictureBox();
            this.negrito = new System.Windows.Forms.PictureBox();
            this.novoArquivo = new System.Windows.Forms.PictureBox();
            this.centralizar = new System.Windows.Forms.PictureBox();
            this.alinharDireita = new System.Windows.Forms.PictureBox();
            this.alinharEsquerda = new System.Windows.Forms.PictureBox();
            this.fonte = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pagina = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.svdlg1 = new System.Windows.Forms.SaveFileDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.italico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LerArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinharDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinharEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fonte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.italico);
            this.panel1.Controls.Add(this.LerArquivo);
            this.panel1.Controls.Add(this.negrito);
            this.panel1.Controls.Add(this.novoArquivo);
            this.panel1.Controls.Add(this.centralizar);
            this.panel1.Controls.Add(this.alinharDireita);
            this.panel1.Controls.Add(this.alinharEsquerda);
            this.panel1.Controls.Add(this.fonte);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(888, 84);
            this.panel1.TabIndex = 0;
            // 
            // italico
            // 
            this.italico.Image = ((System.Drawing.Image)(resources.GetObject("italico.Image")));
            this.italico.Location = new System.Drawing.Point(455, 10);
            this.italico.Name = "italico";
            this.italico.Size = new System.Drawing.Size(30, 30);
            this.italico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.italico.TabIndex = 14;
            this.italico.TabStop = false;
            this.italico.Click += new System.EventHandler(this.italico_Click);
            this.italico.MouseEnter += new System.EventHandler(this.italico_MouseEnter);
            this.italico.MouseLeave += new System.EventHandler(this.italico_MouseLeave);
            // 
            // LerArquivo
            // 
            this.LerArquivo.Image = ((System.Drawing.Image)(resources.GetObject("LerArquivo.Image")));
            this.LerArquivo.Location = new System.Drawing.Point(12, 44);
            this.LerArquivo.Name = "LerArquivo";
            this.LerArquivo.Size = new System.Drawing.Size(26, 28);
            this.LerArquivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LerArquivo.TabIndex = 13;
            this.LerArquivo.TabStop = false;
            this.LerArquivo.Click += new System.EventHandler(this.LerArquivo_Click_1);
            this.LerArquivo.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.LerArquivo.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // negrito
            // 
            this.negrito.Image = ((System.Drawing.Image)(resources.GetObject("negrito.Image")));
            this.negrito.Location = new System.Drawing.Point(419, 10);
            this.negrito.Name = "negrito";
            this.negrito.Size = new System.Drawing.Size(30, 30);
            this.negrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.negrito.TabIndex = 12;
            this.negrito.TabStop = false;
            this.negrito.Click += new System.EventHandler(this.negrito_Click);
            this.negrito.MouseEnter += new System.EventHandler(this.negrito_MouseEnter);
            this.negrito.MouseLeave += new System.EventHandler(this.negrito_MouseLeave);
            // 
            // novoArquivo
            // 
            this.novoArquivo.Image = ((System.Drawing.Image)(resources.GetObject("novoArquivo.Image")));
            this.novoArquivo.Location = new System.Drawing.Point(12, 12);
            this.novoArquivo.Name = "novoArquivo";
            this.novoArquivo.Size = new System.Drawing.Size(25, 28);
            this.novoArquivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.novoArquivo.TabIndex = 10;
            this.novoArquivo.TabStop = false;
            this.novoArquivo.Click += new System.EventHandler(this.novoArquivo_Click);
            this.novoArquivo.MouseEnter += new System.EventHandler(this.novoArquivo_MouseEnter);
            this.novoArquivo.MouseLeave += new System.EventHandler(this.novoArquivo_MouseLeave);
            // 
            // centralizar
            // 
            this.centralizar.Image = ((System.Drawing.Image)(resources.GetObject("centralizar.Image")));
            this.centralizar.Location = new System.Drawing.Point(419, 48);
            this.centralizar.Name = "centralizar";
            this.centralizar.Size = new System.Drawing.Size(30, 30);
            this.centralizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.centralizar.TabIndex = 9;
            this.centralizar.TabStop = false;
            this.centralizar.Click += new System.EventHandler(this.centralizar_Click);
            this.centralizar.MouseEnter += new System.EventHandler(this.centralizar_MouseEnter);
            this.centralizar.MouseLeave += new System.EventHandler(this.centralizar_MouseLeave);
            // 
            // alinharDireita
            // 
            this.alinharDireita.Image = ((System.Drawing.Image)(resources.GetObject("alinharDireita.Image")));
            this.alinharDireita.Location = new System.Drawing.Point(455, 48);
            this.alinharDireita.Name = "alinharDireita";
            this.alinharDireita.Size = new System.Drawing.Size(30, 30);
            this.alinharDireita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alinharDireita.TabIndex = 8;
            this.alinharDireita.TabStop = false;
            this.alinharDireita.Click += new System.EventHandler(this.alinharDireita_Click);
            this.alinharDireita.MouseEnter += new System.EventHandler(this.alinharDireita_MouseEnter);
            this.alinharDireita.MouseLeave += new System.EventHandler(this.alinharDireita_MouseLeave);
            // 
            // alinharEsquerda
            // 
            this.alinharEsquerda.Image = ((System.Drawing.Image)(resources.GetObject("alinharEsquerda.Image")));
            this.alinharEsquerda.Location = new System.Drawing.Point(383, 48);
            this.alinharEsquerda.Name = "alinharEsquerda";
            this.alinharEsquerda.Size = new System.Drawing.Size(30, 30);
            this.alinharEsquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alinharEsquerda.TabIndex = 6;
            this.alinharEsquerda.TabStop = false;
            this.alinharEsquerda.Click += new System.EventHandler(this.alinharEsquerda_Click);
            this.alinharEsquerda.MouseEnter += new System.EventHandler(this.alinharEsquerda_MouseEnter);
            this.alinharEsquerda.MouseLeave += new System.EventHandler(this.alinharEsquerda_MouseLeave);
            // 
            // fonte
            // 
            this.fonte.Image = ((System.Drawing.Image)(resources.GetObject("fonte.Image")));
            this.fonte.Location = new System.Drawing.Point(383, 10);
            this.fonte.Name = "fonte";
            this.fonte.Size = new System.Drawing.Size(30, 30);
            this.fonte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fonte.TabIndex = 4;
            this.fonte.TabStop = false;
            this.fonte.MouseEnter += new System.EventHandler(this.fonte_MouseEnter);
            this.fonte.MouseLeave += new System.EventHandler(this.fonte_MouseLeave);
            this.fonte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fonte_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(851, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.pagina);
            this.panel3.Location = new System.Drawing.Point(164, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 662);
            this.panel3.TabIndex = 2;
            // 
            // pagina
            // 
            this.pagina.BackColor = System.Drawing.SystemColors.Info;
            this.pagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagina.Location = new System.Drawing.Point(0, 0);
            this.pagina.Name = "pagina";
            this.pagina.Size = new System.Drawing.Size(542, 662);
            this.pagina.TabIndex = 0;
            this.pagina.Text = "";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 767);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 21);
            this.panel4.TabIndex = 2;
            // 
            // svdlg1
            // 
            this.svdlg1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(888, 788);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.italico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LerArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinharDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinharEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fonte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox fonte;
        private System.Windows.Forms.PictureBox alinharEsquerda;
        private System.Windows.Forms.PictureBox centralizar;
        private System.Windows.Forms.PictureBox alinharDireita;
        private System.Windows.Forms.PictureBox novoArquivo;
        private System.Windows.Forms.PictureBox italico;
        private System.Windows.Forms.PictureBox LerArquivo;
        private System.Windows.Forms.PictureBox negrito;
        private System.Windows.Forms.SaveFileDialog svdlg1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.RichTextBox pagina;
    }
}

