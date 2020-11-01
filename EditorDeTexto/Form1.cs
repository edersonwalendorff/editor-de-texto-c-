using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


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
           
            
        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
         
            btnExit.Size = new Size(22, 22);
            
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
            
        }
        private void fonte_MouseLeave(object sender, EventArgs e)
        {
            fonte.Size = new Size(30, 30);

        }



     








        private void italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        bool verdade = false;
        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            
            nome_fonte = pagina.Font.Name;
            tamanho_fonte = pagina.Font.Size;

            if (verdade == false)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                verdade = true;
            }
            else if(verdade == true)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
                verdade = false;
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
            ofd1.Filter = "Text (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
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
           
        }

        private void fonte_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            LerArquivo.Size = new Size(26, 30);
           
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
           
        }

        private void alinharEsquerda_MouseLeave(object sender, EventArgs e)
        {
            alinharEsquerda.Size = new Size(30, 30);
        }

      

        private void negrito_MouseEnter(object sender, EventArgs e)
        {
            negrito.Size = new Size(32, 30);
          
        }

        private void negrito_MouseLeave(object sender, EventArgs e)
        {
            negrito.Size = new Size(30, 28);
        }

        private void italico_MouseEnter(object sender, EventArgs e)
        {
            italico.Size = new Size(32, 32);
           
        }

        private void italico_MouseLeave(object sender, EventArgs e)
        {
            italico.Size = new Size(30, 30);
        }

 
        private void alinharDireita_MouseEnter(object sender, EventArgs e)
        {
            alinharDireita.Size = new Size(32, 32);
          
        }

        private void alinharDireita_MouseLeave(object sender, EventArgs e)
        {
            alinharDireita.Size = new Size(30, 30);
        }

        private void centralizar_MouseEnter(object sender, EventArgs e)
        {
            centralizar.Size = new Size(32, 32);
            
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
        bool ver = false;
        private void Negritar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            
            nome_fonte = pagina.Font.Name;
            tamanho_fonte = pagina.Font.Size;
          
            if (ver == false)
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                ver = true;
            }
            else
            {
                pagina.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
                ver = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void fonte_Click(object sender, EventArgs e)
        {
            AlterarFonte();
        }

        private void AlterarFonte()
        {
            DialogResult result = fontdlg1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (pagina.SelectionFont != null)
                {
                    pagina.SelectionFont = fontdlg1.Font;
                }
            }
        }

        private void fontdlg1_Apply(object sender, EventArgs e)
        {

        }
    }
}
