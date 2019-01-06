namespace PROJEKT_PO_1
{
    partial class tabela
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.wczyatnie = new System.Windows.Forms.Button();
            this.kodproduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaproduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscglukozyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodproduktuDataGridViewTextBoxColumn,
            this.nazwaproduktuDataGridViewTextBoxColumn,
            this.iloscglukozyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jedzenieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wczyatnie
            // 
            this.wczyatnie.Location = new System.Drawing.Point(676, 465);
            this.wczyatnie.Name = "wczyatnie";
            this.wczyatnie.Size = new System.Drawing.Size(98, 23);
            this.wczyatnie.TabIndex = 2;
            this.wczyatnie.Text = "Wczytaj";
            this.wczyatnie.UseVisualStyleBackColor = true;
            this.wczyatnie.Click += new System.EventHandler(this.wczyatnie_Click);
            // 
            // kodproduktuDataGridViewTextBoxColumn
            // 
            this.kodproduktuDataGridViewTextBoxColumn.DataPropertyName = "kod_produktu";
            this.kodproduktuDataGridViewTextBoxColumn.HeaderText = "kod_produktu";
            this.kodproduktuDataGridViewTextBoxColumn.Name = "kodproduktuDataGridViewTextBoxColumn";
            // 
            // nazwaproduktuDataGridViewTextBoxColumn
            // 
            this.nazwaproduktuDataGridViewTextBoxColumn.DataPropertyName = "nazwa_produktu";
            this.nazwaproduktuDataGridViewTextBoxColumn.HeaderText = "nazwa_produktu";
            this.nazwaproduktuDataGridViewTextBoxColumn.Name = "nazwaproduktuDataGridViewTextBoxColumn";
            // 
            // iloscglukozyDataGridViewTextBoxColumn
            // 
            this.iloscglukozyDataGridViewTextBoxColumn.DataPropertyName = "ilosc_glukozy";
            this.iloscglukozyDataGridViewTextBoxColumn.HeaderText = "ilosc_glukozy";
            this.iloscglukozyDataGridViewTextBoxColumn.Name = "iloscglukozyDataGridViewTextBoxColumn";
            // 
            // jedzenieBindingSource
            // 
            this.jedzenieBindingSource.DataSource = typeof(PROJEKT_PO_1.jedzenie);
            // 
            // tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(883, 543);
            this.Controls.Add(this.wczyatnie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tabela";
            this.Text = "tabela";
            this.Load += new System.EventHandler(this.tabela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wczyatnie;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodproduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaproduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscglukozyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jedzenieBindingSource;
    }
}