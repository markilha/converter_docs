using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace ConverterDocumento
{
    public partial class Form1 : Form
    {
        public static Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
try
            {
                string caminho = "";

                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    caminho = fbd1.SelectedPath;
                }

                ProcuraArquivos(lbArquivos, caminho, cboPadraoArquivos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ProcuraArquivos(ListBox lstb, string pastaInicial, string padrao)
        {

            // Limpa a listbox
            lstb.Items.Clear();

            // Define os padrões
            string[] padroes = AnalisaPadroes(padrao);
            DirectoryInfo dir_info = new DirectoryInfo(pastaInicial);
            //Procura no diretório usando os padrões
            ProcuraDiretorio(lstb, dir_info, padroes);
            //exibe mensagem 
            MessageBox.Show("Foram encontrados " + lstb.Items.Count + " arquivos.");

        }
        private static void ProcuraDiretorio(ListBox lstb, DirectoryInfo dir_info, string[] padroes)
        {
            try
            {
                // Procura o diretorio
                foreach (string padrao in padroes)
                {
                    // Verifica o padrão
                    foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    {
                        // Processa o arquivo

                        ProcessaArquivo(lstb, Arq_info);
                    }
                }

                // Procura nos subdiretorios
                foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
                {
                    ProcuraDiretorio(lstb, subdir_info, padroes);
                }
            }
            catch
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static string[] AnalisaPadroes(string string_padrao)
        {
            try
            {
                // Pega tudo que esta entre os parenteses
                if (string_padrao.Contains("("))
                {

                    string_padrao = TextoEntre(string_padrao, "(", ")");
                }

                // divide a string em ;
                string[] resultado = string_padrao.Split(';');

                // Remove todos os padrões para espaço extra
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = resultado[i].Trim();
                }
                //retorna o resultado
                return resultado;
            }
            catch
            {
                throw;
            }
        }
        private static string TextoEntre(string txt, string delimitador1, string delimitador2)
        {
            try
            {
                // Encontra o delimitador inicial
                int pos1 = txt.IndexOf(delimitador1);
                int texto_inicio = pos1 + delimitador1.Length;
                int pos2 = txt.IndexOf(delimitador2, texto_inicio);
                return txt.Substring(texto_inicio, pos2 - texto_inicio);
            }
            catch
            {
                throw;
            }
        }
        private static void ProcessaArquivo(ListBox lstb, FileInfo arq_info)
        {
            try
            {
                //exibe o nome do arquivo no listbox
                lstb.Items.Add(arq_info.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message);
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;
                foreach (string caminho in lbArquivos.Items)
                {
                    string pdfSaida = caminho.Replace("docx", "pdf");                 
                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    wordDocument = appWord.Documents.Open(caminho);
                    wordDocument.ExportAsFixedFormat(pdfSaida, WdExportFormat.wdExportFormatPDF);
                    appWord.Quit();
                    wordDocument.Close();
                    cont++;
                    BarraProgresso(progressBar1, lbArquivos.Items.Count, cont);
                }
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string BarraProgresso(ProgressBar processo, int progressBarMaximo, int contagem)
        {
            double porc = 0;
            processo.Maximum = progressBarMaximo;

            if (contagem < progressBarMaximo)
            {
                contagem += 1;
                processo.Value = contagem;
                porc = ((100 * processo.Value) / processo.Maximum);

            }

            return porc.ToString();
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            try
            {
                PdfDocument destino = new PdfDocument();

                foreach (string caminho in lbArquivos.Items)
                {

                    using (PdfDocument origem = PdfReader.Open(caminho, PdfDocumentOpenMode.Import))
                    {
                        int count = origem.PageCount;
                        for (int i = 0; i < count; i++)
                        {
                            PdfPage page = origem.Pages[i];
                            destino.AddPage(page);
                        }
                        cont++;

                        BarraProgresso(progressBar1, lbArquivos.Items.Count, cont);

                    }
                }

                destino.Save(CaminhoSalva("PDF|*.pdf", "", "pdfFinal.pdf"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static string CaminhoSalva(string filtro, string diretorio, string nome)
        {
            string caminho = "";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = "Selecione o caminho para salvar";
            fileDialog.FileName = nome;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName; 

            }

            return caminho;
        }
    }
}
