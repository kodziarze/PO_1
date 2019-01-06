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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_panel_admina_Click(object sender, EventArgs e)
        {
            
            new logowanie_administartora().Show();
            this.Visible = false;
        }

        private void button_sprawdz_poziom_glukozy_Click(object sender, EventArgs e)
        {
            new sprawdzanie_poziomu().Show();
            this.Visible = false;
        }

        private void button_zadzwon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JUŻ DZWONIE ODDYCHAJ GŁĘBOKO");
            MessageBox.Show("IOIOIOIOIOI");
            MessageBox.Show("IOIOIOIOIOI");
            MessageBox.Show("IOIOIOIOIOI");
            MessageBox.Show("IOIOIOIOIOI");
            MessageBox.Show("IOIOIOIOIOI");
            MessageBox.Show("JIOIOIOIOIOIO");
            Application.Exit();

        }
        //private void form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();//Bezwarunkowe zamknięcie aplikacji
        //}
    }
}
