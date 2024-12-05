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
    public partial class medicineForm : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        DataSet ds;
        public medicineForm()
        {
            InitializeComponent();
        }

        private void home_form_Load(object sender, EventArgs e)
        {
            MenuUserControl menuUserControl = new MenuUserControl();
            menuUserControl.Dock = DockStyle.Top;
            this.Controls.Add(menuUserControl); 
            //con.Open();
            adapter = new NpgsqlDataAdapter("select * from Medicines;", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            updateLink();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //con.Open();
            string medicineName = txtSearch.Text;
            adapter = new NpgsqlDataAdapter("select * from Medicines where medicine_name like '%" + medicineName + "%';", con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            updateLink();
        }
        private void updateLink()
        {
            if (!dataGridView1.Columns.Contains("updateLink"))
            {
                DataGridViewLinkColumn link = new DataGridViewLinkColumn()
                {
                    Name = "updateLink",
                    Text = "Update",
                    UseColumnTextForLinkValue = true

                };
                link.DisplayIndex = dataGridView1.Columns.Count;
                dataGridView1.Columns.Add(link);
                //con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["updateLink"].Index && e.RowIndex >= 0)
            {
                int medicineId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Medicine_Id"].Value.ToString());
                string medicineName = dataGridView1.Rows[e.RowIndex].Cells["Medicine_Name"].Value.ToString();
                string companyName = dataGridView1.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                int stock = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Medicine_Stock"].Value.ToString());
                string expiryDate = dataGridView1.Rows[e.RowIndex].Cells["Expiry_Date"].Value.ToString();

                FormUpdateMedicine updateMedicine = new FormUpdateMedicine(medicineId,medicineName,companyName,stock,expiryDate);
                this.Hide();
                updateMedicine.ShowDialog();
                this.Close();
            }
        }

        private void panelShowMedicine_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
