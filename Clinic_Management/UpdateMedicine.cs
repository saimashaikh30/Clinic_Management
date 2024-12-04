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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Clinic_Management
{
    public partial class UpdateMedicine : UserControl
    {
        NpgsqlConnection con=new NpgsqlConnection("Host=localhost;port=5432;username=postgres;password=2002;database=Clinic_Management;");
        NpgsqlCommand cmd;
        int medicineId;
        
        public UpdateMedicine()
        {
            InitializeComponent();            
        }

        private void UpdateMedicine_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
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
                    "', Medicine_Stock= " + stock + ", Expiry_Date= '" + date +"' where Medicine_Id= " + medicineId,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                panel1.Controls.Clear();
                panel1.Controls.Add(new ShowMedicine());
            }
        }

        public void setDetails(int medicineId,string medicineName, string companyName, int stock, string expiryDate)
        {
            txtName.Text=medicineName.ToString();
            txtCompany.Text=companyName.ToString();
            txtStock.Text=stock.ToString();
            txtDate.Text=expiryDate.ToString();
            this.medicineId = medicineId;
        } 
    }
}
