namespace PROJEKT_PO_1
{
    partial class wprowadzanie_produktu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_admin_wybor_ilosci = new System.Windows.Forms.ComboBox();
            this.textBox_admin_wpisz_kod = new System.Windows.Forms.TextBox();
            this.textBox_admin_wpisz_nazwe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_menu_admin_wprowadzanie = new System.Windows.Forms.Button();
            this.button_admin_zatwierdz_wprowadzenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(85, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wpisz kod kreskowy produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(85, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wpisz nazwę produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(85, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wpisz zawartość glukozy na 100                                        produktu";
            // 
            // comboBox_admin_wybor_ilosci
            // 
            this.comboBox_admin_wybor_ilosci.FormattingEnabled = true;
            this.comboBox_admin_wybor_ilosci.Items.AddRange(new object[] {
            "militrów",
            "gram"});
            this.comboBox_admin_wybor_ilosci.Location = new System.Drawing.Point(464, 224);
            this.comboBox_admin_wybor_ilosci.Name = "comboBox_admin_wybor_ilosci";
            this.comboBox_admin_wybor_ilosci.Size = new System.Drawing.Size(174, 21);
            this.comboBox_admin_wybor_ilosci.TabIndex = 6;
            this.comboBox_admin_wybor_ilosci.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBox_admin_wpisz_kod
            // 
            this.textBox_admin_wpisz_kod.Location = new System.Drawing.Point(464, 108);
            this.textBox_admin_wpisz_kod.Name = "textBox_admin_wpisz_kod";
            this.textBox_admin_wpisz_kod.Size = new System.Drawing.Size(174, 20);
            this.textBox_admin_wpisz_kod.TabIndex = 7;
            // 
            // textBox_admin_wpisz_nazwe
            // 
            this.textBox_admin_wpisz_nazwe.Location = new System.Drawing.Point(464, 168);
            this.textBox_admin_wpisz_nazwe.Name = "textBox_admin_wpisz_nazwe";
            this.textBox_admin_wpisz_nazwe.Size = new System.Drawing.Size(174, 20);
            this.textBox_admin_wpisz_nazwe.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(211, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "SZANOWNY ADMINISTRATORZE";
            // 
            // button_menu_admin_wprowadzanie
            // 
            this.button_menu_admin_wprowadzanie.BackColor = System.Drawing.Color.Yellow;
            this.button_menu_admin_wprowadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_menu_admin_wprowadzanie.Location = new System.Drawing.Point(184, 302);
            this.button_menu_admin_wprowadzanie.Name = "button_menu_admin_wprowadzanie";
            this.button_menu_admin_wprowadzanie.Size = new System.Drawing.Size(139, 67);
            this.button_menu_admin_wprowadzanie.TabIndex = 11;
            this.button_menu_admin_wprowadzanie.Text = "MENU";
            this.button_menu_admin_wprowadzanie.UseVisualStyleBackColor = false;
            this.button_menu_admin_wprowadzanie.Click += new System.EventHandler(this.button_menu_admin_wprowadzanie_Click);
            // 
            // button_admin_zatwierdz_wprowadzenie
            // 
            this.button_admin_zatwierdz_wprowadzenie.BackColor = System.Drawing.Color.Yellow;
            this.button_admin_zatwierdz_wprowadzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_admin_zatwierdz_wprowadzenie.Location = new System.Drawing.Point(437, 302);
            this.button_admin_zatwierdz_wprowadzenie.Name = "button_admin_zatwierdz_wprowadzenie";
            this.button_admin_zatwierdz_wprowadzenie.Size = new System.Drawing.Size(247, 67);
            this.button_admin_zatwierdz_wprowadzenie.TabIndex = 12;
            this.button_admin_zatwierdz_wprowadzenie.Text = "Zatwierdź produkt";
            this.button_admin_zatwierdz_wprowadzenie.UseVisualStyleBackColor = false;
            this.button_admin_zatwierdz_wprowadzenie.Click += new System.EventHandler(this.button_admin_zatwierdz_wprowadzenie_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(921, 436);
            this.Controls.Add(this.button_admin_zatwierdz_wprowadzenie);
            this.Controls.Add(this.button_menu_admin_wprowadzanie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_admin_wpisz_nazwe);
            this.Controls.Add(this.textBox_admin_wpisz_kod);
            this.Controls.Add(this.comboBox_admin_wybor_ilosci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Wprowadzanie produktu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_admin_wybor_ilosci;
        private System.Windows.Forms.TextBox textBox_admin_wpisz_kod;
        private System.Windows.Forms.TextBox textBox_admin_wpisz_nazwe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_menu_admin_wprowadzanie;
        private System.Windows.Forms.Button button_admin_zatwierdz_wprowadzenie;
    }
}