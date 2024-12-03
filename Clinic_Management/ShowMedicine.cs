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
    public partial class ShowMedicine : UserControl
    {
        NpgsqlConnection con =new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        DataSet ds;
        public ShowMedicine()
        {
            InitializeComponent();
               
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void updateLink()
        {
            DataGridViewLinkColumn link = new DataGridViewLinkColumn()
            {
                Name = "updateLink",
                Text = "Update",
                UseColumnTextForLinkValue = true
                
            };
            link.DisplayIndex = dataGridView1.Columns.Count;
            dataGridView1.Columns.Add(link);
            con.Close();
        }

        private void ShowMedicine_Load(object sender, EventArgs e)
        {
            con.Open();
            adapter = new NpgsqlDataAdapter("select * from Medicines;", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            updateLink();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["updateLink"].Index && e.RowIndex >= 0)
            {
                string medicineName = dataGridView1.Rows[e.RowIndex].Cells["Medicine_Name"].Value.ToString ();
                string companyName = dataGridView1.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                string stock = dataGridView1.Rows[e.RowIndex].Cells["Medicine_Stock"].Value.ToString();
                string expiryDate = dataGridView1.Rows[e.RowIndex].Cells["Expiry_Date"].Value.ToString();

                UpdateMedicine updateMedicine = new UpdateMedicine();
                updateMedicine.setDetails(medicineName,companyName,stock,expiryDate);
                panelShowMedicine.Controls.Clear();
                panelShowMedicine.Controls.Add(updateMedicine);

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string medicineName = txtSearch.Text;
            adapter = new NpgsqlDataAdapter("select * from Medicines where Medicine_Name like '" + medicineName + "';", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            updateLink();
        }
    }
}
