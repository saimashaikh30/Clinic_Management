﻿using Npgsql;
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
            conn.Open();
            adapter = new NpgsqlDataAdapter("select * from Patients where patient_id=" + patient_id, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
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
                conn.Close();
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

        private void txtpres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDisease_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
