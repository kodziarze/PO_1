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
    public partial class sprawdzanie_poziomu : Form
    {
        public sprawdzanie_poziomu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_user_menu_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Visible = false;
        }

        private void btnBazaDanych_Click(object sender, EventArgs e)
        {
            new BazaDanych().Show();
            this.Visible = false;
        }

        private void button_user_zatwierdz_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(zmienne.AdresPliku);
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

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                // for data 

                //for (int r = 1; r < lines.Length; r++)
                //{
                int nr_lini = Convert.ToInt32(textBox_user_wpisz_kod.Text);
                    zmienne.dataWords = lines[nr_lini].Split(';');
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
                //}
                
                if (comboBox_user_wybor_ilosci.Text == "gram")
                {
                    double ilosc = (Convert.ToDouble(textBox_user_ilosc_produktu.Text)) / 100;
                    double ilosc_cukru = ilosc * Convert.ToDouble(zmienne.dataWords[2]);
                    MessageBox.Show("Zjadłeś " + zmienne.dataWords[1] + " ,które w 100g zawierają " + zmienne.dataWords[2] + "g cukru " + "\n" + "a w Twojej porcji(" + textBox_user_ilosc_produktu.Text + "g) zjadłeś " + (ilosc_cukru) + "g cukru." + "\n" + "Dbaj o zdrowie :-)"+"\n");
                }
                if(comboBox_user_wybor_ilosci.Text == "militrów")
                {
                    double ilosc = (Convert.ToDouble(textBox_user_ilosc_produktu.Text)) / 100;
                    double ilosc_cukru = ilosc * Convert.ToDouble(zmienne.dataWords[2]);
                    MessageBox.Show("Wypiłeś " + zmienne.dataWords[1] + " ,które w 100ml zawierają " + zmienne.dataWords[2] + "g cukru " + "\n" + "a w Twojej porcji(" + textBox_user_ilosc_produktu.Text + "ml) wypiłeś " + (ilosc_cukru) + "g cukru." + "\n" + "Dbaj o zdrowie :-)");
                }
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_user_wpisz_kod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_user_ilosc_produktu_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_user_wybor_ilosci_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnZweryfikuj_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //txtFilePath.Text = openFileDialog1.FileName;
            ///string plik = "C:\\Users\\DELL\\Desktop\\xd2.csv";
            //BindDataCSV2(zmienne.AdresPliku);
        }

        public void BindDataCSV2(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header

                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(';');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                // for data 

                for (int r = 1; r < lines.Length; r++)
                {
                    //int nr_lini = Convert.ToInt32(textBox_user_wpisz_kod.Text);
                    zmienne.dataWords = lines[r].Split(';');
                    DataRow dr = dt.NewRow();
                    int columIndex = 0;
                    foreach (string headerWord in headerLabels) // XD jak zapisać pojedyncze tablice
                    {

                    dr[headerWord] = zmienne.dataWords[columIndex++];
                    //string[] tabela = zmienne.dataWords;
                    //new int []  = new int ;
                    }
                    if (dt.Rows.Count > 0)
                    {
                    //object DataGrindViev.DataSource { get; set; }
                    dgvEmployees.DataSource = dt;
                    //MessageBox.Show(lines[1]);
                    // int kod_kresk = Convert.ToInt32(lines[1]);


                }
                //label1.Text = zmienne.dataWords[3];
                dt.Rows.Add(dr);
                }

                //if (comboBox_user_wybor_ilosci.Text == "gram")
                //{
                //    double ilosc = (Convert.ToDouble(textBox_user_ilosc_produktu.Text)) / 100;
                //    double ilosc_cukru = ilosc * Convert.ToDouble(zmienne.dataWords[2]);
                //    MessageBox.Show("Zjadłeś " + zmienne.dataWords[1] + " ,które w 100g zawierają " + zmienne.dataWords[2] + " cukru " + "\n" + "a w Twojej porcji(" + textBox_user_ilosc_produktu.Text + "g) zjadłeś " + (ilosc_cukru) + " cukru." + "\n" + "Dbaj o zdrowie :-)");
                //}
                //if (comboBox_user_wybor_ilosci.Text == "militrów")
                //{
                //    double ilosc = (Convert.ToDouble(textBox_user_ilosc_produktu.Text)) / 100;
                //    double ilosc_cukru = ilosc * Convert.ToDouble(zmienne.dataWords[2]);
                //    MessageBox.Show("Wypiłeś " + zmienne.dataWords[1] + " ,które w 100g zawierają " + zmienne.dataWords[2] + " cukru " + "\n" + "a w Twojej porcji(" + textBox_user_ilosc_produktu.Text + "g) wypiłeś " + (ilosc_cukru) + " cukru." + "\n" + "Dbaj o zdrowie :-)");
                //}
                //textBox_user_wpisz_nazwe.Text = zmienne.dataWords[1];
            }
        }

        private void sprawdzanie_poziomu_Load(object sender, EventArgs e)
        {
            BindDataCSV2(zmienne.AdresPliku);
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

