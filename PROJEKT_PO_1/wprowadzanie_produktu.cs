using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROJEKT_PO_1
{
    public partial class wprowadzanie_produktu : Form
    {
        public wprowadzanie_produktu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_menu_admin_wprowadzanie_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Visible = false;
        }

        private void button_admin_zatwierdz_wprowadzenie_Click(object sender, EventArgs e)
        {
            String produkt_wpis = "\r\n" + textBox_admin_wpisz_kod.Text + ";" + textBox_admin_wpisz_nazwe.Text + ";" + textBox1.Text;
            File.AppendAllText(zmienne.AdresPliku, produkt_wpis);
            MessageBox.Show("Twój produkt "+ textBox_admin_wpisz_nazwe.Text + " został zapisany", "Wprowadzanie produktów", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBazaDanych_Click(object sender, EventArgs e)
        {
            new BazaDanych().Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
