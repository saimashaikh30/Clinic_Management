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
    public partial class FormAddMedicine : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;port=5432;username=postgres;password=2002;database=Clinic_Management");
        NpgsqlCommand cmd;
        public FormAddMedicine()
        {
            InitializeComponent();
            MenuUserControl menuUserControl = new MenuUserControl();
            menuUserControl.Dock = DockStyle.Top;
            this.Controls.Add(menuUserControl);
        }

        private void FormAddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            string medicineName = txtName.Text;
            string companyName = txtCompany.Text;
            int stock = Convert.ToInt32(txtStock.Text);
            string date = txtDate.Text;

            if (medicineName == "")
            {
                MessageBox.Show("Please enter Medicine name");
            }
            else if (companyName == "")
            {
                MessageBox.Show("Please enter Company name");
            }
            else if (stock.ToString() == "")
            {
                MessageBox.Show("Please enter Medicine Stock");
            }
            else if (date == "")
            {
                MessageBox.Show("Please enter Expiry date");
            }
            else
            {
                cmd = new NpgsqlCommand("insert into Medicines(Medicine_Name,Company_Name,Medicine_Stock,Expiry_Date) values ('" +
                medicineName + "', '" + companyName + "', " + stock + ", '" + date + "');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Medicine Information Saved Successfully");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "";
            txtName.Text = "";
            txtStock.Text = "";
            txtDate.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
