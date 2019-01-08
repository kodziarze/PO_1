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

        private void comboBox_user_wybor_ilosci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_user_zatwierdz_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
