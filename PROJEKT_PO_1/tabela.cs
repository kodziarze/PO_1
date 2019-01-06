using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_PO_1
{
    public partial class tabela : Form
    {
        public tabela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(jedzenie));
                        foreach(jedzenie s in jedzenieBindingSource.DataSource as List<jedzenie>)
                        {
                            writer.WriteRecord(s);
                        }
                    }
                    MessageBox.Show("Twoje dane zostały zapisane","Wiadmość", MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
        }

        private void tabela_Load(object sender, EventArgs e)
        {
            jedzenieBindingSource.DataSource = new List<jedzenie>();
        }

        private void wczyatnie_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName,FileMode.Open));
                    var csv = new CsvReader(sr);
                    jedzenieBindingSource.DataSource = csv.GetRecord<jedzenie>().ToString();
                }
            }
        }
    }
}
