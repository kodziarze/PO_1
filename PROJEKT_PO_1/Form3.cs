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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_menu_logowanie_admina_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Visible = false;

        }

        private void button_zaloguj_admin_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Visible = false;
        }
    }
}
