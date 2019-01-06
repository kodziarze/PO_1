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
    public partial class logowanie_administartora : Form
    {
        public logowanie_administartora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_menu_logowanie_admina_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Visible = false;

        }
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
        internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
        {

            private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

            public static Settings Default
            {
                get
                {
                    return defaultInstance;
                }
            }

            [global::System.Configuration.ApplicationScopedSettingAttribute()]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Configuration.DefaultSettingValueAttribute("admin")]
            public string Login
            {
                get
                {
                    return ((string)(this["Login"]));
                }
            }

            [global::System.Configuration.ApplicationScopedSettingAttribute()]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Configuration.DefaultSettingValueAttribute("1234")]
            public string Haslo
            {
                get
                {
                    return ((string)(this["Haslo"]));
                }
            }
        }

        private void button_zaloguj_admin_Click(object sender, EventArgs e)
        {
            // Wbudowane deklaracje stałych do porównania z wartościami wprowadzonymi 
            string admin = "admin";
            string haslo = "admin";
            if ((textBox_login.Text == admin) && (textBox_haslo.Text == haslo)) // name.Text => TextBox; password.Text => MaskedTextBox... ewentualnie TextBox

            {
                // otwarcie nowego okna po poprawnych danych
                new wprowadzanie_produktu().Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Zły login lub hasło", "Szanowny administratorze błędne dane logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);//MsgBox zle dane logowania
            }
        }
    }
}

