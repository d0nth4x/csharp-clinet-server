using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PrettyPatient;

namespace SupaAppClient
{
    //public partial class Form1 : Form
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        DBserviceReference.DBServiceClient client = new DBserviceReference.DBServiceClient();
        protected int userId = 0;

        public MainForm(int user_id)
        {
            this.userId = user_id; //zalogowany user
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPatientList();
        }

        private void LoadPatientList()
        {
            DBserviceReference.Patient[] pList = client.GetAllPatients();

            PatientsGrid.DataSource = pList;
            PatientsGrid.Columns[1].HeaderText = "Imię";
            PatientsGrid.Columns[2].HeaderText = "Nazwisko";
        }

        private void ToggleEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if(ToggleEditMode.Checked == true)
            {
                TPatientAdd.Enabled = true;
                TPatientRemove.Enabled = true;
            }
            else
            {
                TPatientAdd.Enabled = false;
                TPatientRemove.Enabled = false;
            }
        }

        private void TPatientRemove_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(PatientsGrid.Rows[PatientsGrid.CurrentRow.Index].Cells[0].Value);

            if (MessageBox.Show("Czy chcesz usunąć pacjenta?", "Zapytanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Debug.WriteLine(pid.ToString());
                bool returnmsg = client.DeletePatient(this.userId, pid);
                if (returnmsg)
                {
                    LoadPatientList();
                }
                else
                {
                    MessageBox.Show("Brak uprawnień!\nWymagany Security Level na poziomie: 9", "Ojejka, to straszne!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TPatientAdd_Click(object sender, EventArgs e)
        {
            if(TBNewPatientName.Text == "")
            {
                //blad
            }else if (TBNewPatientSurname.Text == ""){
                //blad 2
            }
            else
            {
                bool retmsg = client.CreatePatient(userId, TBNewPatientName.Text, TBNewPatientSurname.Text);
                if (retmsg)
                {
                    Debug.WriteLine("true");
                    LoadPatientList();
                }
                else
                {
                    Debug.WriteLine("false");

                }
            }



        }
    }
}
