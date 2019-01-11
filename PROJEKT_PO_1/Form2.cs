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
    public partial class BazaDanych : Form
    {

       
        public BazaDanych()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            //string plik = "C:\\Users\\DELL\\Desktop\\xd2.csv";
            BindDataCSV(txtFilePath.Text);
            zmienne.AdresPliku = txtFilePath.Text;
        }

        public void BindDataCSV(string filePath)
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
                    zmienne.dataWords = lines[r].Split(';');
                    DataRow dr = dt.NewRow();
                    int columIndex = 0;
                    foreach (string headerWord in headerLabels) // XD jak zapisać pojedyncze tablice
                    {

                        dr[headerWord] = zmienne.dataWords[columIndex++];
                        //string[] tabela = zmienne.dataWords;
                        //new int []  = new int ;
                    }
                    //label1.Text = zmienne.dataWords[3];
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnMenu_Click(object sender, EventArgs e)
        {
            new wprowadzanie_produktu().Show();
            this.Visible = false;
        }

        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zmienne.dataWords[1]);
        }

        private void button_menu_admin_wprowadzanie_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Visible = false;
        }
    }
}
