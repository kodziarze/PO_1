namespace PROJEKT_PO_1
{
    partial class Form4
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
            this.button_user_menu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_user_wybor_ilosci = new System.Windows.Forms.ComboBox();
            this.textBox_user_wpisz_kod = new System.Windows.Forms.TextBox();
            this.textBox_user_wpisz_nazwe = new System.Windows.Forms.TextBox();
            this.textBox_user_ilosc_produktu = new System.Windows.Forms.TextBox();
            this.button_user_zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_user_menu
            // 
            this.button_user_menu.BackColor = System.Drawing.Color.Yellow;
            this.button_user_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_user_menu.Location = new System.Drawing.Point(145, 323);
            this.button_user_menu.Name = "button_user_menu";
            this.button_user_menu.Size = new System.Drawing.Size(139, 67);
            this.button_user_menu.TabIndex = 12;
            this.button_user_menu.Text = "MENU";
            this.button_user_menu.UseVisualStyleBackColor = false;
            this.button_user_menu.Click += new System.EventHandler(this.button_user_menu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(103, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wpisz nazwę produktu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wpisz kod kreskowy produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(103, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wpisz ilość produktu";
            // 
            // comboBox_user_wybor_ilosci
            // 
            this.comboBox_user_wybor_ilosci.FormattingEnabled = true;
            this.comboBox_user_wybor_ilosci.Items.AddRange(new object[] {
            "militrów",
            "gram"});
            this.comboBox_user_wybor_ilosci.Location = new System.Drawing.Point(714, 224);
            this.comboBox_user_wybor_ilosci.Name = "comboBox_user_wybor_ilosci";
            this.comboBox_user_wybor_ilosci.Size = new System.Drawing.Size(174, 21);
            this.comboBox_user_wybor_ilosci.TabIndex = 16;
            // 
            // textBox_user_wpisz_kod
            // 
            this.textBox_user_wpisz_kod.Location = new System.Drawing.Point(499, 91);
            this.textBox_user_wpisz_kod.Name = "textBox_user_wpisz_kod";
            this.textBox_user_wpisz_kod.Size = new System.Drawing.Size(182, 20);
            this.textBox_user_wpisz_kod.TabIndex = 17;
            // 
            // textBox_user_wpisz_nazwe
            // 
            this.textBox_user_wpisz_nazwe.Location = new System.Drawing.Point(499, 161);
            this.textBox_user_wpisz_nazwe.Name = "textBox_user_wpisz_nazwe";
            this.textBox_user_wpisz_nazwe.Size = new System.Drawing.Size(182, 20);
            this.textBox_user_wpisz_nazwe.TabIndex = 18;
            // 
            // textBox_user_ilosc_produktu
            // 
            this.textBox_user_ilosc_produktu.Location = new System.Drawing.Point(499, 225);
            this.textBox_user_ilosc_produktu.Name = "textBox_user_ilosc_produktu";
            this.textBox_user_ilosc_produktu.Size = new System.Drawing.Size(182, 20);
            this.textBox_user_ilosc_produktu.TabIndex = 19;
            // 
            // button_user_zatwierdz
            // 
            this.button_user_zatwierdz.BackColor = System.Drawing.Color.Chartreuse;
            this.button_user_zatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_user_zatwierdz.Location = new System.Drawing.Point(542, 323);
            this.button_user_zatwierdz.Name = "button_user_zatwierdz";
            this.button_user_zatwierdz.Size = new System.Drawing.Size(252, 67);
            this.button_user_zatwierdz.TabIndex = 20;
            this.button_user_zatwierdz.Text = "Zatwierdź produkt";
            this.button_user_zatwierdz.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.button_user_zatwierdz);
            this.Controls.Add(this.textBox_user_ilosc_produktu);
            this.Controls.Add(this.textBox_user_wpisz_nazwe);
            this.Controls.Add(this.textBox_user_wpisz_kod);
            this.Controls.Add(this.comboBox_user_wybor_ilosci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_user_menu);
            this.Name = "Form4";
            this.Text = "CUKROMETR 2000 AMG SLS V12 LPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_user_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_user_wybor_ilosci;
        private System.Windows.Forms.TextBox textBox_user_wpisz_kod;
        private System.Windows.Forms.TextBox textBox_user_wpisz_nazwe;
        private System.Windows.Forms.TextBox textBox_user_ilosc_produktu;
        private System.Windows.Forms.Button button_user_zatwierdz;
    }
}