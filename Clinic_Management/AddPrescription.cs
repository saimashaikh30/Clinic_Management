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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDisease_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
