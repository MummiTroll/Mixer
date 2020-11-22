namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Mix = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.UpdateDB = new System.Windows.Forms.Button();
            this.buttonBox1Cl = new System.Windows.Forms.Button();
            this.buttonBox2Cl = new System.Windows.Forms.Button();
            this.buttonBox3Cl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonBox4Cl = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBox6Cl = new System.Windows.Forms.Button();
            this.buttonBox5Cl = new System.Windows.Forms.Button();
            this.labelMatch = new System.Windows.Forms.Label();
            this.labelMismatch = new System.Windows.Forms.Label();
            this.labelNeutral = new System.Windows.Forms.Label();
            this.labelPickAdvice = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonSaveCocktail = new System.Windows.Forms.Button();
            this.labelNoData = new System.Windows.Forms.Label();
            this.buttonLoadCocktail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonBox7Cl = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.buttonBox8Cl = new System.Windows.Forms.Button();
            this.richTextBoxCocktailName = new System.Windows.Forms.RichTextBox();
            this.buttonDeleteCocktail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mendeleev\'s cocktail lounge";
            // 
            // Mix
            // 
            this.Mix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Mix.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mix.ForeColor = System.Drawing.Color.Black;
            this.Mix.Location = new System.Drawing.Point(91, 530);
            this.Mix.Margin = new System.Windows.Forms.Padding(4);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(148, 56);
            this.Mix.TabIndex = 14;
            this.Mix.Text = "Mix";
            this.Mix.UseVisualStyleBackColor = false;
            this.Mix.Click += new System.EventHandler(this.Mix_Click);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Black;
            this.Quit.Location = new System.Drawing.Point(856, 990);
            this.Quit.Margin = new System.Windows.Forms.Padding(4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(84, 46);
            this.Quit.TabIndex = 29;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Clear.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(91, 598);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(148, 56);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // UpdateDB
            // 
            this.UpdateDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpdateDB.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDB.ForeColor = System.Drawing.Color.Black;
            this.UpdateDB.Location = new System.Drawing.Point(91, 666);
            this.UpdateDB.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(148, 56);
            this.UpdateDB.TabIndex = 30;
            this.UpdateDB.Text = "Update DB";
            this.UpdateDB.UseVisualStyleBackColor = false;
            this.UpdateDB.Click += new System.EventHandler(this.UpdateDB_Click_1);
            // 
            // buttonBox1Cl
            // 
            this.buttonBox1Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox1Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox1Cl.Location = new System.Drawing.Point(285, 183);
            this.buttonBox1Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox1Cl.Name = "buttonBox1Cl";
            this.buttonBox1Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox1Cl.TabIndex = 16;
            this.buttonBox1Cl.UseVisualStyleBackColor = false;
            this.buttonBox1Cl.Click += new System.EventHandler(this.buttonBox1Cl_Click_1);
            // 
            // buttonBox2Cl
            // 
            this.buttonBox2Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox2Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox2Cl.Location = new System.Drawing.Point(285, 223);
            this.buttonBox2Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox2Cl.Name = "buttonBox2Cl";
            this.buttonBox2Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox2Cl.TabIndex = 17;
            this.buttonBox2Cl.UseVisualStyleBackColor = false;
            this.buttonBox2Cl.Click += new System.EventHandler(this.buttonBox2Cl_Click_1);
            // 
            // buttonBox3Cl
            // 
            this.buttonBox3Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox3Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox3Cl.Location = new System.Drawing.Point(285, 264);
            this.buttonBox3Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox3Cl.Name = "buttonBox3Cl";
            this.buttonBox3Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox3Cl.TabIndex = 18;
            this.buttonBox3Cl.UseVisualStyleBackColor = false;
            this.buttonBox3Cl.Click += new System.EventHandler(this.buttonBox3Cl_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "Components";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(357, 202);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 764);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // buttonBox4Cl
            // 
            this.buttonBox4Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox4Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox4Cl.Location = new System.Drawing.Point(285, 304);
            this.buttonBox4Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox4Cl.Name = "buttonBox4Cl";
            this.buttonBox4Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox4Cl.TabIndex = 19;
            this.buttonBox4Cl.UseVisualStyleBackColor = false;
            this.buttonBox4Cl.Click += new System.EventHandler(this.buttonBox4Cl_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Old English Text MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(357, 138);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(583, 56);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // buttonBox6Cl
            // 
            this.buttonBox6Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox6Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox6Cl.Location = new System.Drawing.Point(285, 385);
            this.buttonBox6Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox6Cl.Name = "buttonBox6Cl";
            this.buttonBox6Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox6Cl.TabIndex = 21;
            this.buttonBox6Cl.UseVisualStyleBackColor = false;
            this.buttonBox6Cl.Click += new System.EventHandler(this.buttonBox6Cl_Click);
            // 
            // buttonBox5Cl
            // 
            this.buttonBox5Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox5Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox5Cl.Location = new System.Drawing.Point(285, 345);
            this.buttonBox5Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox5Cl.Name = "buttonBox5Cl";
            this.buttonBox5Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox5Cl.TabIndex = 20;
            this.buttonBox5Cl.UseVisualStyleBackColor = false;
            this.buttonBox5Cl.Click += new System.EventHandler(this.buttonBox5Cl_Click);
            // 
            // labelMatch
            // 
            this.labelMatch.BackColor = System.Drawing.Color.Lime;
            this.labelMatch.Location = new System.Drawing.Point(376, 976);
            this.labelMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatch.Name = "labelMatch";
            this.labelMatch.Size = new System.Drawing.Size(28, 29);
            this.labelMatch.TabIndex = 36;
            this.labelMatch.Text = "+";
            this.labelMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMismatch
            // 
            this.labelMismatch.BackColor = System.Drawing.Color.Red;
            this.labelMismatch.Location = new System.Drawing.Point(440, 976);
            this.labelMismatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMismatch.Name = "labelMismatch";
            this.labelMismatch.Size = new System.Drawing.Size(28, 29);
            this.labelMismatch.TabIndex = 25;
            this.labelMismatch.Text = "-";
            this.labelMismatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNeutral
            // 
            this.labelNeutral.BackColor = System.Drawing.Color.DarkOrange;
            this.labelNeutral.Location = new System.Drawing.Point(408, 976);
            this.labelNeutral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeutral.Name = "labelNeutral";
            this.labelNeutral.Size = new System.Drawing.Size(28, 29);
            this.labelNeutral.TabIndex = 24;
            this.labelNeutral.Text = "±";
            this.labelNeutral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPickAdvice
            // 
            this.labelPickAdvice.BackColor = System.Drawing.Color.Silver;
            this.labelPickAdvice.Location = new System.Drawing.Point(559, 970);
            this.labelPickAdvice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickAdvice.Name = "labelPickAdvice";
            this.labelPickAdvice.Size = new System.Drawing.Size(222, 63);
            this.labelPickAdvice.TabIndex = 28;
            this.labelPickAdvice.Text = "Type or pick a drink and click \"Mix\"";
            this.labelPickAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPickAdvice.UseCompatibleTextRendering = true;
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Silver;
            this.labelStart.Location = new System.Drawing.Point(584, 976);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(150, 29);
            this.labelStart.TabIndex = 27;
            this.labelStart.Text = "Click \"Mix\"";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.UseCompatibleTextRendering = true;
            // 
            // buttonSaveCocktail
            // 
            this.buttonSaveCocktail.BackColor = System.Drawing.Color.Orchid;
            this.buttonSaveCocktail.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCocktail.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveCocktail.Location = new System.Drawing.Point(20, 874);
            this.buttonSaveCocktail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveCocktail.Name = "buttonSaveCocktail";
            this.buttonSaveCocktail.Size = new System.Drawing.Size(148, 56);
            this.buttonSaveCocktail.TabIndex = 33;
            this.buttonSaveCocktail.Text = "Save";
            this.buttonSaveCocktail.UseVisualStyleBackColor = false;
            this.buttonSaveCocktail.Click += new System.EventHandler(this.buttonSaveCocktail_Click);
            // 
            // labelNoData
            // 
            this.labelNoData.BackColor = System.Drawing.Color.Lavender;
            this.labelNoData.Location = new System.Drawing.Point(472, 976);
            this.labelNoData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoData.Name = "labelNoData";
            this.labelNoData.Size = new System.Drawing.Size(28, 29);
            this.labelNoData.TabIndex = 26;
            this.labelNoData.Text = "?";
            this.labelNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadCocktail
            // 
            this.buttonLoadCocktail.BackColor = System.Drawing.Color.Orchid;
            this.buttonLoadCocktail.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadCocktail.ForeColor = System.Drawing.Color.Black;
            this.buttonLoadCocktail.Location = new System.Drawing.Point(178, 874);
            this.buttonLoadCocktail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadCocktail.Name = "buttonLoadCocktail";
            this.buttonLoadCocktail.Size = new System.Drawing.Size(148, 56);
            this.buttonLoadCocktail.TabIndex = 31;
            this.buttonLoadCocktail.Text = "Load";
            this.buttonLoadCocktail.UseVisualStyleBackColor = false;
            this.buttonLoadCocktail.Click += new System.EventHandler(this.buttonLoadCocktail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 183);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 223);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 264);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 31);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(49, 304);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 31);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(49, 345);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 31);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(49, 385);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(224, 31);
            this.textBox6.TabIndex = 5;
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrivate.Location = new System.Drawing.Point(196, 939);
            this.radioButtonPrivate.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(97, 26);
            this.radioButtonPrivate.TabIndex = 34;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.AutoSize = true;
            this.radioButtonGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGeneral.Location = new System.Drawing.Point(196, 972);
            this.radioButtonGeneral.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(105, 26);
            this.radioButtonGeneral.TabIndex = 35;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(49, 425);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(224, 31);
            this.textBox7.TabIndex = 6;
            // 
            // buttonBox7Cl
            // 
            this.buttonBox7Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox7Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox7Cl.Location = new System.Drawing.Point(285, 425);
            this.buttonBox7Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox7Cl.Name = "buttonBox7Cl";
            this.buttonBox7Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox7Cl.TabIndex = 22;
            this.buttonBox7Cl.UseVisualStyleBackColor = false;
            this.buttonBox7Cl.Click += new System.EventHandler(this.buttonBox7Cl_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(49, 465);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(224, 31);
            this.textBox8.TabIndex = 7;
            // 
            // buttonBox8Cl
            // 
            this.buttonBox8Cl.BackColor = System.Drawing.Color.Crimson;
            this.buttonBox8Cl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBox8Cl.Location = new System.Drawing.Point(285, 465);
            this.buttonBox8Cl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox8Cl.Name = "buttonBox8Cl";
            this.buttonBox8Cl.Size = new System.Drawing.Size(32, 31);
            this.buttonBox8Cl.TabIndex = 23;
            this.buttonBox8Cl.UseVisualStyleBackColor = false;
            this.buttonBox8Cl.Click += new System.EventHandler(this.buttonBox8Cl_Click);
            // 
            // richTextBoxCocktailName
            // 
            this.richTextBoxCocktailName.Location = new System.Drawing.Point(20, 829);
            this.richTextBoxCocktailName.Name = "richTextBoxCocktailName";
            this.richTextBoxCocktailName.Size = new System.Drawing.Size(306, 31);
            this.richTextBoxCocktailName.TabIndex = 9;
            this.richTextBoxCocktailName.Text = "";
            // 
            // buttonDeleteCocktail
            // 
            this.buttonDeleteCocktail.BackColor = System.Drawing.Color.Orchid;
            this.buttonDeleteCocktail.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCocktail.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteCocktail.Location = new System.Drawing.Point(20, 942);
            this.buttonDeleteCocktail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteCocktail.Name = "buttonDeleteCocktail";
            this.buttonDeleteCocktail.Size = new System.Drawing.Size(148, 56);
            this.buttonDeleteCocktail.TabIndex = 37;
            this.buttonDeleteCocktail.Text = "Delete";
            this.buttonDeleteCocktail.UseVisualStyleBackColor = false;
            this.buttonDeleteCocktail.Click += new System.EventHandler(this.buttonDeleteCocktail_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(82, 770);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 50);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cocktails";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 1064);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDeleteCocktail);
            this.Controls.Add(this.richTextBoxCocktailName);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.buttonBox8Cl);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buttonBox7Cl);
            this.Controls.Add(this.radioButtonGeneral);
            this.Controls.Add(this.radioButtonPrivate);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLoadCocktail);
            this.Controls.Add(this.labelNoData);
            this.Controls.Add(this.buttonSaveCocktail);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelPickAdvice);
            this.Controls.Add(this.labelNeutral);
            this.Controls.Add(this.labelMismatch);
            this.Controls.Add(this.labelMatch);
            this.Controls.Add(this.buttonBox6Cl);
            this.Controls.Add(this.buttonBox5Cl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBox4Cl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBox3Cl);
            this.Controls.Add(this.buttonBox2Cl);
            this.Controls.Add(this.buttonBox1Cl);
            this.Controls.Add(this.UpdateDB);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Mix);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ПК©";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mix;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button UpdateDB;
        private System.Windows.Forms.Button buttonBox1Cl;
        private System.Windows.Forms.Button buttonBox2Cl;
        private System.Windows.Forms.Button buttonBox3Cl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonBox4Cl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBox6Cl;
        private System.Windows.Forms.Button buttonBox5Cl;
        private System.Windows.Forms.Label labelMatch;
        private System.Windows.Forms.Label labelMismatch;
        private System.Windows.Forms.Label labelNeutral;
        private System.Windows.Forms.Label labelPickAdvice;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonSaveCocktail;
        private System.Windows.Forms.Label labelNoData;
        private System.Windows.Forms.Button buttonLoadCocktail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonBox7Cl;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button buttonBox8Cl;
        private System.Windows.Forms.RichTextBox richTextBoxCocktailName;
        private System.Windows.Forms.Button buttonDeleteCocktail;
        private System.Windows.Forms.Label label4;
    }
}

