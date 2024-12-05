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
    public partial class FormAddPrescription : Form
    {
        public int patient_id { get; set; }
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        DataSet ds;
        NpgsqlCommand cmd;
        public FormAddPrescription(string prescriptiondata)
        {
            InitializeComponent();
            patient_id = int.Parse(prescriptiondata);
        }

        private void FormAddPrescription_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new NpgsqlDataAdapter("select * from Patients where patient_id=" + patient_id, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();
            txtAge.Text = ds.Tables[0].Rows[0]["age"].ToString();
            txtcontact.Text = ds.Tables[0].Rows[0]["contact_no"].ToString();
            txtGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new NpgsqlCommand("insert into Prescription(p_date,disease,prescription,patient_id) values(@p_date,@disease,@prescription,@patient_id);", conn);
            cmd.Parameters.AddWithValue("@p_date", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@disease", txtDisease.Text);
            cmd.Parameters.AddWithValue("@prescription", txtpres.Text);
            cmd.Parameters.AddWithValue("patient_id", patient_id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                FormAddPres_Med addmed = new FormAddPres_Med();
                this.Hide();
                addmed.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient();
            this.Hide();
            formPatient.ShowDialog();
            this.Close();
        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
