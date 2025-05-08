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
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimplyConect
{
    public partial class Form1 : Form
    {
        string textFoundError = "";
        string textCorrectTerm = "";
        string textNoteFaac = "";
        string textNoteRossi = "";

        private string caminhoPlanilha = "";
        private List<Registro> registros = new List<Registro>();
        private byte[] imagemSelecionada = null;

        string pathPlanilha;

        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            btn_traduzir.Items.AddRange(new[] { "Errors", "Improvements" });
            btn_traduzir.SelectedIndex = 0;
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            ReadPath();
            AtualizaDataGridView();
        }
        void AtualizaDataGridView()
        {
            try
            {
                if (cmbArquivo.SelectedItem == null || btn_traduzir.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um arquivo e uma aba antes de continuar.");
                    return;
                }

                caminhoPlanilha = Path.Combine(pathPlanilha, cmbArquivo.SelectedItem.ToString());
                string aba = btn_traduzir.SelectedItem.ToString();
                registros.Clear();

                using (var package = new ExcelPackage(new FileInfo(caminhoPlanilha)))
                {
                    var sheet = package.Workbook.Worksheets[aba];
                    int row = 3;

                    if (sheet == null)
                    {
                        MessageBox.Show($"A aba '{aba}' não foi encontrada na planilha. Verifique se o caminho do arquivo está correto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

                for (int i = 0; i < dgvRegistros.Columns.Count; i++)
                {
                    dgvRegistros.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a planilha:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CarregarArquivosNoComboBox()
        {
            cmbArquivo.Items.Clear();

            if (!Directory.Exists(pathPlanilha))
            {
                MessageBox.Show("A pasta selecionada não existe.");
                return;
            }

            var arquivos = Directory.GetFiles(pathPlanilha, "*SIMPLY CONNECT*.xlsx");

            foreach (var arquivo in arquivos)
            {
                cmbArquivo.Items.Add(Path.GetFileName(arquivo));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cabeçalho

            int linhaExcel = e.RowIndex + 3; // Considerando que a linha 0 do DataGridView é a linha 3 da planilha
            string aba = btn_traduzir.SelectedItem.ToString();

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
            textCorrectTerm = row.Cells["Correcao"].Value?.ToString();
            richTextBox2.AppendText($"📌 {textCorrectTerm}\n\n");

            richTextBox3.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox3.AppendText("📖 FAAC NOTES:\n\n");
            textNoteFaac = row.Cells["NoteFaac"].Value?.ToString();
            richTextBox3.AppendText($"📌 {textNoteFaac}\n\n");

            richTextBox4.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox4.AppendText("📖 ROSSI NOTES:\n\n");
            textNoteRossi = row.Cells["NoteRossi"].Value?.ToString();
            richTextBox4.AppendText($"📌 {textNoteRossi}\n\n");
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
            string nomefile = cmbArquivo.SelectedItem.ToString();
            cadastro cadastro = new cadastro(btn_traduzir.SelectedItem.ToString(), caminhoPlanilha, nomefile);
            cadastro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadPath();
            CarregarArquivosNoComboBox();
        }

        void ReadPath()
        {
            if (!File.Exists("pastas.json"))
                return;

            string json = File.ReadAllText("pastas.json");
            var pastas = JsonConvert.DeserializeObject<List<PastaInfo>>(json);

            pathPlanilha = pastas[0].Caminho;
        }

        private async Task<string> ExtrairTraducao(string text)
        {
            string idiomaOrigem = "en";
            string idiomaDestino = "pt";
            string traducao = "";

            string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={idiomaOrigem}&tl={idiomaDestino}&dt=t&q={Uri.EscapeDataString(text)}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string resultado = await response.Content.ReadAsStringAsync();

                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(resultado))
                        {
                            var frases = doc.RootElement[0];
                            foreach (var parte in frases.EnumerateArray())
                            {
                                traducao += parte[0].GetString();
                            }

                            return traducao;
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Erro ao processar a resposta JSON: " + ex.Message;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao traduzir: " + ex.Message);
                    return "Erro ao traduzir.";
                }
            }
        }

        private async void Traduzir_FoundError_Click()
        {
            string textTraduzido = await ExtrairTraducao(textFoundError);

            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox1.AppendText("📖 Found Error:\n\n");
            richTextBox1.AppendText($"📌 {textTraduzido}\n\n");
        }

        private async void Traduzir_CorrectTerm_Click()
        {
            string textTraduzido = await ExtrairTraducao(textCorrectTerm);

            richTextBox2.Clear();
            richTextBox2.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox2.AppendText("📖 Correct Term:\n\n");
            richTextBox2.AppendText($"📌 {textTraduzido}\n\n");
        }

        private async void Traduzir_NoteFaac_Click()
        {
            string textTraduzido = await ExtrairTraducao(textNoteFaac);

            richTextBox3.Clear();
            richTextBox3.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox3.AppendText("📖 FAAC NOTES:\n\n");
            richTextBox3.AppendText($"📌 {textTraduzido}\n\n");
        }

        private async void Traduzir_NoteRossi_Click()
        {
            string textTraduzido = await ExtrairTraducao(textNoteRossi);

            richTextBox4.Clear();
            richTextBox4.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox4.AppendText("📖 ROSSI NOTES:\n\n");
            richTextBox4.AppendText($"📌 {textTraduzido}\n\n");
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = caminhoPlanilha;

            if (File.Exists(caminhoArquivo))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado: " + caminhoArquivo);
            }
        }

        private void button_traduzir_Click(object sender, EventArgs e)
        {
            Traduzir_FoundError_Click();
            Traduzir_CorrectTerm_Click();
            Traduzir_NoteFaac_Click();
            Traduzir_NoteRossi_Click();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Height > 1000)
            {
                dgvRegistros.Height = 400; // Margem superior e inferior
            }
            else
            {
                dgvRegistros.Height = 255;
            }
        }

        private void dgvRegistros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se é a 8ª coluna (índice 7)
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                string valor = e.Value.ToString().ToUpper();

                switch (valor)
                {
                    case "OK":
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "NS":
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        break;

                    case "WORK IN PROGRESS":
                        e.CellStyle.BackColor = Color.BurlyWood;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "NO ACTION":
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "WAITING RELEASE":
                        e.CellStyle.BackColor = Color.LightBlue;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    default:
                        e.CellStyle.BackColor = dgvRegistros.DefaultCellStyle.BackColor;
                        e.CellStyle.ForeColor = dgvRegistros.DefaultCellStyle.ForeColor;
                        break;
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
