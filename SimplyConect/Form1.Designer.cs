namespace SimplyConect
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAba = new System.Windows.Forms.ComboBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnLer = new System.Windows.Forms.Button();
            this.imgExcel = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_ContainerTop = new System.Windows.Forms.Panel();
            this.panel_ContainerComandos = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbArquivo = new System.Windows.Forms.ComboBox();
            this.panel_ContainerImg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Traduzir_NoteRossi = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Traduzir_NoteFaac = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Traduzir_CorrectTerm = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Traduzir_FoundError = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExcel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Panel_ContainerTop.SuspendLayout();
            this.panel_ContainerComandos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_ContainerImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAba
            // 
            this.cmbAba.FormattingEnabled = true;
            this.cmbAba.Location = new System.Drawing.Point(108, 63);
            this.cmbAba.Name = "cmbAba";
            this.cmbAba.Size = new System.Drawing.Size(240, 21);
            this.cmbAba.TabIndex = 0;
            // 
            // dgvRegistros
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRegistros.Location = new System.Drawing.Point(3, 16);
            this.dgvRegistros.Name = "dgvRegistros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistros.Size = new System.Drawing.Size(980, 252);
            this.dgvRegistros.TabIndex = 1;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(109, 104);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(239, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler planilha";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // imgExcel
            // 
            this.imgExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgExcel.Location = new System.Drawing.Point(20, 33);
            this.imgExcel.Margin = new System.Windows.Forms.Padding(20);
            this.imgExcel.Name = "imgExcel";
            this.imgExcel.Size = new System.Drawing.Size(358, 465);
            this.imgExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgExcel.TabIndex = 14;
            this.imgExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.imgExcel, "Clique para visualizar a imagem");
            this.imgExcel.Click += new System.EventHandler(this.picImagem_Click);
            this.imgExcel.MouseEnter += new System.EventHandler(this.picImagem_MouseEnter);
            this.imgExcel.MouseLeave += new System.EventHandler(this.picImagem_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(552, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar Error/Improvement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // Panel_ContainerTop
            // 
            this.Panel_ContainerTop.Controls.Add(this.panel_ContainerComandos);
            this.Panel_ContainerTop.Controls.Add(this.panel_ContainerImg);
            this.Panel_ContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_ContainerTop.Location = new System.Drawing.Point(0, 24);
            this.Panel_ContainerTop.Name = "Panel_ContainerTop";
            this.Panel_ContainerTop.Size = new System.Drawing.Size(1384, 154);
            this.Panel_ContainerTop.TabIndex = 20;
            // 
            // panel_ContainerComandos
            // 
            this.panel_ContainerComandos.Controls.Add(this.groupBox4);
            this.panel_ContainerComandos.Controls.Add(this.groupBox1);
            this.panel_ContainerComandos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainerComandos.Location = new System.Drawing.Point(0, 0);
            this.panel_ContainerComandos.Name = "panel_ContainerComandos";
            this.panel_ContainerComandos.Size = new System.Drawing.Size(1144, 154);
            this.panel_ContainerComandos.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(398, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(746, 154);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAba);
            this.groupBox1.Controls.Add(this.btnLer);
            this.groupBox1.Controls.Add(this.cmbArquivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbArquivo
            // 
            this.cmbArquivo.FormattingEnabled = true;
            this.cmbArquivo.Location = new System.Drawing.Point(108, 36);
            this.cmbArquivo.Name = "cmbArquivo";
            this.cmbArquivo.Size = new System.Drawing.Size(240, 21);
            this.cmbArquivo.TabIndex = 16;
            // 
            // panel_ContainerImg
            // 
            this.panel_ContainerImg.Controls.Add(this.pictureBox1);
            this.panel_ContainerImg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ContainerImg.Location = new System.Drawing.Point(1144, 0);
            this.panel_ContainerImg.Name = "panel_ContainerImg";
            this.panel_ContainerImg.Padding = new System.Windows.Forms.Padding(20);
            this.panel_ContainerImg.Size = new System.Drawing.Size(240, 154);
            this.panel_ContainerImg.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SimplyConect.Properties.Resources.Simply_Connect_ICON_NERO;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 518);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(398, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 518);
            this.panel3.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.dgvRegistros);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 518);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.btn_Traduzir_NoteRossi);
            this.panel6.Controls.Add(this.richTextBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(533, 268);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(230, 247);
            this.panel6.TabIndex = 7;
            // 
            // btn_Traduzir_NoteRossi
            // 
            this.btn_Traduzir_NoteRossi.Location = new System.Drawing.Point(185, 10);
            this.btn_Traduzir_NoteRossi.Name = "btn_Traduzir_NoteRossi";
            this.btn_Traduzir_NoteRossi.Size = new System.Drawing.Size(35, 20);
            this.btn_Traduzir_NoteRossi.TabIndex = 9;
            this.btn_Traduzir_NoteRossi.Text = "汉A";
            this.toolTip1.SetToolTip(this.btn_Traduzir_NoteRossi, "Traduzir");
            this.btn_Traduzir_NoteRossi.UseVisualStyleBackColor = true;
            this.btn_Traduzir_NoteRossi.Click += new System.EventHandler(this.btn_Traduzir_NoteRossi_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(10, 10);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(210, 227);
            this.richTextBox4.TabIndex = 1;
            this.richTextBox4.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btn_Traduzir_NoteFaac);
            this.panel5.Controls.Add(this.richTextBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(303, 268);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(230, 247);
            this.panel5.TabIndex = 6;
            // 
            // btn_Traduzir_NoteFaac
            // 
            this.btn_Traduzir_NoteFaac.Location = new System.Drawing.Point(185, 10);
            this.btn_Traduzir_NoteFaac.Name = "btn_Traduzir_NoteFaac";
            this.btn_Traduzir_NoteFaac.Size = new System.Drawing.Size(35, 20);
            this.btn_Traduzir_NoteFaac.TabIndex = 8;
            this.btn_Traduzir_NoteFaac.Text = "汉A";
            this.toolTip1.SetToolTip(this.btn_Traduzir_NoteFaac, "Traduzir");
            this.btn_Traduzir_NoteFaac.UseVisualStyleBackColor = true;
            this.btn_Traduzir_NoteFaac.Click += new System.EventHandler(this.btn_Traduzir_NoteFaac_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(10, 10);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(210, 227);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(794, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "WORK IN PROGRESSS",
            "TO BE TESTED",
            "OK",
            "WAITNG RELEASE",
            "NS",
            "NO ACTION"});
            this.comboBox2.Location = new System.Drawing.Point(794, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btn_Traduzir_CorrectTerm);
            this.panel4.Controls.Add(this.richTextBox2);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.btn_Traduzir_FoundError);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 268);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(300, 247);
            this.panel4.TabIndex = 3;
            // 
            // btn_Traduzir_CorrectTerm
            // 
            this.btn_Traduzir_CorrectTerm.Location = new System.Drawing.Point(255, 137);
            this.btn_Traduzir_CorrectTerm.Name = "btn_Traduzir_CorrectTerm";
            this.btn_Traduzir_CorrectTerm.Size = new System.Drawing.Size(35, 20);
            this.btn_Traduzir_CorrectTerm.TabIndex = 7;
            this.btn_Traduzir_CorrectTerm.Text = "汉A";
            this.toolTip1.SetToolTip(this.btn_Traduzir_CorrectTerm, "Traduzir");
            this.btn_Traduzir_CorrectTerm.UseVisualStyleBackColor = true;
            this.btn_Traduzir_CorrectTerm.Click += new System.EventHandler(this.btn_Traduzir_CorrectTerm_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(10, 137);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(280, 100);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 5);
            this.panel7.TabIndex = 5;
            // 
            // btn_Traduzir_FoundError
            // 
            this.btn_Traduzir_FoundError.Location = new System.Drawing.Point(255, 10);
            this.btn_Traduzir_FoundError.Name = "btn_Traduzir_FoundError";
            this.btn_Traduzir_FoundError.Size = new System.Drawing.Size(35, 20);
            this.btn_Traduzir_FoundError.TabIndex = 4;
            this.btn_Traduzir_FoundError.Text = "汉A";
            this.toolTip1.SetToolTip(this.btn_Traduzir_FoundError, "Traduzir");
            this.btn_Traduzir_FoundError.UseVisualStyleBackColor = true;
            this.btn_Traduzir_FoundError.Click += new System.EventHandler(this.btn_Traduzir_FoundError_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(10, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 122);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 518);
            this.panel2.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgExcel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox3.Size = new System.Drawing.Size(398, 518);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_ContainerTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExcel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel_ContainerTop.ResumeLayout(false);
            this.panel_ContainerComandos.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel_ContainerImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAba;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.PictureBox imgExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_ContainerTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ContainerComandos;
        private System.Windows.Forms.Panel panel_ContainerImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbArquivo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btn_Traduzir_FoundError;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Traduzir_NoteRossi;
        private System.Windows.Forms.Button btn_Traduzir_NoteFaac;
        private System.Windows.Forms.Button btn_Traduzir_CorrectTerm;
    }
}

