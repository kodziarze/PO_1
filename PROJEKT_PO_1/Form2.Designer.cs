namespace PROJEKT_PO_1
{
    partial class Form2
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
            this.button_menu_admin_wprowadzanie = new System.Windows.Forms.Button();
            this.zapis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wprowadź i wyświetl dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(187, 105);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(452, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(187, 135);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(867, 406);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_menu_admin_wprowadzanie
            // 
            this.button_menu_admin_wprowadzanie.BackColor = System.Drawing.Color.Yellow;
            this.button_menu_admin_wprowadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_menu_admin_wprowadzanie.Location = new System.Drawing.Point(13, 459);
            this.button_menu_admin_wprowadzanie.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_admin_wprowadzanie.Name = "button_menu_admin_wprowadzanie";
            this.button_menu_admin_wprowadzanie.Size = new System.Drawing.Size(166, 82);
            this.button_menu_admin_wprowadzanie.TabIndex = 12;
            this.button_menu_admin_wprowadzanie.Text = "MENU";
            this.button_menu_admin_wprowadzanie.UseVisualStyleBackColor = false;
            this.button_menu_admin_wprowadzanie.Click += new System.EventHandler(this.button_menu_admin_wprowadzanie_Click);
            // 
            // zapis
            // 
            this.zapis.Location = new System.Drawing.Point(878, 99);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(176, 29);
            this.zapis.TabIndex = 13;
            this.zapis.Text = "zapisz";
            this.zapis.UseVisualStyleBackColor = true;
            this.zapis.Click += new System.EventHandler(this.zapis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.zapis);
            this.Controls.Add(this.button_menu_admin_wprowadzanie);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button button_menu_admin_wprowadzanie;
        private System.Windows.Forms.Button zapis;
    }
}