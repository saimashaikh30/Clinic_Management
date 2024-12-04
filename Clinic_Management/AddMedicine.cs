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
    public partial class AddMedicine : UserControl
    {
        NpgsqlConnection conn=new NpgsqlConnection("Host=localhost;port=5432;username=postgres;password=2002;database=Clinic_Management");
        NpgsqlCommand cmd;
        public AddMedicine()
        {
            InitializeComponent();
            

        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            string medicineName=txtName.Text;
            string companyName=txtCompany.Text;
            int stock=Convert.ToInt32(txtStock.Text);
            string date=txtDate.Text;

            if(medicineName == "")
            {
                MessageBox.Show("Please enter Medicine name");
            }
            else if(companyName == "")
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
