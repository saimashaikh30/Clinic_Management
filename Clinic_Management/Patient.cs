using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
namespace Clinic_Management
{
    public partial class Patient : UserControl
    {
       
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        DataSet ds;
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            
            adapter=new NpgsqlDataAdapter("select * from Patients order by patient_id desc;", conn);
            ds = new DataSet();
            adapter.Fill(ds);
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
            {
                Name = "Prescription", 
                HeaderText = "Prescription",
                Text = "Add",
                UseColumnTextForLinkValue = true
            };

       
            dataGridView1.Columns.Add(linkColumn);
            DataGridViewLinkColumn linkColumn1 = new DataGridViewLinkColumn
            {
                Name = "Details",
                HeaderText = "Details",
                Text = "View",
                UseColumnTextForLinkValue = true
            };


            dataGridView1.Columns.Add(linkColumn1);
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            adapter =new NpgsqlDataAdapter("select * from Patients where name like @search", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search","%"+txtsearch.Text+"%");
            ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Prescription"].Index && e.RowIndex >= 0)
            {
                string patient_id = dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value.ToString();
                FormAddPrescription addPrescription = new FormAddPrescription(patient_id);
                this.Controls.Clear();
                this.Controls.Add(addPrescription);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddPatient d = new FormAddPatient();
            this.Hide();
            d.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}