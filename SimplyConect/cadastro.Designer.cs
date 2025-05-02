namespace SimplyConect
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_FoundErro = new System.Windows.Forms.TextBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.checkBox_Android = new System.Windows.Forms.CheckBox();
            this.checkBox_IOS = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Test = new System.Windows.Forms.CheckBox();
            this.checkBox_Sandbox = new System.Windows.Forms.CheckBox();
            this.checkBox_Production = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Trivial = new System.Windows.Forms.RadioButton();
            this.radioButton_Minor = new System.Windows.Forms.RadioButton();
            this.radioButton_Major = new System.Windows.Forms.RadioButton();
            this.radioButton_Critical = new System.Windows.Forms.RadioButton();
            this.radioButton_Blocker = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CorrectTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FoundErro
            // 
            this.textBox_FoundErro.Location = new System.Drawing.Point(12, 228);
            this.textBox_FoundErro.Multiline = true;
            this.textBox_FoundErro.Name = "textBox_FoundErro";
            this.textBox_FoundErro.Size = new System.Drawing.Size(406, 98);
            this.textBox_FoundErro.TabIndex = 0;
            this.textBox_FoundErro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(6, 19);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(409, 395);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // checkBox_Android
            // 
            this.checkBox_Android.AutoSize = true;
            this.checkBox_Android.Location = new System.Drawing.Point(6, 19);
            this.checkBox_Android.Name = "checkBox_Android";
            this.checkBox_Android.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Android.TabIndex = 3;
            this.checkBox_Android.Text = "ANDROID";
            this.checkBox_Android.UseVisualStyleBackColor = true;
            // 
            // checkBox_IOS
            // 
            this.checkBox_IOS.AutoSize = true;
            this.checkBox_IOS.Location = new System.Drawing.Point(118, 19);
            this.checkBox_IOS.Name = "checkBox_IOS";
            this.checkBox_IOS.Size = new System.Drawing.Size(44, 17);
            this.checkBox_IOS.TabIndex = 4;
            this.checkBox_IOS.Text = "IOS";
            this.checkBox_IOS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_IOS);
            this.groupBox1.Controls.Add(this.checkBox_Android);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WHERE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Test);
            this.groupBox2.Controls.Add(this.checkBox_Sandbox);
            this.groupBox2.Controls.Add(this.checkBox_Production);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENVIRONMENT";
            // 
            // checkBox_Test
            // 
            this.checkBox_Test.AutoSize = true;
            this.checkBox_Test.Location = new System.Drawing.Point(225, 19);
            this.checkBox_Test.Name = "checkBox_Test";
            this.checkBox_Test.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Test.TabIndex = 7;
            this.checkBox_Test.Text = "TEST";
            this.checkBox_Test.UseVisualStyleBackColor = true;
            // 
            // checkBox_Sandbox
            // 
            this.checkBox_Sandbox.AutoSize = true;
            this.checkBox_Sandbox.Location = new System.Drawing.Point(118, 19);
            this.checkBox_Sandbox.Name = "checkBox_Sandbox";
            this.checkBox_Sandbox.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Sandbox.TabIndex = 6;
            this.checkBox_Sandbox.Text = "SANDBOX";
            this.checkBox_Sandbox.UseVisualStyleBackColor = true;
            // 
            // checkBox_Production
            // 
            this.checkBox_Production.AutoSize = true;
            this.checkBox_Production.Location = new System.Drawing.Point(6, 19);
            this.checkBox_Production.Name = "checkBox_Production";
            this.checkBox_Production.Size = new System.Drawing.Size(98, 17);
            this.checkBox_Production.TabIndex = 5;
            this.checkBox_Production.Text = "PRODUCTION";
            this.checkBox_Production.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_Trivial);
            this.groupBox3.Controls.Add(this.radioButton_Minor);
            this.groupBox3.Controls.Add(this.radioButton_Major);
            this.groupBox3.Controls.Add(this.radioButton_Critical);
            this.groupBox3.Controls.Add(this.radioButton_Blocker);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 52);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRIORITY";
            // 
            // radioButton_Trivial
            // 
            this.radioButton_Trivial.AutoSize = true;
            this.radioButton_Trivial.Location = new System.Drawing.Point(353, 19);
            this.radioButton_Trivial.Name = "radioButton_Trivial";
            this.radioButton_Trivial.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Trivial.TabIndex = 14;
            this.radioButton_Trivial.TabStop = true;
            this.radioButton_Trivial.Text = "Trivial";
            this.toolTip1.SetToolTip(this.radioButton_Trivial, "Cosmetic problem like misspelled words or misalingned text");
            this.radioButton_Trivial.UseVisualStyleBackColor = true;
            // 
            // radioButton_Minor
            // 
            this.radioButton_Minor.AutoSize = true;
            this.radioButton_Minor.Location = new System.Drawing.Point(270, 19);
            this.radioButton_Minor.Name = "radioButton_Minor";
            this.radioButton_Minor.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Minor.TabIndex = 13;
            this.radioButton_Minor.TabStop = true;
            this.radioButton_Minor.Text = "Minor";
            this.toolTip1.SetToolTip(this.radioButton_Minor, "Minor loss of function, or other problem where easy workaround is present");
            this.radioButton_Minor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Major
            // 
            this.radioButton_Major.AutoSize = true;
            this.radioButton_Major.Location = new System.Drawing.Point(187, 19);
            this.radioButton_Major.Name = "radioButton_Major";
            this.radioButton_Major.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Major.TabIndex = 12;
            this.radioButton_Major.TabStop = true;
            this.radioButton_Major.Text = "Major";
            this.toolTip1.SetToolTip(this.radioButton_Major, "Major loss of function");
            this.radioButton_Major.UseVisualStyleBackColor = true;
            // 
            // radioButton_Critical
            // 
            this.radioButton_Critical.AutoSize = true;
            this.radioButton_Critical.Location = new System.Drawing.Point(99, 19);
            this.radioButton_Critical.Name = "radioButton_Critical";
            this.radioButton_Critical.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Critical.TabIndex = 11;
            this.radioButton_Critical.TabStop = true;
            this.radioButton_Critical.Text = "Critical";
            this.toolTip1.SetToolTip(this.radioButton_Critical, "Crashes, loss of data, severe memory leak");
            this.radioButton_Critical.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blocker
            // 
            this.radioButton_Blocker.AutoSize = true;
            this.radioButton_Blocker.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Blocker.Name = "radioButton_Blocker";
            this.radioButton_Blocker.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Blocker.TabIndex = 10;
            this.radioButton_Blocker.TabStop = true;
            this.radioButton_Blocker.Tag = "";
            this.radioButton_Blocker.Text = "Blocker";
            this.toolTip1.SetToolTip(this.radioButton_Blocker, "Block development and/or testing work production could not run");
            this.radioButton_Blocker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Tag = "";
            this.label1.Text = "FOUND ERROR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CORRECT TERM";
            // 
            // textBox_CorrectTerm
            // 
            this.textBox_CorrectTerm.Location = new System.Drawing.Point(12, 354);
            this.textBox_CorrectTerm.Multiline = true;
            this.textBox_CorrectTerm.Name = "textBox_CorrectTerm";
            this.textBox_CorrectTerm.Size = new System.Drawing.Size(406, 98);
            this.textBox_CorrectTerm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "USER";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(53, 464);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(365, 20);
            this.textBox_User.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "add image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(365, 529);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(164, 23);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picImagem);
            this.groupBox4.Location = new System.Drawing.Point(448, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 420);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IMAGE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 567);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CorrectTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_FoundErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FoundErro;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.CheckBox checkBox_Android;
        private System.Windows.Forms.CheckBox checkBox_IOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_Test;
        private System.Windows.Forms.CheckBox checkBox_Sandbox;
        private System.Windows.Forms.CheckBox checkBox_Production;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CorrectTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.RadioButton radioButton_Blocker;
        private System.Windows.Forms.RadioButton radioButton_Trivial;
        private System.Windows.Forms.RadioButton radioButton_Minor;
        private System.Windows.Forms.RadioButton radioButton_Major;
        private System.Windows.Forms.RadioButton radioButton_Critical;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}