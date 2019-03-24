using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupaAppClient
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        DBserviceReference.DBServiceClient client = new DBserviceReference.DBServiceClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TbPassword.PasswordChar = '\u25CF';
        }

        private void BtnZaloguj_Click(object sender, EventArgs e)
        {
            int returnmsg = client.Login(TbLogin.Text, TbPassword.Text); //returnmsg - id usera
            if ( returnmsg > 0)
            {
                Debug.WriteLine("ok");

                MainForm f = new MainForm(returnmsg);
                f.Show();
                //lf.Close();

                //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));


                this.Hide();
                f.Closed += (s, args) => this.Close();
                f.Show();

            }
            else
            {
                Debug.WriteLine("nope");
            }
        }
    }
}
