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
    public partial class FormUpdateMedicine : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;port=5432;username=postgres;password=2002;database=Clinic_Management;");
        NpgsqlCommand cmd;
        int medicineId;
        public FormUpdateMedicine(int patient_id, string name, string cmpName, int stock, string date)
        {
            InitializeComponent();
            MenuUserControl menuUserControl = new MenuUserControl();
            menuUserControl.Dock = DockStyle.Top;
            this.Controls.Add(menuUserControl);

            medicineId =patient_id;
            txtName.Text = name;
            txtCompany.Text = cmpName;
            txtStock.Text=stock.ToString();
            txtDate.Text = date;
        }

        private void FormUpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Please enter Cmpany name");
            }
            else if (stock.ToString() == "")
            {
                MessageBox.Show("Please enter Medicne Stock");
            }
            else if (date == "")
            {
                MessageBox.Show("Please enter Expiry date");
            }
            else
            {
                con.Open();
                cmd = new NpgsqlCommand("update Medicines set Medicine_Name= '" + medicineName + "', Company_Name= '" + companyName +
                    "', Medicine_Stock= " + stock + ", Expiry_Date= '" + date + "' where Medicine_Id= " + medicineId, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                ShowMedicineFunction();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowMedicineFunction();
        }
        private void ShowMedicineFunction()
        {
            medicineForm f = new medicineForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
