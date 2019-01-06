namespace PROJEKT_PO_1
{
    partial class logowanie_administartora
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
            this.button_zaloguj_admin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_menu_logowanie_admina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(389, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "SZANOWNY ADMINISTRATORZE";
            // 
            // button_zaloguj_admin
            // 
            this.button_zaloguj_admin.BackColor = System.Drawing.Color.Fuchsia;
            this.button_zaloguj_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_zaloguj_admin.Location = new System.Drawing.Point(632, 318);
            this.button_zaloguj_admin.Name = "button_zaloguj_admin";
            this.button_zaloguj_admin.Size = new System.Drawing.Size(142, 67);
            this.button_zaloguj_admin.TabIndex = 15;
            this.button_zaloguj_admin.Text = "ZALOGUJ";
            this.button_zaloguj_admin.UseVisualStyleBackColor = false;
            this.button_zaloguj_admin.Click += new System.EventHandler(this.button_zaloguj_admin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(377, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wprowadź hasło :";
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(600, 213);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(174, 20);
            this.textBox_haslo.TabIndex = 13;
            this.textBox_haslo.UseSystemPasswordChar = true;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(600, 143);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(174, 20);
            this.textBox_login.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(378, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wprowadź Login :";
            // 
            // button_menu_logowanie_admina
            // 
            this.button_menu_logowanie_admina.BackColor = System.Drawing.Color.Yellow;
            this.button_menu_logowanie_admina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_menu_logowanie_admina.Location = new System.Drawing.Point(417, 318);
            this.button_menu_logowanie_admina.Name = "button_menu_logowanie_admina";
            this.button_menu_logowanie_admina.Size = new System.Drawing.Size(139, 67);
            this.button_menu_logowanie_admina.TabIndex = 10;
            this.button_menu_logowanie_admina.Text = "MENU";
            this.button_menu_logowanie_admina.UseVisualStyleBackColor = false;
            this.button_menu_logowanie_admina.Click += new System.EventHandler(this.button_menu_logowanie_admina_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_zaloguj_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_menu_logowanie_admina);
            this.Name = "Form3";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_zaloguj_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_menu_logowanie_admina;
    }
}