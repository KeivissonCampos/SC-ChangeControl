using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using OfficeOpenXml;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace SimplyConect
{
    public partial class cadastro : Form
    {
        private byte[] imagemSelecionada = null;
        string cellWhere = "";
        string cellEnvironment = "";
        string cellPriority = "";
        string cellFoundErro = "";
        string cellCorrectTerm = "";
        string cellUser = "";

        string cmbAba = "";
        string filePath = "";
        string nomefile = "";

        bool formatImage;

        Form1 form1Principal;

        public cadastro(string _cmbAba, string _filePath, string _nomefile, Form1 formPrincipal)
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            cmbAba = _cmbAba;
            filePath = _filePath;
            nomefile = _nomefile;
            this.form1Principal = formPrincipal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            dataForm();

            string aba = cmbAba.ToString();
            bool registroAdicionado = false;
            int larguraImagem;
            int alturaImagem;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var sheet = package.Workbook.Worksheets[aba];

                // Lógica para adicionar um novo registro
                for (int row = 3; row <= sheet.Dimension.End.Row; row++)
                {
                    var numErro = sheet.Cells[row, 1].Text;

                    // Se número do erro existe e campos estão vazios
                    if (!string.IsNullOrWhiteSpace(numErro) &&
                        string.IsNullOrWhiteSpace(sheet.Cells[row, 5].Text) &&
                        string.IsNullOrWhiteSpace(sheet.Cells[row, 6].Text) &&
                        string.IsNullOrWhiteSpace(sheet.Cells[row, 7].Text) &&
                        string.IsNullOrWhiteSpace(sheet.Cells[row, 8].Text))
                    {
                        sheet.Cells[row, 5].Value = cellWhere;
                        sheet.Cells[row, 6].Value = cellEnvironment;
                        sheet.Cells[row, 7].Value = cellFoundErro;
                        sheet.Cells[row, 8].Value = cellCorrectTerm;
                        sheet.Cells[row, 9].Value = cellPriority;
                        sheet.Cells[row, 10].Value = cellUser;
                        sheet.Cells[row, 11].Value = "NS";

                        if (imagemSelecionada != null)
                        {
                            string nomeImagem = $"img_{row}";
                            if (!sheet.Drawings.Any(d => d.Name == nomeImagem))
                            {
                                var picture = sheet.Drawings.AddPicture(nomeImagem, new MemoryStream(imagemSelecionada));

                                int alturaCelula = 280;
                                int larguraCelula = 425;
                                int larguraCelula2 = 60;

                                // Tamanho da imagem
                                if (formatImage)
                                {
                                    larguraImagem = 360;
                                    alturaImagem = 145;
                                }
                                else
                                {
                                    larguraImagem = 245;
                                    alturaImagem = 260;
                                }

                                // Calcula os deslocamentos para centralizar a imagem
                                int deslocamentoHorizontal = (larguraCelula - larguraImagem) / 2;
                                int deslocamentoVertical = (alturaCelula - alturaImagem) / 2;

                                picture.SetPosition(row - 1, deslocamentoVertical, 1, deslocamentoHorizontal);
                                
                                if (formatImage)
                                {
                                    picture.SetSize(350, 200);
                                }
                                else
                                {
                                    picture.SetSize(220, 350);
                                }

                                sheet.Row(row).Height = alturaCelula;
                                sheet.Column(2).Width = larguraCelula2;
                            }

                        }

                        registroAdicionado = true;
                        break; // Preencheu um, pode sair
                    }
                }

                if (registroAdicionado)
                {
                    try
                    {
                        // Verifique se a planilha está aberta no Excel
                        if (IsExcelFileOpen(filePath))
                        {
                            DialogResult result = MessageBox.Show("A planilha está aberta no Excel. Deseja forçar o fechamento para salvar?",
                                                                  "Arquivo em uso",
                                                                  MessageBoxButtons.YesNo,
                                                                  MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                ForceExcelToClose(filePath);
                                package.Save();
                                MessageBox.Show("Registro completado com sucesso.");
                                //btnLer.PerformClick(); // Recarrega os dados
                                this.Close();
                            }
                        }
                        else
                        {
                            package.Save();
                            MessageBox.Show("Registro completado com sucesso.");
                            //btnLer.PerformClick(); // Recarrega os dados
                            this.Close();
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("A planilha está em uso por outro processo. Tente novamente mais tarde.",
                                        "Erro ao salvar",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma linha disponível para completar.");
                }
            }
            form1Principal.AtualizaDataGridView();
        }

        private bool IsExcelFileOpen(string filePath)
        {
            try
            {
                var excelApp = new Excel.Application();
                foreach (Excel.Workbook wb in excelApp.Workbooks)
                {
                    if (wb.FullName.Equals(filePath, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Arquivo já está aberto
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false; // Erro ao tentar verificar, assume que o arquivo não está aberto
            }
        }

        private void ForceExcelToClose(string filePath)
        {
            var excelApp = new Excel.Application();
            foreach (Excel.Workbook wb in excelApp.Workbooks)
            {
                if (wb.FullName.Equals(filePath, StringComparison.OrdinalIgnoreCase))
                {
                    wb.Close(false); // Fecha o arquivo sem salvar
                    excelApp.Quit(); // Encerra o Excel
                    break;
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.png;*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagemSelecionada = File.ReadAllBytes(ofd.FileName);
                Image imagem = Image.FromFile(ofd.FileName);
                picImagem.Image = imagem;

                if (imagem.Width > imagem.Height)
                {
                    //MessageBox.Show("A imagem está em formato paisagem.");
                    formatImage = true;
                }
                else
                {
                    formatImage = false;
                    //MessageBox.Show("A imagem está em formato retrato.");
                }
            }
        }


        void dataForm()
        {
            var sistemas = new List<string>();
            if (checkBox_Android.Checked) sistemas.Add("ANDROID");
            if (checkBox_IOS.Checked) sistemas.Add("IOS");

            // Criar uma lista com os ambientes marcados
            var ambientes = new List<string>();
            if (checkBox_Production.Checked) ambientes.Add("PRODUCTION");
            if (checkBox_Sandbox.Checked) ambientes.Add("SANDBOX");
            if (checkBox_Test.Checked) ambientes.Add("TEST");

            // Unir os elementos com "/"
            cellWhere = string.Join("/", sistemas);
            cellEnvironment = string.Join("/", ambientes);

            if (radioButton_Blocker.Checked)
                cellPriority = radioButton_Blocker.Text;
            else if (radioButton_Critical.Checked)
                cellPriority = radioButton_Critical.Text;
            else if (radioButton_Major.Checked)
                cellPriority = radioButton_Major.Text;
            else if (radioButton_Minor.Checked)
                cellPriority = radioButton_Minor.Text;
            else if (radioButton_Trivial.Checked)
                cellPriority = radioButton_Trivial.Text;

            cellFoundErro = textBox_FoundErro.Text;
            cellCorrectTerm = textBox_CorrectTerm.Text;
            cellUser = textBox_User.Text;
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            text_FileName.Text = nomefile;
        }
    }
}
