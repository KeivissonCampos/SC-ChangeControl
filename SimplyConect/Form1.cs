using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimplyConect
{
    public partial class Form1 : Form
    {
        string textFoundError = "";

        private string caminhoPlanilha = "";
        private List<Registro> registros = new List<Registro>();
        private byte[] imagemSelecionada = null;

        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            cmbAba.Items.AddRange(new[] { "Errors", "Improvements" });
            cmbArquivo.Items.AddRange(new[] { "REV 23_APP SIMPLY CONNECT TEST END USER", "REV 12_APP SIMPLY CONNECT PRO" });
            cmbArquivo.SelectedIndex = 0;
            cmbAba.SelectedIndex = 0;
            AtualizaDataGridView();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            AtualizaDataGridView();
        }
        void AtualizaDataGridView()
        {
            caminhoPlanilha = @"C:\Users\keivisson21\Downloads\SP\" + cmbArquivo.SelectedItem.ToString() + " - ERRORS AND IMPROVEMENTS.xlsx";
            registros.Clear();
            string aba = cmbAba.SelectedItem.ToString();

            try
            {
                using (var package = new ExcelPackage(new FileInfo(caminhoPlanilha)))
                {
                    var sheet = package.Workbook.Worksheets[aba];
                    int row = 3;

                    while (sheet.Cells[row, 1].Value != null)
                    {
                        registros.Add(new Registro
                        {
                            Numero = int.Parse(sheet.Cells[row, 1].Text),
                            Plataforma = sheet.Cells[row, 3].Text,
                            Ambiente = sheet.Cells[row, 4].Text,
                            Descricao = sheet.Cells[row, 5].Text,
                            Correcao = sheet.Cells[row, 6].Text,
                            Prioridade = sheet.Cells[row, 7].Text,
                            Solicitante = sheet.Cells[row, 8].Text,
                            Status = sheet.Cells[row, 9].Text,
                            NoteFaac = sheet.Cells[row, 10].Text,
                            NoteRossi = sheet.Cells[row, 11].Text
                        });
                        row++;
                    }
                }

                dgvRegistros.DataSource = null;
                dgvRegistros.DataSource = registros;
            }
            catch (IOException)
            {
                MessageBox.Show("Erro ao ler o arquivo. Ele pode estar aberto no Excel ou bloqueado por outro processo.",
                                "Erro de leitura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cabeçalho

            int linhaExcel = e.RowIndex + 3; // Considerando que a linha 0 do DataGridView é a linha 3 da planilha
            string aba = cmbAba.SelectedItem.ToString();

            using (var package = new ExcelPackage(new FileInfo(caminhoPlanilha)))
            {
                var sheet = package.Workbook.Worksheets[aba];
                var imagem = ObterImagemDaLinha(sheet, linhaExcel);
                imgExcel.Image = imagem;
            }
            DataGridViewRow row = dgvRegistros.Rows[e.RowIndex];

            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();

            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox1.AppendText("📖 Found Error:\n\n");
            textFoundError = row.Cells["Descricao"].Value?.ToString();
            richTextBox1.AppendText($"📌 {textFoundError}\n\n");

            richTextBox2.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox2.AppendText("📖 Correct Term:\n\n");
            richTextBox2.AppendText($"📌 {row.Cells["Correcao"].Value?.ToString()}\n\n");

            richTextBox3.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox3.AppendText("📖 FAAC NOTES:\n\n");
            richTextBox3.AppendText($"📌 {row.Cells["NoteFaac"].Value?.ToString()}\n\n");

            richTextBox4.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox4.AppendText("📖 ROSSI NOTES:\n\n");
            richTextBox4.AppendText($"📌 {row.Cells["NoteRossi"].Value?.ToString()}\n\n");
        }

        private Image ObterImagemDaLinha(ExcelWorksheet sheet, int linha)
        {
            foreach (var drawing in sheet.Drawings)
            {
                if (drawing is ExcelPicture pic)
                {
                    if (pic.From.Row == linha - 1 && pic.From.Column == 1) // Coluna 2 (índice 1)
                    {
                        using (var ms = new MemoryStream(pic.Image.ImageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }

            return null;
        }
        private void picImagem_Click(object sender, EventArgs e)
        {
            if (imgExcel.Image != null)
            {
                try
                {
                    // Caminho temporário
                    string tempPath = Path.Combine(Path.GetTempPath(), "imagem_temp.jpg");

                    // Clonar a imagem antes de salvar
                    using (Bitmap bmp = new Bitmap(imgExcel.Image))
                    {
                        bmp.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    // Abrir com o visualizador padrão do Windows
                    Process.Start(new ProcessStartInfo(tempPath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir a imagem: " + ex.Message);
                }
            }
        }

        private void picImagem_MouseEnter(object sender, EventArgs e)
        {
            imgExcel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picImagem_MouseLeave(object sender, EventArgs e)
        {
            imgExcel.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro(cmbAba.SelectedItem.ToString(), caminhoPlanilha);
            cadastro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string ExtrairTraducao(string json)
        {
            try
            {
                // Usar JsonDocument para analisar a resposta JSON
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    // A tradução está na posição [0][0][0] da resposta JSON
                    string traducao = doc.RootElement[0][0][0].GetString();

                    return traducao ?? "Erro ao processar a tradução";
                }
            }
            catch (Exception ex)
            {
                return "Erro ao processar a resposta JSON: " + ex.Message;
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            string textoOriginal = textFoundError;  // O texto que o usuário quer traduzir
            string idiomaOrigem = "en";  // Idioma de origem (ex: "en" para inglês)
            string idiomaDestino = "pt";  // Idioma de destino (ex: "pt" para português)

            // Construir a URL para a requisição
            string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={idiomaOrigem}&tl={idiomaDestino}&dt=t&q={Uri.EscapeDataString(textoOriginal)}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Fazer a requisição GET
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Ler o conteúdo da resposta
                    string resultado = await response.Content.ReadAsStringAsync();

                    // Processar a resposta JSON
                    string traducao = ExtrairTraducao(resultado);

                    // Exibir a tradução na label
                    //textBox1.Text = traducao;
                    richTextBox1.Clear();
                    richTextBox1.AppendText("📖 Found Error:\n\n");
                    richTextBox1.AppendText($"📌 {traducao}\n\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao traduzir: " + ex.Message);
                }
            }
        }
    }

    public class Registro
    {
        public int Numero { get; set; }
        public string Plataforma { get; set; }
        public string Ambiente { get; set; }
        public string Descricao { get; set; }
        public string Correcao { get; set; }
        public string Prioridade { get; set; }
        public string Solicitante { get; set; }
        public string Status { get; set; }
        public string NoteFaac { get; set; }
        public string NoteRossi { get; set; }
    }
}
