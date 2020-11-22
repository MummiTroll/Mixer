using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form  //Main window of the cocktail components - compatibility app
    {
        #region Lists
        public static List<List<string>> MixComponents = new List<List<string>>();
        public static RichTextBox richTextBoxUpdate = new RichTextBox();
        public static Dictionary<string, List<string>> ComponentsGen = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> ComponentsPriv = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> Compatibility = new Dictionary<string, List<string>>();
        public static List<string> header = new List<string> { "Alcoholic", "Alcohol Free", "Additions" };
        public static List<List<string>> lst = new List<List<string>>(); public static string message = "";
        #endregion
        public Form1(string mess)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 170);
            this.Size = new Size(507, 590);
            this.listView1.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            this.listView1.BackColor = Color.Lavender;
            this.richTextBox1.BackColor = Color.GhostWhite;
            this.textBox1.BackColor = Color.AliceBlue;
            this.textBox2.BackColor = Color.AliceBlue;
            this.textBox3.BackColor = Color.AliceBlue;
            this.textBox4.BackColor = Color.AliceBlue;
            this.textBox5.BackColor = Color.AliceBlue;
            this.textBox6.BackColor = Color.AliceBlue;
            this.textBox7.BackColor = Color.AliceBlue;
            this.textBox8.BackColor = Color.AliceBlue;
            this.labelMatch.Visible = false; this.labelNeutral.Visible = false;
            this.labelMismatch.Visible = false; this.labelNoData.Visible = false;
            this.labelPickAdvice.Visible = false;
            this.labelStart.Visible = true;
            this.richTextBox1.Font = new Font("Old English Text MT", 13, FontStyle.Regular);
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.radioButtonGeneral.Checked = true;
            message = mess;
            InitializeRichTextBox();
        }
        void InitializeRichTextBox()
        {
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text)
                && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text)
                && String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text))
                if (message.Length != 0) { richTextBox1.Text = message; }
                else if (message.Length == 0) { richTextBox1.Text = "Design a cocktail with or without alcohol!"; }
        }
        private void Mix_Click(object sender, EventArgs e)
        {
            string DrinkOrMix = string.Empty;
            richTextBox1.Clear(); listView1.Clear();
            List<string> namesDrinks = new List<string>(); namesDrinks.Clear();
            List<string> Request = new List<string>(); Request.Clear();
            List<string> MatchDrinks = new List<string>(); MatchDrinks.Clear();
            List<string> NeutralDrinks = new List<string>(); NeutralDrinks.Clear();
            List<string> MisMatchDrinks = new List<string>(); MisMatchDrinks.Clear();
            List<string> intermediate = new List<string>(); intermediate.Clear();
            List<string> DrinksNotFound = new List<string>(); DrinksNotFound.Clear();
            List<List<string>> resultsDrinks = new List<List<string>>(); resultsDrinks.Clear();
            List<List<string>> searchRes = new List<List<string>>(); searchRes.Clear();
            if (File.Exists(@"DataBank\MixComponents.bin")) { if (MixComponents.Count() == 0) { MixComponents = Functions.LoadDrinks(); } }
            else { richTextBox1.Text = "\n\n\n     The file does not exist, please, create the drink/cocktail database!"; }
            if (File.Exists(@"DataBank\Compatibility.bin")) { if (Compatibility.Count() == 0) { Compatibility = Functions.LoadDB(); } }
            else { richTextBox1.Text = "\n\n\n     The file does not exist, please, create the mixture - quality database!"; }
            if (!String.IsNullOrEmpty(textBox1.Text)) { Request.Add(textBox1.Text); }
            if (!String.IsNullOrEmpty(textBox2.Text)) { Request.Add(textBox2.Text); }
            if (!String.IsNullOrEmpty(textBox3.Text)) { Request.Add(textBox3.Text); }
            if (!String.IsNullOrEmpty(textBox4.Text)) { Request.Add(textBox4.Text); }
            if (!String.IsNullOrEmpty(textBox5.Text)) { Request.Add(textBox5.Text); }
            if (!String.IsNullOrEmpty(textBox6.Text)) { Request.Add(textBox6.Text); }
            if (!String.IsNullOrEmpty(textBox7.Text)) { Request.Add(textBox7.Text); }
            if (!String.IsNullOrEmpty(textBox8.Text)) { Request.Add(textBox8.Text); }
            Components(Request);
        }
        private void Components(List<string> Request)
        {
            List<string> header1 = new List<string>(); header1.Clear();
            List<List<string>> lst2D = new List<List<string>>(); lst2D.Clear();
            List<List<string>> lst2Da = new List<List<string>>(); lst2Da.Clear();
            labelMatch.Visible = false; labelNeutral.Visible = false; labelMismatch.Visible = false; labelNoData.Visible = false;
            labelPickAdvice.Visible = true; labelStart.Visible = false;
            List<string> dummy = new List<string>(); dummy.Clear(); List<string> dummy1 = new List<string>(); dummy1.Clear();
            if (Request.Count() == 0)
            {
                int n = 2; lst2D.Clear(); header1.Clear();
                for (int i = 0; i < n; i++) { header1.Add(header[i]); lst2D.Add(MixComponents[i]); }
                string[] intermediate = new string[n + 1]; Array.Clear(intermediate, 0, intermediate.Length);
                lst2Da = Functions.ListEqualizer(lst2D); listView1.Clear();
                string[] lstArr1 = lst2Da[1].ToArray(); string[] lstArr2 = lst2Da[2].ToArray(); string[] lstArr3 = new string[0];
                ShowInListView(n, header1, lst2Da, lstArr1, lstArr2, lstArr3);
            }
            else if (Request.Count() > 0)
            {
                labelMatch.Visible = true; labelNeutral.Visible = true; labelMismatch.Visible = true; labelNoData.Visible = true;
                labelPickAdvice.Visible = true; labelStart.Visible = false;

                int n = 3; List<List<string>> searchRes = new List<List<string>>(); searchRes.Clear();
                for (int i = 0; i < Request.Count(); i++) { Request[i] = Request[i].Substring(0, 1).ToUpper() + Request[i].Substring(1); }
                lst2D.Clear(); header1.Clear();
                searchRes = Functions.SearchDrinks(Request);
                if (searchRes[3].Count() != 0) { string s = ""; foreach (string drink in searchRes[3]) { s += drink; } richTextBox1.Text = "Drinks not in the database: " + s; }
                for (int i = 0; i < n; i++) { header1.Add(header[i]); lst2D.Add(MixComponents[i]); }
                string[] intermediate = new string[n + 1]; Array.Clear(intermediate, 0, intermediate.Length);
                lst2Da = Functions.ListEqualizer(lst2D); listView1.Clear();
                string[] lstArr1 = lst2Da[1].ToArray(); string[] lstArr2 = lst2Da[2].ToArray(); string[] lstArr3 = lst2Da[3].ToArray();
                ShowInListView(n, header1, lst2Da, lstArr1, lstArr2, lstArr3); ColorInListView(listView1, searchRes);
            }
        }
        private void ShowInListView(int n, List<string> header1, List<List<string>> lst2D, string[] lstArr1, string[] lstArr2, string[] lstArr3)
        {
            string[] intermediate = new string[n + 1]; Array.Clear(intermediate, 0, intermediate.Length);
            listView1.Columns.Add("", 0);
            for (int i = 0; i < header1.Count(); i++) { listView1.Columns.Add(header1[i], listView1.Width / header1.Count(), HorizontalAlignment.Left); }
            ListViewItem title = new ListViewItem(); listView1.Items.Add(title);
            foreach (string element in header1) { title.SubItems.Add(element); }
            foreach (ListViewItem.ListViewSubItem sub in title.SubItems)
            { title.UseItemStyleForSubItems = false; sub.Font = new Font("Times New Roman", 10, FontStyle.Bold); }
            for (int i = 0; i < Int32.Parse(lst2D[0][0]); i++)
            {
                intermediate[0] = ""; intermediate[1] = lstArr1[i]; intermediate[2] = lstArr2[i]; if (lstArr3.Count() > 0) { intermediate[3] = lstArr3[i]; }
                listView1.Items.Add(new ListViewItem(intermediate));
            }
        }
        private void ColorInListView(ListView listView1, List<List<string>> lst2D)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.UseItemStyleForSubItems = false;
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    foreach (string element in lst2D[0]) { if (item.SubItems[i].Text.ToString() == element) { item.SubItems[i].ForeColor = Color.Green; } }
                    foreach (string element in lst2D[1]) { if (item.SubItems[i].Text.ToString() == element) { item.SubItems[i].ForeColor = Color.DarkOrange; } }
                    foreach (string element in lst2D[2]) { if (item.SubItems[i].Text.ToString() == element) { item.SubItems[i].ForeColor = Color.Red; } }
                }
            }
        }
        private void buttonLoadCocktail_Click(object sender, EventArgs e)
        {
            ClearAll(); ComponentsPriv.Clear(); ComponentsGen.Clear();
            List<string> content1D = new List<string>(); content1D.Clear(); List<List<string>> content2D = new List<List<string>>(); content2D.Clear();
            List<string> header2 = new List<string>(); string[] intermediate = new string[3]; Array.Clear(intermediate, 0, intermediate.Length);
            labelMatch.Visible = false; labelNeutral.Visible = false; labelMismatch.Visible = false; labelNoData.Visible = false;
            labelPickAdvice.Visible = false; labelStart.Visible = false;

            if (String.IsNullOrEmpty(richTextBoxCocktailName.Text))
            {
                if (radioButtonPrivate.Checked)
                {
                    listView1.Clear();
                    header2.Add("Cocktail name (private)"); header2.Add("Components");
                    ComponentsPriv = Functions.LoadDB1("CocktailsPrivate");
                    ComponentsPriv = Functions.SortDic(ComponentsPriv);
                    listView1.Columns.Add("", 0);
                    for (int i = 0; i < header2.Count(); i++) { listView1.Columns.Add(header2[i], listView1.Width / header2.Count(), HorizontalAlignment.Left); }
                    ListViewItem title = new ListViewItem(); listView1.Items.Add(title);
                    foreach (string element in header2) { title.SubItems.Add(element); }
                    foreach (ListViewItem.ListViewSubItem sub in title.SubItems)
                    { title.UseItemStyleForSubItems = false; sub.Font = new Font("Times New Roman", 10, FontStyle.Bold); }
                    foreach (string key in ComponentsPriv.Keys)
                    {
                        content1D.Clear(); content2D.Clear(); content1D.Add(key);
                        content2D.Add(content1D); content2D.Add(ComponentsPriv[key]);
                        content2D = Functions.ListEqualizer(content2D);
                        string[] lstArr1 = content2D[1].ToArray(); string[] lstArr2 = content2D[2].ToArray();
                        for (int i = 0; i < Int32.Parse(content2D[0][0]); i++)
                        {
                            intermediate[0] = ""; intermediate[1] = lstArr1[i]; intermediate[2] = lstArr2[i];
                            listView1.Items.Add(new ListViewItem(intermediate));
                        }
                    }
                }
                else if (radioButtonGeneral.Checked)
                {
                    header2.Add("Cocktail name (general)"); header2.Add("Components");
                    ComponentsGen = Functions.LoadDB1("CocktailsGeneral");
                    ComponentsGen = Functions.SortDic(ComponentsGen);
                    listView1.Columns.Add("", 0);
                    for (int i = 0; i < header2.Count(); i++) { listView1.Columns.Add(header2[i], listView1.Width / header2.Count(), HorizontalAlignment.Left); }
                    ListViewItem title = new ListViewItem(); listView1.Items.Add(title);
                    foreach (string element in header2) { title.SubItems.Add(element); }
                    foreach (ListViewItem.ListViewSubItem sub in title.SubItems)
                    { title.UseItemStyleForSubItems = false; sub.Font = new Font("Times New Roman", 10, FontStyle.Bold); }
                    foreach (string key in ComponentsGen.Keys)
                    {
                        content1D.Clear(); content2D.Clear(); content1D.Add(key);
                        content2D.Add(content1D); content2D.Add(ComponentsGen[key]);
                        content2D = Functions.ListEqualizer(content2D);
                        string[] lstArr1 = content2D[1].ToArray(); string[] lstArr2 = content2D[2].ToArray();
                        for (int i = 0; i < Int32.Parse(content2D[0][0]); i++)
                        {
                            intermediate[0] = ""; intermediate[1] = lstArr1[i]; intermediate[2] = lstArr2[i];
                            listView1.Items.Add(new ListViewItem(intermediate));
                        }
                    }
                }
            }
            else if (richTextBoxCocktailName.Text != "") { SearchComponents(richTextBoxCocktailName.Text); }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Alcoholic" || textBox1.Text == "Alcohol Free"
                  || textBox1.Text == "Additions" || textBox1.Text == "Cocktails") { textBox1.Text = string.Empty; }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Alcoholic" || textBox2.Text == "Alcohol Free"
                  || textBox2.Text == "Additions" || textBox2.Text == "Cocktails") { textBox2.Text = string.Empty; }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Alcoholic" || textBox3.Text == "Alcohol Free"
                  || textBox3.Text == "Additions" || textBox3.Text == "Cocktails") { textBox3.Text = string.Empty; }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "Alcoholic" || textBox4.Text == "Alcohol Free"
                  || textBox4.Text == "Additions" || textBox4.Text == "Cocktails") { textBox4.Text = string.Empty; }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "Alcoholic" || textBox5.Text == "Alcohol Free"
                  || textBox5.Text == "Additions" || textBox5.Text == "Cocktails") { textBox5.Text = string.Empty; }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "Alcoholic" || textBox6.Text == "Alcohol Free"
                  || textBox6.Text == "Additions" || textBox6.Text == "Cocktails") { textBox6.Text = string.Empty; }
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void buttonBox1Cl_Click_1(object sender, EventArgs e) { textBox1.Text = string.Empty; }
        private void buttonBox2Cl_Click_1(object sender, EventArgs e) { textBox2.Text = string.Empty; }
        private void buttonBox3Cl_Click_1(object sender, EventArgs e) { textBox3.Text = string.Empty; }
        private void buttonBox4Cl_Click(object sender, EventArgs e) { textBox4.Text = string.Empty; }
        private void buttonBox5Cl_Click(object sender, EventArgs e) { textBox5.Text = string.Empty; }
        private void buttonBox6Cl_Click(object sender, EventArgs e) { textBox6.Text = string.Empty; }
        private void buttonBox7Cl_Click(object sender, EventArgs e) { textBox7.Text = string.Empty; }
        private void buttonBox8Cl_Click(object sender, EventArgs e) { textBox8.Text = string.Empty; }
        private void Quit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { if (richTextBox1.Text != "") { richTextBox1.Text = ""; } }
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem title = new ListViewItem();
            try
            {
                var info = listView1.HitTest(e.X, e.Y);
                var row = info.Item.Index;
                var col = info.Item.SubItems.IndexOf(info.SubItem);
                string value = info.Item.SubItems[col].Text;

                if (listView1.Columns[col].Text == "Components") { }
                else if (listView1.Columns[col].Text == "Cocktail name (general)" || listView1.Columns[col].Text == "Cocktail name (private)")
                {
                    richTextBoxCocktailName.Text = value; SearchComponents(value);
                }
                else if (listView1.Columns[col].Text == "Alcoholic" || listView1.Columns[col].Text == "Alcohol Free" || listView1.Columns[col].Text == "Additions")
                {
                    if (String.IsNullOrEmpty(textBox1.Text)) { textBox1.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text)) { textBox2.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text)) { textBox3.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text)) { textBox4.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text)) { textBox5.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text)) { textBox6.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox7.Text)) { textBox7.Text = value; }
                    else if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text)) { textBox8.Text = value; }
                }
            }
            catch (System.NullReferenceException eN) { }
            finally { }
        }
        private void SearchComponents(string name)
        {
            if (radioButtonGeneral.Checked == true)
            {
                if (ComponentsGen.Count() == 0) { ComponentsGen = Functions.LoadDB1("CocktailsGeneral"); }
                if (ComponentsGen.ContainsKey(name))
                {
                    foreach (TextBox element in this.Controls.OfType<TextBox>())
                    {
                        if (element.TabIndex <= ComponentsGen[name].Count() - 1) { element.Text = ComponentsGen[name][element.TabIndex]; }
                        else { element.Text = ""; }
                    }
                }
            }
            else if (radioButtonPrivate.Checked == true)
            {
                if (ComponentsPriv.Count() == 0) { Functions.LoadDB1("CocktailsComponentsPrivate"); }
                if (ComponentsPriv.ContainsKey(name))
                {
                    foreach (TextBox element in this.Controls.OfType<TextBox>())
                    {
                        if (element.TabIndex <= ComponentsPriv[name].Count() - 1) { element.Text = ComponentsPriv[name][element.TabIndex]; }
                        else { element.Text = ""; }
                    }
                }
                else if (!ComponentsPriv.ContainsKey(name))
                {
                    if (ComponentsGen.Count() == 0) { Functions.LoadDB1("CocktailsGeneral"); }
                    if (!ComponentsGen.ContainsKey(name))
                    {
                        richTextBox1.Text = "The cocktail is not in the database!";
                    }
                    else if (ComponentsGen.ContainsKey(name))
                    {
                        radioButtonGeneral.Checked = true;
                        foreach (TextBox element in this.Controls.OfType<TextBox>())
                        {
                            if (element.TabIndex <= ComponentsGen[name].Count() - 1) { element.Text = ComponentsGen[name][element.TabIndex]; }
                            else { element.Text = ""; }
                        }
                    }
                }
            }
        }
        private void UpdateDB_Click_1(object sender, EventArgs e)
        {
            string component = string.Empty;
            labelMatch.Visible = false; labelNeutral.Visible = false; labelMismatch.Visible = false; labelNoData.Visible = false;
            labelPickAdvice.Visible = false; labelStart.Visible = false;
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) 
                && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text) 
                && String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text)){richTextBox1.Text = "Please, pick drinks!";}
            else if (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text) || !String.IsNullOrEmpty(textBox3.Text) 
                || !String.IsNullOrEmpty(textBox4.Text) || !String.IsNullOrEmpty(textBox5.Text) || !String.IsNullOrEmpty(textBox6.Text) 
                || !String.IsNullOrEmpty(textBox7.Text) || !String.IsNullOrEmpty(textBox8.Text))
            {   int count=0;
                if (!String.IsNullOrEmpty(textBox1.Text)) { component=textBox1.Text.Substring(0, 1).ToUpper() + textBox1.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox2.Text)) { component = textBox2.Text.Substring(0, 1).ToUpper() + textBox2.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox3.Text)) { component = textBox3.Text.Substring(0, 1).ToUpper() + textBox3.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox4.Text)) { component = textBox4.Text.Substring(0, 1).ToUpper() + textBox4.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox5.Text)) { component = textBox5.Text.Substring(0, 1).ToUpper() + textBox5.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox6.Text)) { component = textBox6.Text.Substring(0, 1).ToUpper() + textBox6.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox7.Text)) { component = textBox7.Text.Substring(0, 1).ToUpper() + textBox7.Text.Substring(1); count += 1; }
                if (!String.IsNullOrEmpty(textBox8.Text)) { component = textBox8.Text.Substring(0, 1).ToUpper() + textBox8.Text.Substring(1); count += 1; }
                if (count>1){richTextBox1.Text = "Please, choose only one drink!";}
                else if (count == 1)
                {
                    Update update = new Update(component);
                    update.Show();
                    this.Hide();
                }
            }
        }
        private void Clear_Click_1(object sender, EventArgs e)
        {
            labelMatch.Visible = false; labelNeutral.Visible = false; labelMismatch.Visible = false; labelNoData.Visible = false;
            labelPickAdvice.Visible = false; labelStart.Visible = true; ClearAll();}
        private void ClearAll()
        {
            textBox1.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty; textBox4.Text = string.Empty;
            textBox5.Text = string.Empty; textBox6.Text = string.Empty; textBox7.Text = string.Empty; textBox8.Text = string.Empty;
            richTextBoxCocktailName.Clear(); listView1.Clear(); MixComponents.Clear(); Compatibility.Clear();
        }
        private void buttonSaveCocktail_Click(object sender, EventArgs e)
        {
            List<string> CocktailAndComponents = new List<string>(); CocktailAndComponents.Clear();
            if (richTextBoxCocktailName.Text == "" && String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text)
                && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text)
                && String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text))
            {
                richTextBox1.Text = "Please, pick or compose a cocktail!";
            }
            else if (richTextBoxCocktailName.Text != "" && String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text)
                && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text)
                 && String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text))
            { richTextBox1.Text = "Please, pick drinks!"; }
            else if (richTextBoxCocktailName.Text == "" && (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text)
                || !String.IsNullOrEmpty(textBox3.Text) || !String.IsNullOrEmpty(textBox4.Text) || !String.IsNullOrEmpty(textBox5.Text)
                 || !String.IsNullOrEmpty(textBox6.Text) || !String.IsNullOrEmpty(textBox7.Text) || !String.IsNullOrEmpty(textBox8.Text)))
            { richTextBox1.Text = "Please give the cocktail its name!"; }
            else if (richTextBoxCocktailName.Text != "" && (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text)
                || !String.IsNullOrEmpty(textBox3.Text) || !String.IsNullOrEmpty(textBox4.Text) || !String.IsNullOrEmpty(textBox5.Text)
                 || !String.IsNullOrEmpty(textBox6.Text) || !String.IsNullOrEmpty(textBox7.Text) || !String.IsNullOrEmpty(textBox8.Text)))
            {
                CocktailAndComponents.Add(richTextBoxCocktailName.Text);
                if (!String.IsNullOrEmpty(textBox1.Text)) { CocktailAndComponents.Add(textBox1.Text.Substring(0, 1).ToUpper() + textBox1.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox2.Text)) { CocktailAndComponents.Add(textBox2.Text.Substring(0, 1).ToUpper() + textBox2.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox3.Text)) { CocktailAndComponents.Add(textBox3.Text.Substring(0, 1).ToUpper() + textBox3.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox4.Text)) { CocktailAndComponents.Add(textBox4.Text.Substring(0, 1).ToUpper() + textBox4.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox5.Text)) { CocktailAndComponents.Add(textBox5.Text.Substring(0, 1).ToUpper() + textBox5.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox6.Text)) { CocktailAndComponents.Add(textBox6.Text.Substring(0, 1).ToUpper() + textBox6.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox7.Text)) { CocktailAndComponents.Add(textBox7.Text.Substring(0, 1).ToUpper() + textBox7.Text.Substring(1)); }
                if (!String.IsNullOrEmpty(textBox8.Text)) { CocktailAndComponents.Add(textBox8.Text.Substring(0, 1).ToUpper() + textBox8.Text.Substring(1)); }
                SaveCocktailPopUp saveCocktailPopUp = new SaveCocktailPopUp(CocktailAndComponents);
                saveCocktailPopUp.Show();
                this.Hide();
                richTextBox1.Text = message;
            }
        }
        private void buttonDeleteCocktail_Click_1(object sender, EventArgs e){DelCocktail();}
        private void DelCocktail()
        {
            List<string> interDrinks = new List<string>(); interDrinks.Clear();
            List<string> interDrinks1 = new List<string>(); interDrinks1.Clear();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>(); dic.Clear();

            if (radioButtonPrivate.Checked)
            {
                ComponentsPriv.Clear();
                ComponentsPriv = Functions.LoadDB1("CocktailsPrivate"); dic = new Dictionary<string, List<string>>(ComponentsPriv);
                interDrinks = new List<string>(Functions.Splitting(richTextBoxCocktailName.Text, ','));
                interDrinks1 = new List<string>(Functions.NameToUpper(Functions.Splitting(richTextBoxCocktailName.Text, ',')));
                foreach (string element in interDrinks){if (Form1.ComponentsPriv.Keys.Contains(element)) {dic.Remove(element);}}
                foreach (string element in interDrinks1) { if (Form1.ComponentsPriv.Keys.Contains(element)) { dic.Remove(element); } }
                Functions.SaveDic1(dic, "CocktailsPrivate"); dic.Clear(); interDrinks.Clear(); ComponentsPriv.Clear();
            }
            else if (radioButtonGeneral.Checked)
            {
                ComponentsGen.Clear();
                ComponentsGen = Functions.LoadDB1("CocktailsGeneral"); dic = new Dictionary<string, List<string>>(ComponentsGen);
                interDrinks = new List<string>(Functions.Splitting(richTextBoxCocktailName.Text, ','));
                interDrinks1 = new List<string>(Functions.NameToUpper(Functions.Splitting(richTextBoxCocktailName.Text, ',')));
                foreach (string element in interDrinks) { if (Form1.ComponentsGen.Keys.Contains(element)) { dic.Remove(element); } }
                foreach (string element in interDrinks1) { if (Form1.ComponentsGen.Keys.Contains(element)) { dic.Remove(element); } }
                Functions.SaveDic1(dic, "CocktailsGeneral"); dic.Clear(); interDrinks.Clear(); ComponentsPriv.Clear(); ComponentsGen.Clear();
            }
        }
    }
}