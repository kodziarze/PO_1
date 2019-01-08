using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_PO_1
{
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }

        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header

                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(';');

                foreach(string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                // for data 

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(';');
                    DataRow dr = dt.NewRow();
                    int columIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {

                        dr[headerWord] = dataWords[columIndex++];
                    }

                    dt.Rows.Add(dr);
                }

            }
            if (dt.Rows.Count > 0)
            {
                //object DataGrindViev.DataSource { get; set; }
                dgvEmployees.DataSource = dt;
                //MessageBox.Show(lines[1]);
               // int kod_kresk = Convert.ToInt32(lines[1]);
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_menu_admin_wprowadzanie_Click(object sender, EventArgs e)
        {
            
                new menu().Show();
                this.Visible = false;
            
        }

        private void zapis_Click(object sender, EventArgs e)
        {
            
        }
    }
}