using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace SimplyConect
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<PastaInfo> pastas = new List<PastaInfo>();

            pastas.Add(new PastaInfo
            {
                Caminho = textBox1.Text
            });

            string json = JsonConvert.SerializeObject(pastas, Formatting.Indented);
            File.WriteAllText("pastas.json", json);

            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            if (!File.Exists("pastas.json"))
                return;

            string json = File.ReadAllText("pastas.json");
            var pastas = JsonConvert.DeserializeObject<List<PastaInfo>>(json);

            if (pastas != null && pastas.Count > 0 && textBox1 != null)
            {
                textBox1.Text = pastas[0].Caminho;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta desejada";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoSelecionado = folderDialog.SelectedPath;
                    textBox1.Text = caminhoSelecionado; // Exibe no TextBox, por exemplo
                }
            }
        }
    }
    public class PastaInfo
    {
        public string Caminho { get; set; }
    }
}
