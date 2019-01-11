namespace PROJEKT_PO_1
{
    partial class sprawdzanie_poziomu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_user_wybor_ilosci = new System.Windows.Forms.ComboBox();
            this.textBox_user_wpisz_kod = new System.Windows.Forms.TextBox();
            this.textBox_user_ilosc_produktu = new System.Windows.Forms.TextBox();
            this.button_user_zatwierdz = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnZweryfikuj = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // button_user_menu
            // 
            this.button_user_menu.BackColor = System.Drawing.Color.Yellow;
            this.button_user_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_user_menu.Location = new System.Drawing.Point(145, 235);
            this.button_user_menu.Name = "button_user_menu";
            this.button_user_menu.Size = new System.Drawing.Size(139, 67);
            this.button_user_menu.TabIndex = 12;
            this.button_user_menu.Text = "MENU";
            this.button_user_menu.UseVisualStyleBackColor = false;
            this.button_user_menu.Click += new System.EventHandler(this.button_user_menu_Click);
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
            this.label2.Location = new System.Drawing.Point(103, 128);
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
            this.comboBox_user_wybor_ilosci.Location = new System.Drawing.Point(714, 136);
            this.comboBox_user_wybor_ilosci.Name = "comboBox_user_wybor_ilosci";
            this.comboBox_user_wybor_ilosci.Size = new System.Drawing.Size(174, 21);
            this.comboBox_user_wybor_ilosci.TabIndex = 16;
            this.comboBox_user_wybor_ilosci.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_wybor_ilosci_SelectedIndexChanged);
            // 
            // textBox_user_wpisz_kod
            // 
            this.textBox_user_wpisz_kod.Location = new System.Drawing.Point(499, 91);
            this.textBox_user_wpisz_kod.Name = "textBox_user_wpisz_kod";
            this.textBox_user_wpisz_kod.Size = new System.Drawing.Size(182, 20);
            this.textBox_user_wpisz_kod.TabIndex = 17;
            this.textBox_user_wpisz_kod.TextChanged += new System.EventHandler(this.textBox_user_wpisz_kod_TextChanged);
            // 
            // textBox_user_ilosc_produktu
            // 
            this.textBox_user_ilosc_produktu.Location = new System.Drawing.Point(499, 137);
            this.textBox_user_ilosc_produktu.Name = "textBox_user_ilosc_produktu";
            this.textBox_user_ilosc_produktu.Size = new System.Drawing.Size(182, 20);
            this.textBox_user_ilosc_produktu.TabIndex = 19;
            this.textBox_user_ilosc_produktu.TextChanged += new System.EventHandler(this.textBox_user_ilosc_produktu_TextChanged);
            // 
            // button_user_zatwierdz
            // 
            this.button_user_zatwierdz.BackColor = System.Drawing.Color.Chartreuse;
            this.button_user_zatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_user_zatwierdz.Location = new System.Drawing.Point(542, 235);
            this.button_user_zatwierdz.Name = "button_user_zatwierdz";
            this.button_user_zatwierdz.Size = new System.Drawing.Size(252, 67);
            this.button_user_zatwierdz.TabIndex = 20;
            this.button_user_zatwierdz.Text = "Zatwierdź produkt";
            this.button_user_zatwierdz.UseVisualStyleBackColor = false;
            this.button_user_zatwierdz.Click += new System.EventHandler(this.button_user_zatwierdz_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(164, 330);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtFilePath.TabIndex = 21;
            this.txtFilePath.Visible = false;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnZweryfikuj
            // 
            this.btnZweryfikuj.Location = new System.Drawing.Point(738, 88);
            this.btnZweryfikuj.Name = "btnZweryfikuj";
            this.btnZweryfikuj.Size = new System.Drawing.Size(75, 23);
            this.btnZweryfikuj.TabIndex = 22;
            this.btnZweryfikuj.Text = "Pokaż baze";
            this.btnZweryfikuj.UseVisualStyleBackColor = true;
            this.btnZweryfikuj.Visible = false;
            this.btnZweryfikuj.Click += new System.EventHandler(this.btnZweryfikuj_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(909, 49);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(335, 300);
            this.dgvEmployees.TabIndex = 23;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // sprawdzanie_poziomu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1379, 481);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnZweryfikuj);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button_user_zatwierdz);
            this.Controls.Add(this.textBox_user_ilosc_produktu);
            this.Controls.Add(this.textBox_user_wpisz_kod);
            this.Controls.Add(this.comboBox_user_wybor_ilosci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_user_menu);
            this.Name = "sprawdzanie_poziomu";
            this.Text = "CUKROMETR 2000 AMG SLS V12 LPG";
            this.Load += new System.EventHandler(this.sprawdzanie_poziomu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_user_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_user_wybor_ilosci;
        private System.Windows.Forms.TextBox textBox_user_wpisz_kod;
        private System.Windows.Forms.TextBox textBox_user_ilosc_produktu;
        private System.Windows.Forms.Button button_user_zatwierdz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnZweryfikuj;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}