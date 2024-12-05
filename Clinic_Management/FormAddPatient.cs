using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Management
{
    public partial class FormAddPatient : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlCommand cmd;
        public FormAddPatient()
        {
            InitializeComponent();
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new NpgsqlCommand("insert into Patients(name,age,contact_no,gender) values(@name,@age,@contact_no,@gender);", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@contact_no", txtcontact.Text);
            string gender = cmbGender.Text;
            cmd.Parameters.AddWithValue("@gender", gender);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                ShowPatient();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowPatient();
        }

        private void ShowPatient()
        {
            FormPatient p = new FormPatient();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtcontact.Text = "";
            txtAge.Text = "";
            cmbGender.SelectedIndex = 0;
        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
