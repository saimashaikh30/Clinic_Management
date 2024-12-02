﻿using System;
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
            cmd = new NpgsqlCommand("insert into Medicines(Medicine_Name,Company_Name,Medicine_Stock,Expiry_Date) values ('" +
                medicineName + "', '" + companyName + "', " + stock + ", '" + date + "');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Medicine Information Saved Successfully");
        }
    }
}
