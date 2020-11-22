namespace WindowsFormsApp1
{
    partial class SaveCocktailPopUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCocktailSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Save new cocktail";
            // 
            // buttonCocktailSave
            // 
            this.buttonCocktailSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCocktailSave.ForeColor = System.Drawing.Color.Black;
            this.buttonCocktailSave.Location = new System.Drawing.Point(66, 244);
            this.buttonCocktailSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCocktailSave.Name = "buttonCocktailSave";
            this.buttonCocktailSave.Size = new System.Drawing.Size(148, 56);
            this.buttonCocktailSave.TabIndex = 19;
            this.buttonCocktailSave.Text = "Save";
            this.buttonCocktailSave.UseVisualStyleBackColor = true;
            this.buttonCocktailSave.Click += new System.EventHandler(this.buttonCocktailSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(257, 254);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 46);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrivate.ForeColor = System.Drawing.Color.Black;
            this.radioButtonPrivate.Location = new System.Drawing.Point(77, 133);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(119, 36);
            this.radioButtonPrivate.TabIndex = 21;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGeneral.ForeColor = System.Drawing.Color.Black;
            this.radioButtonGeneral.Location = new System.Drawing.Point(77, 173);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(135, 36);
            this.radioButtonGeneral.TabIndex = 22;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            // 
            // SaveCocktailPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(359, 315);
            this.Controls.Add(this.radioButtonGeneral);
            this.Controls.Add(this.radioButtonPrivate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCocktailSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaveCocktailPopUp";
            this.Load += new System.EventHandler(this.SaveCocktailPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCocktailSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
    }
}