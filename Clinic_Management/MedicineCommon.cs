using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management
{
    public partial class MedicineCommon : UserControl
    {
        public MedicineCommon()
        {
            InitializeComponent();
            ShowMedicine medicine = new ShowMedicine();
            switchPage(medicine);
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            
        }

        private void medicineInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            ShowMedicine medicine = new ShowMedicine();
            switchPage(medicine);                     
        }

        public void switchPage(Control Page)
        {
            panel1.Controls.Clear();        
            panel1.Controls.Add(Page);
        }

        private void addMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            switchPage(addMedicine);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            menuStrip1.Enabled = false;
            menuStrip1.Visible = false;
            panel1.Controls.Add(new Dashboard());
        }
    }
}
