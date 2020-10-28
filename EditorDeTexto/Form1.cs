﻿using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
//StreamReader leitor = null;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {

        //;

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
       
        private void pagina_TextChanged(object sender, EventArgs e)
        {
            

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
            Italico();
        }
        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool italico = false;
            nome_fonte = pagina.Font.Name;
            tamanho_fonte = pagina.Font.Size;
            italico = pagina.Font.Italic;
            if (italico == false)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
            else if(italico == true)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
        }
        private void LerArquivo_Click_1(object sender, EventArgs e)
        {
            AbrirArquivo();
        }
       
        private void AbrirArquivo()
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Arquivo";
            ofd1.InitialDirectory = @"C:\Dados\";
            //filtra para exibir somente arquivos textos
            ofd1.Filter = "Images (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Lê o arquivo usando a classe StreamReader
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Lê cada linha do stream e faz o parse até a última linha
                    this.pagina.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        this.pagina.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    // Fecha o stream
                    m_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void novoArquivo_Click(object sender, EventArgs e)
        {
            ChmSalvarArquivo();
            pagina.Clear();
            pagina.Focus();
        }
       
        private void ChamaSalvarArquivo()
        {
            if (!string.IsNullOrEmpty(pagina.Text))
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    Salvar_Arquivo();
                }
            }
        }
        private void Salvar_Arquivo()
        {
            try
            {
                // Pega o nome do arquivo para salvar
                if (this.svdlg1.ShowDialog() == DialogResult.OK)
                {
                    // abre um stream para escrita e cria um StreamWriter para implementar o stream
                    FileStream fs = new FileStream(svdlg1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();
                    // Escreve para o arquivo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    // escreve no controle richtextbox
                    m_streamWriter.Write(this.pagina.Text);
                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LerArquivo.Size = new Size(26, 30);
            OnHouverSound();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            LerArquivo.Size = new Size(24, 28);
        }

        private void alinharEsquerda_Click(object sender, EventArgs e)
        {
            pagina.SelectionAlignment = HorizontalAlignment.Left;
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

      

        private void negrito_MouseEnter(object sender, EventArgs e)
        {
            negrito.Size = new Size(32, 30);
            OnHouverSound();
        }

        private void negrito_MouseLeave(object sender, EventArgs e)
        {
            negrito.Size = new Size(30, 28);
        }

        private void italico_MouseEnter(object sender, EventArgs e)
        {
            italico.Size = new Size(32, 32);
            OnHouverSound();
        }

        private void italico_MouseLeave(object sender, EventArgs e)
        {
            italico.Size = new Size(30, 30);
        }

 
        private void alinharDireita_MouseEnter(object sender, EventArgs e)
        {
            alinharDireita.Size = new Size(32, 32);
            OnHouverSound();
        }

        private void alinharDireita_MouseLeave(object sender, EventArgs e)
        {
            alinharDireita.Size = new Size(30, 30);
        }

        private void centralizar_MouseEnter(object sender, EventArgs e)
        {
            centralizar.Size = new Size(32, 32);
            OnHouverSound();
        }

        private void centralizar_MouseLeave(object sender, EventArgs e)
        {
            centralizar.Size = new Size(30, 30);
        }

  

        private void alinharDireita_Click(object sender, EventArgs e)
        {
            pagina.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centralizar_Click(object sender, EventArgs e)
        {
            pagina.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
       
        private void ChmSalvarArquivo()
        {
            if (!string.IsNullOrEmpty(pagina.Text))
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    Salvar_Arquivo();
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void negrito_Click(object sender, EventArgs e)
        {
            Negritar();
        }

        private void Negritar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool negrito = false;
            nome_fonte = pagina.Font.Name;
            tamanho_fonte = pagina.Font.Size;
            negrito = pagina.Font.Bold;
            if (negrito == false)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
            }
            else
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
