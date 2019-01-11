namespace PROJEKT_PO_1
{
    partial class BazaDanych
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_menu_admin_wprowadzanie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(85, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wprowadź i wyświetl dane";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtFilePath.Location = new System.Drawing.Point(85, 135);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(672, 35);
            this.txtFilePath.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(82, 212);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(675, 300);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMenu.Location = new System.Drawing.Point(600, 529);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(160, 56);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Powrót";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(83, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ściezka dostępu bazy produktów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(80, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wczytana baza produktów :";
            // 
            // button_menu_admin_wprowadzanie
            // 
            this.button_menu_admin_wprowadzanie.BackColor = System.Drawing.Color.Yellow;
            this.button_menu_admin_wprowadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_menu_admin_wprowadzanie.Location = new System.Drawing.Point(85, 529);
            this.button_menu_admin_wprowadzanie.Name = "button_menu_admin_wprowadzanie";
            this.button_menu_admin_wprowadzanie.Size = new System.Drawing.Size(138, 56);
            this.button_menu_admin_wprowadzanie.TabIndex = 12;
            this.button_menu_admin_wprowadzanie.Text = "MENU";
            this.button_menu_admin_wprowadzanie.UseVisualStyleBackColor = false;
            this.button_menu_admin_wprowadzanie.Click += new System.EventHandler(this.button_menu_admin_wprowadzanie_Click);
            // 
            // BazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(825, 610);
            this.Controls.Add(this.button_menu_admin_wprowadzanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button1);
            this.Name = "BazaDanych";
            this.Text = "Baza Danych";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_menu_admin_wprowadzanie;
    }
}