using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SaveCocktailPopUp : Form  //Save created cocktails
    {
        public static List<string> CocktailAndComponents = new List<string>();
        public SaveCocktailPopUp(List<string> cocktails)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(850, 170);
            this.Size = new Size(200, 200);
            this.radioButtonGeneral.Checked = true;
            CocktailAndComponents = new List<string>(cocktails);
        }
        private void SaveCocktailPopUp_Load(object sender, EventArgs e) { }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            string a=""; Form1 form1 = new Form1(a);form1.Show();this.Close();
        }
        private void buttonCocktailSave_Click(object sender, EventArgs e)
        {
            string message = "";string name = CocktailAndComponents[0];CocktailAndComponents.RemoveAt(0);
            if (radioButtonPrivate.Checked)
            {
                if (Form1.ComponentsPriv.Count() == 0) { Form1.ComponentsPriv = Functions.LoadDB1("CocktailsPrivate"); }
                if (!Form1.ComponentsPriv.ContainsKey(name))
                {
                    Form1.ComponentsPriv[name] = CocktailAndComponents;
                    Functions.SaveDic1(Form1.ComponentsPriv, "CocktailsPrivate");
                    message = "The new cocktail has been saved!";
                    Form1 form1 = new Form1(message);
                    form1.Show();
                    this.Close();
                }
                else if (Form1.ComponentsPriv.ContainsKey(name))
                {
                    if (CocktailAndComponents.All(Form1.ComponentsPriv[name].Contains) == true)
                    {
                        message="This cocktail already exists in the database!";
                        Form1 form1 = new Form1(message);
                        form1.Show();
                        this.Close();
                    }
                    else if (CocktailAndComponents.All(Form1.ComponentsPriv[name].Contains) == false)
                    {
                        message = "Name exists! Please choose new name or check components!";
                        Form1 form1 = new Form1(message);
                        form1.Show();
                        this.Close();
                    }
                }
            }
            else if (radioButtonGeneral.Checked)
            {
                if (Form1.ComponentsGen.Count() == 0) { Form1.ComponentsGen = Functions.LoadDB1("CocktailsGeneral"); }
                if (!Form1.ComponentsGen.ContainsKey(name))
                {
                    Form1.ComponentsGen[name] = CocktailAndComponents; Functions.SaveDic1(Form1.ComponentsGen, "CocktailsGeneral");
                     message = "The new cocktail has been saved!";
                    Form1 form1 = new Form1(message);
                    form1.Show();
                    this.Close();
                }
                else if (Form1.ComponentsGen.ContainsKey(name))
                {
                    if (CocktailAndComponents.All(Form1.ComponentsGen[name].Contains) == true)
                    {
                        message = "This cocktail already exists in the database!";
                        Form1 form1 = new Form1(message);
                        form1.Show();
                        this.Close();
                    }
                    else if (CocktailAndComponents.All(Form1.ComponentsGen[name].Contains) == false)
                    {
                        message = "Name exists! Please choose new name or check components!";
                        Form1 form1 = new Form1(message);
                        form1.Show();
                        this.Close();}}}
        }
    }
}
