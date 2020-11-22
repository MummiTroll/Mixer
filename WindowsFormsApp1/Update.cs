using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Update : Form  //Update databases
    {
        public Update(string component)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(550, 100);
            this.Size = new Size(440, 648);
            this.textBoxDrinkAlc.Text = component;
            labelPleaseClassify.Visible = false;
            textBoxPleaseClassify.Visible = false;
        }
        private void UpdateDB_Click(object sender, EventArgs e)
        {
            string DrinkName = string.Empty; int caseSwitch = -1;
            List<string> dummy = new List<string>(); dummy.Clear();
            if (File.Exists(@"DataBank\Compatibility.bin") && File.Exists(@"DataBank\MixComponents.bin"))
            {
                Form1.Compatibility = Functions.LoadDB(); Form1.MixComponents = Functions.LoadDrinks();
                if (!String.IsNullOrEmpty(textBoxDrinkAlc.Text)) { dummy.Add(textBoxDrinkAlc.Text); caseSwitch = 0; }
                else if (!String.IsNullOrEmpty(textBoxDrinkNonAlc.Text)) { dummy.Add(textBoxDrinkNonAlc.Text); caseSwitch = 1; }
                else if (!String.IsNullOrEmpty(textBoxDrinkNonDrink.Text)) { dummy.Add(textBoxDrinkNonDrink.Text); caseSwitch = 2; }
                if (dummy.Count() > 1) { labelPleaseClassify.Visible = true; labelPleaseClassify.Text = "Please, choose only one drink!"; }
                else if (dummy.Count() == 0) { labelPleaseClassify.Visible = true; labelPleaseClassify.Text = "Please, choose a drink!"; }
                else if (dummy.Count() == 1 && Functions.Splitting(textBoxDrinkAlc.Text, ',').Count() <= 1 && Functions.Splitting(textBoxDrinkNonAlc.Text, ',').Count() <= 1 && Functions.Splitting(textBoxDrinkNonDrink.Text, ',').Count() <= 1)
                {
                    DrinkName = dummy[0];
                    switch (caseSwitch)
                    {
                        case 0:
                            if (!Form1.MixComponents[caseSwitch].Contains(DrinkName)) { Form1.MixComponents[caseSwitch].Add(DrinkName.Substring(0, 1).ToUpper() + DrinkName.Substring(1)); UpdateDBases(DrinkName); GoToForm1(""); }
                            break;
                        case 1:
                            if (!Form1.MixComponents[caseSwitch].Contains(DrinkName)) { Form1.MixComponents[caseSwitch].Add(DrinkName.Substring(0, 1).ToUpper() + DrinkName.Substring(1)); UpdateDBases(DrinkName); GoToForm1(""); }
                            break;
                        case 2:
                            if (!Form1.MixComponents[caseSwitch].Contains(DrinkName)) { Form1.MixComponents[caseSwitch].Add(DrinkName.Substring(0, 1).ToUpper() + DrinkName.Substring(1)); UpdateDBases(DrinkName); GoToForm1(""); }
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (dummy.Count() == 1 && (Functions.Splitting(textBoxDrinkAlc.Text, ',').Count() > 1 || Functions.Splitting(textBoxDrinkNonAlc.Text, ',').Count() > 1 || Functions.Splitting(textBoxDrinkNonDrink.Text, ',').Count() > 1))
            { labelPleaseClassify.Visible = true; labelPleaseClassify.Text = "Please, choose only one drink!"; }

            else if ((!File.Exists(@"DataBank\Compatibility.bin") && !File.Exists(@"DataBank\MixComponents.bin"))
            || (!File.Exists(@"DataBank\Compatibility.bin") && File.Exists(@"DataBank\MixComponents.bin"))
            || (File.Exists(@"DataBank\Compatibility.bin") && !File.Exists(@"DataBank\MixComponents.bin")))
            {
                string message = "Please, import database files!"; GoToForm1(message);
            }
        }
        private void GoToForm1(string message) { Form1 form1 = new Form1(message); form1.Show(); this.Close(); }
        private void UpdateDBases(string DrinkName)
        {
            List<string> interPosAlc = new List<string>(); interPosAlc.Clear();
            List<string> interPosNonAlc = new List<string>(); interPosNonAlc.Clear();
            List<string> interPosNonDrink = new List<string>(); interPosNonDrink.Clear();
            List<string> interNeuAlc = new List<string>(); interNeuAlc.Clear();
            List<string> interNeuNonAlc = new List<string>(); interNeuNonAlc.Clear();
            List<string> interNeuNonDrink = new List<string>(); interNeuNonDrink.Clear();
            List<string> interMismatchAlc = new List<string>(); interMismatchAlc.Clear();
            List<string> interMismatchNonAlc = new List<string>(); interMismatchNonAlc.Clear();
            List<string> interMismatchNonDrink = new List<string>(); interMismatchNonDrink.Clear();
            List<List<string>> interPos = new List<List<string>>(); interPos.Clear();
            List<List<string>> interNeu = new List<List<string>>(); interNeu.Clear();
            List<List<string>> interNeg = new List<List<string>>(); interNeg.Clear();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>(); dic.Clear();
            dic = new Dictionary<string, List<string>>(Form1.Compatibility);
            interPosAlc = FillList(textBoxMatchAlc.Text); interPosNonAlc = FillList(textBoxMatchNonAlc.Text); interPosNonDrink = FillList(textBoxMatchNonDrink.Text);
            interNeuAlc = FillList(textBoxNeuAlc.Text); interNeuNonAlc = FillList(textBoxNeuNonAlc.Text); interNeuNonDrink = FillList(textBoxNeuNonDrink.Text);
            interMismatchAlc = FillList(textBoxMismatchAlc.Text); interMismatchNonAlc = FillList(textBoxMismatchNonAlc.Text); interMismatchNonDrink = FillList(textBoxMismatchNonDrink.Text);
            interPos.Add(interPosAlc); interPos.Add(interPosNonAlc); interPos.Add(interPosNonDrink);
            interNeu.Add(interNeuAlc); interNeu.Add(interNeuNonAlc); interNeu.Add(interNeuNonDrink);
            interNeg.Add(interMismatchAlc); interNeg.Add(interMismatchNonAlc); interNeg.Add(interMismatchNonDrink);
            for (int i = 0; i < interPos.Count(); i++)
            {
                for (int j = 0; j < interPos[i].Count(); j++)
                {
                    if (interPos[i][j] != "" && !Form1.MixComponents[i].Contains(interPos[i][j]))
                    {
                        Form1.MixComponents[i].Add(interPos[i][j]);
                    }
                    if (Form1.Compatibility.ContainsKey(DrinkName + "Pos"))
                    {
                        if (!Form1.Compatibility[DrinkName + "Pos"].Contains(interPos[i][j]))
                        {
                            dic[DrinkName + "Pos"].Add(interPos[i][j]);
                        }
                    }
                    else if (!Form1.Compatibility.ContainsKey(DrinkName + "Pos"))
                    {
                        List<string> pos = new List<string>(); pos.Clear();
                        if (interPos[i][j] != "") { pos.Add(interPos[i][j]); dic[DrinkName + "Pos"] = new List<string>(pos); }
                        else if (interPos[i][j] == "") { pos.Add(""); dic[DrinkName + "Pos"] = new List<string>(pos); }
                    }
                }
            }
            for (int i = 0; i < interNeu.Count(); i++)
            {
                for (int j = 0; j < interNeu[i].Count(); j++)
                {
                    if (interNeu[i][j] != "" && !Form1.MixComponents[i].Contains(interNeu[i][j]))
                    {
                        Form1.MixComponents[i].Add(interNeu[i][j]);
                    }
                    if (Form1.Compatibility.ContainsKey(DrinkName + "Neu"))
                    {
                        if (!Form1.Compatibility[DrinkName + "Neu"].Contains(interNeu[i][j]))
                        {
                            dic[DrinkName + "Neu"].Add(interNeu[i][j]);
                        }
                    }
                    else if (!Form1.Compatibility.ContainsKey(DrinkName + "Neu"))
                    {
                        List<string> neu = new List<string>(); neu.Clear();
                        if (interNeu[i][j] != "") { neu.Add(interNeu[i][j]); dic[DrinkName + "Neu"] = new List<string>(neu); }
                        else if (interNeu[i][j] == "") { neu.Add(""); dic[DrinkName + "Neu"] = new List<string>(neu); }
                    }

                }
            }
            for (int i = 0; i < interNeg.Count(); i++)
            {
                for (int j = 0; j < interNeg[i].Count(); j++)
                {
                    if (interNeg[i][j] != "" && !Form1.MixComponents[i].Contains(interNeg[i][j]))
                    {
                        Form1.MixComponents[i].Add(interNeg[i][j]);
                    }
                    if (Form1.Compatibility.ContainsKey(DrinkName + "Neg"))
                    {
                        if (!Form1.Compatibility[DrinkName + "Neg"].Contains(interNeg[i][j]))
                        {
                            dic[DrinkName + "Neg"].Add(interNeg[i][j]);
                        }
                    }
                    else if (!Form1.Compatibility.ContainsKey(DrinkName + "Neg"))
                    {
                        List<string> neg = new List<string>(); neg.Clear();
                        if (interNeg[i][j] != "") { neg.Add(interNeg[i][j]); dic[DrinkName + "Neg"] = new List<string>(neg); }
                        else if (interNeg[i][j] == "") { neg.Add(""); dic[DrinkName + "Neg"] = new List<string>(neg); }
                    }
                }
            }
            Functions.SaveList(Form1.MixComponents); Functions.SaveDic(dic); Form1.Compatibility.Clear();
        }
        private List<string> FillList(string name)
        {
            List<string> list = new List<string>(); list.Count();

            list = Functions.NameToUpper(Functions.Splitting(textBoxMatchAlc.Text, ','));
            if (list.Count() == 0) { list.Add(""); }
            return list;
        }
        private void ClearDrinkTextBoxes()
        {
            textBoxDrinkAlc.Text = string.Empty;
            textBoxDrinkNonAlc.Text = string.Empty;
            textBoxDrinkNonDrink.Text = string.Empty;
        }
        private void buttonBack_Click(object sender, EventArgs e) { string a = ""; Form1 form1 = new Form1(a); form1.Show(); this.Close(); Form1.MixComponents.Clear(); }
        private void Quit_Click(object sender, EventArgs e) { { Application.Exit(); } }
        private void buttonDrinksAlcCl_Click(object sender, EventArgs e) { textBoxDrinkAlc.Text = string.Empty; labelPleaseClassify.Visible = false; }
        private void buttonDrinksNonAlcCl_Click(object sender, EventArgs e) { textBoxDrinkNonAlc.Text = string.Empty; labelPleaseClassify.Visible = false; }
        private void buttonDrinksNonDrinkCl_Click(object sender, EventArgs e) { textBoxDrinkNonDrink.Text = string.Empty; labelPleaseClassify.Visible = false; }
        private void buttonMatchAlcCl_Click(object sender, EventArgs e) { textBoxMatchAlc.Text = string.Empty; }
        private void buttonMatchNonAlcCl_Click(object sender, EventArgs e) { textBoxMatchNonAlc.Text = string.Empty; }
        private void buttonMatchNonDrinkCl_Click(object sender, EventArgs e) { textBoxMatchNonDrink.Text = string.Empty; }
        private void buttonNeuAlcCl_Click(object sender, EventArgs e) { textBoxNeuAlc.Text = string.Empty; }
        private void buttonNeuNonAlcCl_Click(object sender, EventArgs e) { textBoxNeuNonAlc.Text = string.Empty; }
        private void buttonNeuNonDrinkCl_Click(object sender, EventArgs e) { textBoxNeuNonDrink.Text = string.Empty; }
        private void buttonMismatchAlcCl_Click(object sender, EventArgs e) { textBoxMismatchAlc.Text = string.Empty; }
        private void buttonMismatchNeuCl_Click(object sender, EventArgs e) { textBoxMismatchNonAlc.Text = string.Empty; }
        private void buttonMismatchNonDrinkCl_Click(object sender, EventArgs e) { textBoxMismatchNonDrink.Text = string.Empty; }
        private void buttonRemoveDrink_Click(object sender, EventArgs e) { DelDrink(); }
        private void DelDrink()
        {
            List<string> interDrinks = new List<string>(); interDrinks.Clear(); Form1.MixComponents.Clear();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>(); dic.Clear();
            Form1.MixComponents = Functions.LoadDrinks(); Form1.Compatibility = Functions.LoadDB();
            interDrinks = new List<string>(Functions.NameToUpper(Functions.Splitting(textBoxDrinkAlc.Text, ',')));
            dic = new Dictionary<string, List<string>>(Form1.Compatibility);
            foreach (string element in interDrinks)
            {
                foreach (List<string> element1 in Form1.MixComponents)
                {
                    if (element1.Contains(element)) { element1.Remove(element); }
                    else if (element1.Contains(element.ToLower())) { element1.Remove(element.ToLower()); }
                }
                foreach (string key in Form1.Compatibility.Keys)
                {
                    if (key == element + "Pos") { dic.Remove(key); dic.Remove(element + "Neu"); dic.Remove(element + "Neg"); }
                    if (key == element.ToLower() + "Pos") { dic.Remove(key); dic.Remove(element.ToLower() + "Neu"); dic.Remove(element.ToLower() + "Neg"); }
                }
            }
            Functions.SaveList(Form1.MixComponents); Form1.MixComponents.Clear();
            Functions.SaveDic1(dic, "Compatibility"); dic.Clear(); Form1.Compatibility.Clear();
            string a = ""; Form1 form1 = new Form1(a); form1.Show(); this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            labelPleaseClassify.Visible = false; textBoxPleaseClassify.Visible = false;
            textBoxDrinkAlc.Text = string.Empty; textBoxMatchAlc.Text = string.Empty; textBoxMatchNonAlc.Text = string.Empty;
            textBoxMatchNonDrink.Text = string.Empty; textBoxNeuAlc.Text = string.Empty; textBoxNeuNonAlc.Text = string.Empty;
            textBoxNeuNonDrink.Text = string.Empty; textBoxMismatchAlc.Text = string.Empty; textBoxMismatchNonAlc.Text = string.Empty;
            textBoxMismatchNonDrink.Text = string.Empty;
        }
    }
}
