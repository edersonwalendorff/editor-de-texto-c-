﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void OnHouverSound()
        {
            SoundPlayer houverSound = new SoundPlayer(@"C:\Users\João\source\repos\EditorDeTexto\EditorDeTexto\resources\sounds/audioOnHouver.wav");
            houverSound.Play();
            
        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
         
            btnExit.Size = new Size(22, 22);
             OnHouverSound();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
           btnExit.Size = new Size(20, 20);


        }
        private void sbtnSave_MouseEnter(object sender, EventArgs e)
        {
            sbtnSave.Size = new Size(27, 26);
            OnHouverSound();
        }

        private void sbtnSave_MouseLeave(object sender, EventArgs e)
        {
            sbtnSave.Size = new Size(25, 24);

        }

        private void pagina_TextChanged(object sender, EventArgs e)
        {
            pagina.SelectionStart = pagina.Text.Length;
            pagina.ScrollToCaret();

        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            btnExit.Size = new Size(20, 20);

        }

        private void fonte_MouseEnter(object sender, EventArgs e)
        {
           
            fonte.Size = new Size(32, 32);
            OnHouverSound();

        }
        private void fonte_MouseLeave(object sender, EventArgs e)
        {
            fonte.Size = new Size(30, 30);

        }



     








        private void italico_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void novoArquivo_Click(object sender, EventArgs e)
        {

        }

        private void novoArquivo_MouseLeave(object sender, EventArgs e)
        {
            novoArquivo.Size = new Size(24, 28);
        }

        private void novoArquivo_MouseEnter(object sender, EventArgs e)
        {
            novoArquivo.Size = new Size(26, 30);
            OnHouverSound();
        }

        private void fonte_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(26, 30);
            OnHouverSound();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(24, 28);
        }

        private void alinharEsquerda_Click(object sender, EventArgs e)
        {

        }

        private void alinharEsquerda_MouseEnter(object sender, EventArgs e)
        {
            alinharEsquerda.Size = new Size(32, 32);
            OnHouverSound();
        }

        private void alinharEsquerda_MouseLeave(object sender, EventArgs e)
        {
            alinharEsquerda.Size = new Size(30, 30);
        }

        private void fontSize_MouseEnter(object sender, EventArgs e)
        {
            fontSize.Size = new Size(32, 32);
            OnHouverSound();
        }

        private void fontSize_MouseLeave(object sender, EventArgs e)
        {
            fontSize.Size = new Size(30, 30);
        }
    }
}
