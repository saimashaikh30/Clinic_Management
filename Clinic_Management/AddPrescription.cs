using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class AddPrescription : UserControl
    {
        public int patient_id {  get; set; }
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        DataSet ds;
        NpgsqlCommand cmd;
        public AddPrescription(string prescriptiondata)
        {
            InitializeComponent();
            patient_id=int.Parse(prescriptiondata);
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            adapter = new NpgsqlDataAdapter("select * from Patients where patient_id=" + patient_id, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();
            txtAge.Text = ds.Tables[0].Rows[0]["age"].ToString();
            txtcontact.Text = ds.Tables[0].Rows[0]["contact_no"].ToString();
            txtGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd=new NpgsqlCommand("insert into Prescription(p_date,disease,prescription,patient_id) values(@p_date,@disease,@prescription,@patient_id);", conn);
            cmd.Parameters.AddWithValue("@p_date", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@disease",txtDisease.Text);
            cmd.Parameters.AddWithValue("@prescription",txtpres.Text);
            cmd.Parameters.AddWithValue("patient_id", patient_id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                AddPres_Med addmed = new AddPres_Med();
                this.Controls.Clear();
                this.Dock = DockStyle.Fill;
                this.Controls.Add(addmed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            this.Controls.Clear();
            this.Dock = DockStyle.Fill;
            this.Controls.Add(patient);
        }
    }
}
